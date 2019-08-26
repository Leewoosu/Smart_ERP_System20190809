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
        string currentvalue;
        int itemCnt;
        List<자재명세서> List = new List<자재명세서>();
        List<자재> 자재List;
        public BOM등록및정전개()
        {
            InitializeComponent();

            cbxLocal.Items.Add("EA");
            cbxLocal.Items.Add("mm");
            cbxLocal.Items.Add("KG");
            cbxJo.Items.Add("생산");
            cbxJo.Items.Add("구매");
            cbxLocal.SelectedIndex = 0;
            cbxJo.SelectedIndex = 0;
            dataGridView2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            getList();
        }


        public void getList()
        {

            List = DB.자재명세서.GetAll();
            자재List = DB.자재.GetAll();
        }

        public void dataGridSerch()
        {
            treeView1.Nodes.Clear();
            int rows = dataGridView2.Rows.Count;

            if (rows > 0)
            {
                for (int i = 0; i < rows - 1; i++)
                {
                    dataGridView2.Rows.Remove(dataGridView2.Rows[0]);
                }
            }

            string material = textBox1.Text;
            var ListDetail = List.Where(x => x.제품번호 == material).OrderBy(x => x.공정순서).ToList();
            int j = 0;
            foreach (var Item in ListDetail)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[j].Cells[0].Value = j + 1;
                dataGridView2.Rows[j].Cells[1].Value = Item.자재번호;
                dataGridView2.Rows[j].Cells[2].Value = Item.수량;
                dataGridView2.Rows[j].Cells[3].Value = Item.공정순서;
                dataGridView2.Rows[j++].Cells[4].Value = Item.모품목;
            }


            itemCnt = j;
            dataGridView2.Focus();
            dataGridView2.CurrentCell = dataGridView2[0, 0];

            foreach (var item in ListDetail)
            {
                if (item.모품목 == null)
                    treeView1.Nodes.Add(item.자재번호, item.자재번호);
            }

            foreach (var item in ListDetail)
            {
                int check = treeView1.Nodes.Find(item.모품목, true).Length;
                if (check > 0)
                {
                    int inputNum = treeView1.Nodes.Find(item.모품목, true).Length - 1;
                    treeView1.Nodes.Find(item.모품목, true)[inputNum].Nodes.Add(item.자재번호, item.자재번호);
                }
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (List.Where(x => x.제품번호 == textBox1.Text).Count() > 0)
            {
                dataGridSerch();
            }
            else
            {
                dataGridView2.Rows.Clear();
                MessageBox.Show("조건에 해당하는 자재가 없습니다.");
            }

        }

        private int ZeroChk(DataGridViewCell cell)
        {
            int.TryParse(cell.Value.ToString(), out int result);
            return result;
        }

        private void DataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int yPoint = e.ColumnIndex;
            int xPoint = e.RowIndex;
            if (dgv.Rows[xPoint].Cells[yPoint].Value == null)
                return;

            string materials = dgv.Rows[xPoint].Cells[1].Value.ToString();
            edit(materials);
        }

        private void edit(string materials)
        {
            var 자재ListDetail = 자재List.Where(y => y.자재번호 == materials).ToList();
            var 명세서List = List.Where(y => y.자재번호 == materials).ToList();
            txbMaterialNum.Text = textBox1.Text;
            txb자재.Text = 명세서List[0].자재번호.ToString();
            txbMaterialName.Text = 자재ListDetail[0].자재명.ToString();
            txbPrice.Text = 자재ListDetail[0].구매단가.ToString();
            txbQty.Text = 명세서List[0].수량.ToString();
            txbProcessNum.Text = 명세서List[0].공정순서.ToString();
            if (명세서List[0].모품목 == null)
            {
                txbPrentM.Text = 명세서List[0].제품번호.ToString();
            }
            else
            {
                txbPrentM.Text = 명세서List[0].모품목.ToString();
            }

            cbxLocal.Text = 자재ListDetail[0].단위.ToString();
        }

        private void DataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            int xPoint = dgv.CurrentCell.RowIndex;
            int yPoint = dgv.CurrentCell.ColumnIndex;
            int ColCnt = dgv.ColumnCount - 1;
            int RowCnt = dgv.RowCount - 1;

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (yPoint < ColCnt)
                {
                    dgv.CurrentCell = dgv[yPoint + 1, xPoint];
                }
                else if (xPoint < RowCnt)
                {
                    dgv.CurrentCell = dgv[0, xPoint + 1];
                }
                else if (xPoint == RowCnt && dgv.Rows[xPoint].Cells[1].Value != null && xPoint == itemCnt - 1)
                {
                    dgv.Rows.Add();
                    dgv.CurrentCell = dgv[0, xPoint + 1];
                }
                else if (xPoint == RowCnt && dgv.Rows[xPoint].Cells[1].Value != null
                         && dgv.Rows[xPoint].Cells[2].Value != null
                         && dgv.Rows[xPoint].Cells[3].Value != null
                        )
                {
                    if (DialogResult.OK == MessageBox.Show("저장하시겠습니까 ?", "Save", MessageBoxButtons.OKCancel))
                    {

                        자재명세서 SaveRow = new 자재명세서();

                        SaveRow.제품번호 = textBox1.Text;
                        SaveRow.자재번호 = dgv.Rows[xPoint].Cells[1].Value.ToString();
                        SaveRow.수량 = int.Parse(dgv.Rows[xPoint].Cells[2].Value.ToString());
                        SaveRow.공정순서 = int.Parse(dgv.Rows[xPoint].Cells[3].Value.ToString());
                        SaveRow.모품목 = dgv.Rows[xPoint].Cells[3].Value.ToString();
                        itemCnt++;
                        DB.자재명세서.Insert(SaveRow);
                        MessageBox.Show("저장되었습니다.");
                        List = DB.자재명세서.GetAll();
                        Button1_Click(null, null);
                    }
                }
            }

            if (e.KeyCode == Keys.Delete)
            {
                if (xPoint <= itemCnt - 1)
                {
                    MessageBox.Show("삭제는 자재테이블에서 가능합니다.");
                }
                else
                {
                    dgv.CurrentRow.Cells[yPoint].Value = null;
                }
            }


        }

        private void DataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int xPoint = e.RowIndex;
            int yPoint = e.ColumnIndex;
            int ColCnt = dgv.ColumnCount - 1;
            int RowCnt = dgv.RowCount - 1;


            if (dgv.CurrentRow.Cells[yPoint].Value == null)
                return;

            if (xPoint <= itemCnt - 1 && currentvalue != dgv.CurrentRow.Cells[yPoint].Value.ToString())
            {
                MessageBox.Show("편집할수 없습니다.");
                dgv.CurrentRow.Cells[yPoint].Value = currentvalue;
                return;
            }

            if (dgv.CurrentCell.ColumnIndex >= 2 && dgv.CurrentCell.ColumnIndex <= 3 && ZeroChk(dgv.CurrentCell) == 0)
            {
                MessageBox.Show("숫자입력만 가능합니다.");
                dgv.CurrentCell.Value = null;
                return;
            }

            if (xPoint == RowCnt || yPoint == 0)
            {
                string Check = dgv.CurrentCell.Value.ToString();
                if (List.Where(x => x.제품번호 == Check).Count() > 0)
                {
                    for (int i = 0; 0 < RowCnt - 1; i++)
                    {
                        MessageBox.Show(dgv.Rows[i].Cells[0].Value.ToString());
                        if (dgv.Rows[i].Cells[0].Value.ToString() == Check)
                        {
                            dgv.CurrentCell = null;
                            dgv.CurrentCell = dgv[2, i];
                            return;
                        }
                    }
                }
            }
        }

        private void DataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int xPoint = e.RowIndex;
            int yPoint = e.ColumnIndex;
            if (dgv.CurrentRow.Cells[yPoint].Value == null)
                currentvalue = "";
            else
                currentvalue = dgv.CurrentRow.Cells[yPoint].Value.ToString();
        }

        private void TreeView1_Click(object sender, EventArgs e)
        {
            TreeView dgv = (TreeView)sender;

            if (dgv.SelectedNode == null)
                return;

            string materials = dgv.SelectedNode.Name;
            edit(materials);
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                Button1_Click(null, null);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (List.Where(x => x.제품번호 == textBox2.Text).Count() < 0)
                {
                    MessageBox.Show("조건에 해당하는 품목이 없습니다.");
                    return;
                }
            }

            var copyList = List.Where(x => x.제품번호 == textBox1.Text).ToList();

            foreach (var item in copyList)
            {
                MessageBox.Show(item.자재번호.ToString());
                자재명세서 Addlist = new 자재명세서();
                Addlist.제품번호 = textBox2.Text;
                Addlist.자재번호 = item.자재번호;
                Addlist.수량 = item.수량;
                Addlist.공정순서 = item.공정순서;
                Addlist.모품목 = item.모품목;
                DB.자재명세서.Insert(Addlist);
            }

            List = DB.자재명세서.GetAll();
            Button1_Click(null, null);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            자재명세서 UpdateInfo = new 자재명세서();

            UpdateInfo.제품번호 = txbMaterialNum.Text;
            UpdateInfo.자재번호 = txb자재.Text;
            UpdateInfo.수량 = int.Parse(txbQty.Text);
            UpdateInfo.공정순서 = int.Parse(txbProcessNum.Text);
            UpdateInfo.모품목 = txbPrentM.Text;
            


            if (List.Where(g => g.제품번호 == UpdateInfo.제품번호 && g.자재번호 == UpdateInfo.자재번호).ToList().Count() > 0
               && UpdateInfo.수량 > 0 && UpdateInfo.공정순서 > 0)
            {
                if (자재List.Where(g=>g.자재번호.Trim() == txb자재.Text).Count() == 0)
                { 
                    MessageBox.Show("해당 자재는 없는 자재 입니다.");
                    return;
                }
                DB.자재명세서.Update(UpdateInfo);
                MessageBox.Show($"{UpdateInfo.제품번호}의 기존 {UpdateInfo.자재번호}를 업데이트 하였습니다.");
            }
            else if (UpdateInfo.제품번호 != string.Empty && UpdateInfo.자재번호 != string.Empty
                   && UpdateInfo.수량 > 0 && UpdateInfo.공정순서 > 0)
            {
                if (자재List.Where(g => g.자재번호 == UpdateInfo.자재번호).Count() == 0)
                {
                    MessageBox.Show("해당 자재는 없는 자재 입니다.");
                    return;
                }
                DB.자재명세서.Insert(UpdateInfo);
                MessageBox.Show($"{UpdateInfo.제품번호}의 새로운 {UpdateInfo.자재번호}를 업데이트 하였습니다.");
            }

            else
                MessageBox.Show("속성을 정확히 입력 하세요!");

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            자재명세서 UpdateInfo = new 자재명세서();

            UpdateInfo.제품번호 = txbMaterialNum.Text;
            UpdateInfo.자재번호 = txb자재.Text;
            UpdateInfo.수량 = int.Parse(txbQty.Text);
            UpdateInfo.공정순서 = int.Parse(txbProcessNum.Text);
            UpdateInfo.모품목 = txbPrentM.Text;


            DB.자재명세서.Delete(UpdateInfo);
            MessageBox.Show($"{UpdateInfo.제품번호}의 자재번호 : {UpdateInfo.자재번호}가 삭제 되었습니다.");

            List = DB.자재명세서.GetAll();
            Button1_Click(null, null);
        }
    }
}