using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using ClassLibrary.EntityData;

namespace SMART_ERP_System.MenuUserControl
{
    public partial class BOM등록및정전개 : UserControl
    {

        int itemCnt;
        List<자재명세서> List = new List<자재명세서>();

        public BOM등록및정전개()
        {
            InitializeComponent();
            dataGridView2.Columns.Add("순", "순");
            dataGridView2.Columns.Add("자재번호", "자재번호");
            dataGridView2.Columns.Add("수량", "수량");
        }

        void serchMaterial()
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int rows = dataGridView2.Rows.Count;

            if (rows > 0)
            {
                for (int i = 0; i < rows - 1; i++)
                {
                    dataGridView2.Rows.Remove(dataGridView2.Rows[0]);
                }
            }

            string material = textBox1.Text;
            if (material != "")
            {
                using (ERPEntities entity = new ERPEntities())
                {
                    List = entity.자재명세서.Where(x => x.제품번호.ToString() == material).ToList();
                    int i = 0;
                    foreach (var Item in List)
                    {
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[i].Cells[0].Value = i + 1;
                        dataGridView2.Rows[i].Cells[1].Value = Item.자재번호;
                        dataGridView2.Rows[i++].Cells[2].Value = Item.수량;
                    }
                    itemCnt = i;
                }
                dataGridView2.Focus();
                dataGridView2.CurrentCell = dataGridView2[1, 0];
            }
        }

        private void DataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (itemCnt <= dataGridView2.CurrentCellAddress.Y)
                    dataGridView2.Rows[dataGridView2.CurrentCellAddress.Y].Cells[dataGridView2.CurrentCellAddress.X].Value = null;
                else
                    MessageBox.Show("저장된 데이터는 지금 삭제 할 수 없습니다.");
            }


            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                int column = dataGridView2.CurrentCell.ColumnIndex;
                int row = dataGridView2.CurrentCell.RowIndex;
                int rowcnt = dataGridView2.Rows.Count - 1;

                if (column == dataGridView2.Columns.Count - 1)
                {
                    if ((rowcnt == dataGridView2.CurrentCell.RowIndex) && (dataGridView2.Rows[rowcnt].Cells[2].Value != null) && (column == dataGridView2.Columns.Count - 1))
                    {
                        dataGridView2.Rows.Add();

                        dataGridView2.CurrentCell = dataGridView2[1, row + 1];

                    }
                    else if ((rowcnt > dataGridView2.CurrentCell.RowIndex) && (dataGridView2.Columns.Count - 1 == dataGridView2.CurrentCell.ColumnIndex))
                    {
                        dataGridView2.CurrentCell = dataGridView2[1, row + 1];
                    }
                }
                else
                {
                    dataGridView2.CurrentCell = dataGridView2[column + 1, row];
                }

            }
        }

        private void DataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[0].Value = (dataGridView2.Rows.Count).ToString();
        }

        private void DataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            //itemCnt == 지금 뿌려진 아이템 개수를 확인 DB에 저장되어있는 DELETE키로 값을 지울수 없음
            if (dataGridView2.CurrentRow.Index >= itemCnt)
            {
                int x = dataGridView2.CurrentCellAddress.X;
                int y = dataGridView2.CurrentCellAddress.Y;
                if (dataGridView2.CurrentCell.ColumnIndex == 1)
                {
                    if (dataGridView2.Rows[y].Cells[x].Value == null)
                        return;


                    string CurrentValue = dataGridView2.Rows[y].Cells[x].Value.ToString();
                    int CursorI = 0;
                    List<자재> 자재list = DB.자재.GetAll();
                    if (자재list.Where(h => h.자재번호 == CurrentValue).Count() == 0)
                    {
                        MessageBox.Show("해당 자재번호는 없는 번호 입니다.");
                        dataGridView2.Rows[y].Cells[x].Value = null;
                        return;
                    }

                    dataGridView2.CurrentCell = dataGridView2[x + 1, y];
                    foreach (var item in List)
                    {

                        if (CurrentValue == item.자재번호.ToString())
                        {
                            MessageBox.Show("이미 등록된 자재가 있습니다.");
                            dataGridView2.Rows[y].Cells[x].Value = null;
                            dataGridView2.CurrentCell = dataGridView2.Rows[CursorI].Cells[x + 1];
                            break;
                        }
                        CursorI++;
                    }

                    

                }
                else if (dataGridView2.CurrentCell.ColumnIndex == 2)
                {
                    if (dataGridView2.Rows[y].Cells[x].Value == null)
                    {
                        return;
                    }


                    if (dataGridView2.Rows[y].Cells[x - 1].Value == null)
                    {
                        MessageBox.Show("자재를 먼저 입력하세요");
                        dataGridView2.Rows[y].Cells[x].Value = null;
                        dataGridView2.CurrentCell = dataGridView2[x -1, y];
                        return;
                    }


                    if (ZeroChk(dataGridView2.Rows[y].Cells[x]) == 0)
                    {
                        MessageBox.Show("잘못 입력하셨습니다.\n'1' 이상의 숫자를 입력하세요!");
                        dataGridView2.Rows[y].Cells[x].Value = null;
                        return;
                    }
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("저장하시겠습니까?", "저장", MessageBoxButtons.YesNo))
                        {
                            자재명세서 자재명세서 = new 자재명세서();
                            자재명세서.자재번호 = dataGridView2.Rows[y].Cells[x - 1].Value.ToString();
                            자재명세서.제품번호 = textBox1.Text;
                            자재명세서.수량 = int.Parse(dataGridView2.Rows[y].Cells[x].Value.ToString());
                            DB.자재명세서.Insert(자재명세서);
                            itemCnt++;
                        }
                        else
                        {
                            dataGridView2.Rows[y].Cells[x].Value = null;
                            dataGridView2.Rows[y].Cells[x - 1].Value = null;
                        }

                    }
                }

            }

        }




        private int ZeroChk(DataGridViewCell cell)
        {
            int.TryParse(cell.Value.ToString(), out int result);
            return result;
        }











    }
}
