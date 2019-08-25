using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.EntityData;
using SMART_ERP_System.Class;
using ClassLibrary;

namespace SMART_ERP_System.MainForm_Control
{
    public partial class 부문구분Control : UserControl
    {
        CodeHelperForm menuForm;

        public 부문구분Control()
        {
            InitializeComponent();
            부문등록BindingSource.DataSource = DB.부문.GetAll();
        }

        public void RecieveLoginForm(CodeHelperForm menuForm)
        {
            this.menuForm = menuForm;
        }

        private void Dgv부문_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                SelectSector();
            }

            if(e.KeyData == Keys.Delete)
            {
                e.SuppressKeyPress = true;

                if (DialogResult.Yes == MessageBox.Show("선택한 부문을 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo))                
                    DB.부문.Delete(FillInSector(dgv부문.CurrentCell.RowIndex));

                dgv부문.DataSource = DB.부문.GetAll();
            }

            if (e.KeyData == Keys.Escape)
            {
                menuForm.Close();
            }
        }

        private void Dgv부문_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectSector();
        }

        private void SelectSector()
        {
            if (dgv부문.CurrentRow.Cells[0].Value != null && dgv부문.CurrentRow.Cells[1].Value != null)
            {
                부문단위.SectorCode = dgv부문.CurrentRow.Cells[0].Value.ToString();
                부문단위.SectorName = dgv부문.CurrentRow.Cells[1].Value.ToString();

                menuForm.Close();
            }
        }

        private void BtnRegist_Click(object sender, EventArgs e)
        {
            var list = DB.부문.GetAll();

            for (int i = list.Count; i < dgv부문.RowCount - 1; i++)
            {
                if (dgv부문.Rows[i].Cells[0].Value != null && dgv부문.Rows[i].Cells[1].Value != null && dgv부문.Rows[i].Cells[2].Value != null)
                {
                    부문등록 부문 = FillInSector(i);

                    DB.부문.Insert(부문);                    
                }
            }

            MessageBox.Show("등록되었습니다.");
        }

        private 부문등록 FillInSector(int i)
        {
            부문등록 부문 = new 부문등록();

            부문.부문코드 = dgv부문.Rows[i].Cells[0].Value.ToString();
            부문.부문명 = dgv부문.Rows[i].Cells[1].Value.ToString();
            부문.사용시작기간 = DateTime.Parse(dgv부문.Rows[i].Cells[2].Value.ToString());

            if (dgv부문.Rows[i].Cells[3].Value != null)
                부문.사용종료기간 = DateTime.Parse(dgv부문.Rows[i].Cells[3].Value.ToString());

            return 부문;
        }

        private void Dgv부문_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var list = DB.부문.GetAll();
            string startDay, endDay;

            if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    startDay = dgv부문.Rows[i].Cells[2].Value.ToString();

                    if (dgv부문.Rows[i].Cells[3].Value != null)
                    {
                        endDay = dgv부문.Rows[i].Cells[3].Value.ToString();

                        if (list[i].부문코드 != dgv부문.Rows[i].Cells[0].Value.ToString() ||
                            list[i].부문명 != dgv부문.Rows[i].Cells[1].Value.ToString() ||
                            list[i].사용시작기간.ToString() != DateTime.Parse(startDay).ToShortDateString() ||
                            list[i].사용종료기간.ToString() != DateTime.Parse(endDay).ToShortDateString()
                            )
                        {
                            DB.부문.Update(FillInSector(i));
                        }
                    }
                    else
                    {
                        if (list[i].부문코드 != dgv부문.Rows[i].Cells[0].Value.ToString() ||
                        list[i].부문명 != dgv부문.Rows[i].Cells[1].Value.ToString() ||
                        list[i].사용시작기간.ToString() != DateTime.Parse(startDay).ToShortDateString()
                        )
                            DB.부문.Update(FillInSector(i));
                    }
                }
            }
        }
    }
}
