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
using SMART_ERP_System.MainForm_Control;
using SMART_ERP_System.Class;

namespace SMART_ERP_System.MenuUserControl
{
    public partial class 부서등록 : UserControl
    {
        부문구분Control 부문구분Control;
        사업장구분Control 사업장구분Control;

        public 부서등록()
        {
            InitializeComponent();

            dgv부서.Rows.Clear();

            사업장등록BindingSource.DataSource = DB.사업장.GetAll().Select(x => x.사업장코드);
            부서등록BindingSource.DataSource = DB.부서.FillIn(cbb사업장코드.SelectedValue.ToString());
        }

        private void Cbb사업장코드_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbb사업장코드.SelectedValue != null)
                txb사업장명.Text = DB.사업장.SearchChangedValue(cbb사업장코드.SelectedValue.ToString());
        }

        private void Cbx조회기준적용_CheckedChanged(object sender, EventArgs e)
        {
            dtp조회기준일.Enabled = cbx조회기준적용.Checked;
        }

        private void Dgv부서_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                if (dgv부서.CurrentCell.ColumnIndex == 2 || dgv부서.CurrentCell.ColumnIndex == 3)
                {
                    e.SuppressKeyPress = true;

                    사업장구분Control = new 사업장구분Control();
                    CodeHelperForm form = new CodeHelperForm(사업장구분Control);
                    form.ShowDialog();

                    dgv부서.CurrentRow.Cells[2].Value = 사업장단위.WorkPlaceCode;
                    dgv부서.CurrentRow.Cells[3].Value = 사업장단위.WorkPlaceName;

                    dgv부서.CurrentCell = dgv부서.CurrentRow.Cells[4];
                }

                if (dgv부서.CurrentCell.ColumnIndex == 4 || dgv부서.CurrentCell.ColumnIndex == 5)
                {
                    e.SuppressKeyPress = true;

                    부문구분Control = new 부문구분Control();
                    CodeHelperForm form = new CodeHelperForm(부문구분Control);
                    form.ShowDialog();

                    dgv부서.CurrentRow.Cells[4].Value = 부문단위.SectorCode;
                    dgv부서.CurrentRow.Cells[5].Value = 부문단위.SectorName;

                    dgv부서.CurrentCell = dgv부서.CurrentRow.Cells[6];
                }
            }

            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (dgv부서.CurrentCell.ColumnIndex == (dgv부서.Columns.Count - 1))
                {
                    // 마지막행의 여섯번째 열까지 입력이 끝나면 다음 행을 추가하고 다음 행의 첫번째 열로 이동
                    if ((dgv부서.Rows.Count - 1 == dgv부서.CurrentCell.RowIndex)
                        && (dgv부서.Rows[dgv부서.CurrentRow.Index]
                        .Cells[dgv부서.Columns.Count - 2].Value != null))
                    {
                        //dgv부서.Rows.Add();
                        dgv부서.CurrentCell = dgv부서[0, dgv부서.CurrentRow.Index + 1];
                    }
                    // 현재 행의 여섯번째 열에 데이터가 있으면 다음 행의 첫번째 열로 이동
                    else if (dgv부서.Rows[dgv부서.CurrentRow.Index].Cells[dgv부서.Columns.Count - 2].Value != null)
                    {
                        dgv부서.CurrentCell = dgv부서[0, dgv부서.CurrentRow.Index + 1];
                    }
                }
                // 엔터키 입력시 다음 셀로 이동
                else
                {
                    dgv부서.CurrentCell = dgv부서[dgv부서.CurrentCell.ColumnIndex + 1, dgv부서.CurrentRow.Index];
                }
            }

            if (e.KeyData == Keys.Delete)
            {
                e.SuppressKeyPress = true;

                if (DialogResult.Yes == MessageBox.Show("선택한 부서를 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo))
                    DB.부서.Delete(FillInDepartment(dgv부서.CurrentCell.RowIndex));

                dgv부서.DataSource = DB.부서.GetAll();
            }
        }

        /// <summary>
        /// 부서 데이터 담음
        /// </summary>
        /// <param name="i">인덱스 번호</param>
        /// <returns></returns>
        private ClassLibrary.부서등록 FillInDepartment(int i)
        {
            ClassLibrary.부서등록 부서 = new ClassLibrary.부서등록();

            부서.부서코드 = dgv부서.Rows[i].Cells[0].Value.ToString();
            부서.부서명 = dgv부서.Rows[i].Cells[1].Value.ToString();
            부서.사업장코드 = dgv부서.Rows[i].Cells[2].Value.ToString();
            부서.부문코드 = dgv부서.Rows[i].Cells[4].Value.ToString();
            부서.사용시작기간 = DateTime.Parse(dgv부서.Rows[i].Cells[6].Value.ToString());
            if (dgv부서.Rows[i].Cells[7].Value != null)
                부서.사용종료기간 = DateTime.Parse(dgv부서.Rows[i].Cells[7].Value.ToString());

            return 부서;
        }

        private void Dgv부서_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var list = DB.부서.GetAll();
            string startDay, endDay;

            if (e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    startDay = dgv부서.Rows[i].Cells[6].Value.ToString();

                    if (dgv부서.Rows[i].Cells[7].Value != null)
                    {
                        endDay = dgv부서.Rows[i].Cells[7].Value.ToString();

                        if (
                           list[i].부서코드 != dgv부서.Rows[i].Cells[0].Value.ToString() || list[i].부서명 != dgv부서.Rows[i].Cells[1].Value.ToString() 
                       || list[i].사업장코드 != dgv부서.Rows[i].Cells[2].Value.ToString() || list[i].부문코드 != dgv부서.Rows[i].Cells[4].Value.ToString() 
                       || list[i].사용시작기간.ToString() != DateTime.Parse(startDay)
                       .ToShortDateString() 
                       || list[i].사용종료기간.ToString() != DateTime.Parse(endDay).
                       ToShortDateString()
                            )
                        {
                            DB.부서.Update(FillInDepartment(i));
                        }
                    }
                    else
                    {
                        if (
                           list[i].부서코드 != dgv부서.Rows[i].Cells[0].Value.ToString() || list[i].부서명 != dgv부서.Rows[i].Cells[1].Value.ToString()
                       || list[i].사업장코드 != dgv부서.Rows[i].Cells[2].Value.ToString() || list[i].부문코드 != dgv부서.Rows[i].Cells[4].Value.ToString()
                       || list[i].사용시작기간.ToString() != DateTime.Parse(startDay)
                       .ToShortDateString()
                            )
                            DB.부서.Update(FillInDepartment(i));
                    }
                }

                for (int i = list.Count; i < dgv부서.RowCount - 1; i++)
                {
                    if (dgv부서.Rows[i].Cells[0].Value != null && dgv부서.Rows[i].Cells[1].Value != null && dgv부서.Rows[i].Cells[2].Value != null && dgv부서.Rows[i].Cells[4].Value != null&& dgv부서.Rows[i].Cells[6].Value != null)
                    {
                        ClassLibrary.부서등록 부서 = FillInDepartment(i);

                        DB.부서.Insert(부서);
                    }
                }
            }
        }

        private void Dgv부서_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("parsing error.");
            }
        }
    }
}
