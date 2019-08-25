using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMART_ERP_System.MainForm_Control;
using SMART_ERP_System.Class;
using ClassLibrary.EntityData;
using ClassLibrary.Class;
using ClassLibrary;

namespace SMART_ERP_System.MenuUserControl
{
    public partial class 사업장등록 : UserControl
    {
        관할세무서구분Control 관할세무서구분Control;

        public 사업장등록()
        {
            InitializeComponent();
            사업장등록BindingSource.DataSource = DB.사업장.GetAll();
        }

        private void BtnCodeHelper_Click(object sender, EventArgs e)
        {
            관할세무서구분Control = new 관할세무서구분Control();

            CodeHelperForm menuForm = new CodeHelperForm(관할세무서구분Control);
            menuForm.ShowDialog();

            txb관할세무서코드.Text = 관할세무서단위.CompetentTaxOfficeCode;
            txb관할세무서명.Text = 관할세무서단위.CompetentTaxOfficeName;
        }

        private void Txb관할세무서코드_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                관할세무서구분Control = new 관할세무서구분Control();

                CodeHelperForm menuForm = new CodeHelperForm(관할세무서구분Control);
                menuForm.ShowDialog();

                txb관할세무서코드.Text = 관할세무서단위.CompetentTaxOfficeCode;
                txb관할세무서명.Text = 관할세무서단위.CompetentTaxOfficeName;
            }
        }

        private void Dgv사업장_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string code = null;

            if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
            {
                if (dgv사업장.CurrentRow.Cells[0].Value != null || dgv사업장.CurrentRow.Cells[1].Value != null)
                {
                    code = dgv사업장.CurrentRow.Cells[0].Value.ToString();

                    ClassLibrary.사업장등록 사업장 = DB.사업장.GetDetails(code);

                    if (사업장 == null)
                        return;

                    FillData(사업장);
                }
                else
                {
                    foreach (Control control in gbx세부항목.Controls)
                    {
                        if ((typeof(TextBox) == control.GetType()))
                        {
                            control.Text = null;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 사업장 데이터를 담음
        /// </summary>
        /// <param name="i">인덱스 번호</param>
        /// <returns></returns>
        private ClassLibrary.사업장등록 FillWorkPlace(int i)
        {
            ClassLibrary.사업장등록 사업장 = new ClassLibrary.사업장등록();

            사업장.사업장코드 = dgv사업장.Rows[i].Cells[0].Value.ToString();
            사업장.사업장명 = dgv사업장.Rows[i].Cells[1].Value.ToString();
            사업장.사업장등록번호 = txb사업자등록번호.Text;
            사업장.대표자명 = txb대표자명.Text;
            사업장.사업장주소 = txb사업장주소.Text;
            사업장.사업장번지 = txb사업장번지.Text;
            사업장.사업장전화번호 = txb전화번호앞.Text + txb전화번호뒤.Text;
            사업장.업태 = txb업태.Text;
            사업장.종목 = txb종목.Text;
            사업장.관할세무서 = txb관할세무서명.Text;
            사업장.개업년월일 = dtp개업일.Value;
            사업장.폐업년월일 = dtp페업일.Value;

            return 사업장;
        }

        /// <summary>
        /// 사업장에 대한 데이터 채움
        /// </summary>
        /// <param name="사업장">해당 사업장</param>
        private void FillData(ClassLibrary.사업장등록 사업장)
        {
            txb사업자등록번호.Text = 사업장.사업장등록번호;
            txb대표자명.Text = 사업장.대표자명;
            txb사업장주소.Text = 사업장.사업장주소;
            txb사업장번지.Text = 사업장.사업장번지;
            txb전화번호앞.Text = 사업장.사업장전화번호.Substring(0, 3);
            txb전화번호뒤.Text = 사업장.사업장전화번호.Substring(3, 9);
            txb업태.Text = 사업장.업태;
            txb종목.Text = 사업장.종목;
            txb관할세무서명.Text = 사업장.관할세무서;
            txb관할세무서코드.Text = DB.사업장.SearchCode(txb관할세무서명.Text);
            dtp개업일.Value = 사업장.개업년월일;

            if (사업장.폐업년월일 != null)
                dtp페업일.Value = (DateTime)사업장.폐업년월일;
        }

        private void TabControl1_Leave(object sender, EventArgs e)
        {
            string code = dgv사업장.CurrentRow.Cells[0].Value.ToString();
            ClassLibrary.사업장등록 사업장추가 = DB.사업장.GetDetails(code);

            if (사업장추가 == null)
            {
                if (
                    dgv사업장.CurrentRow.Cells[0].Value != null &&
                    dgv사업장.CurrentRow.Cells[1].Value != null &&
                    !txb사업자등록번호.Text.IsNullOrEmpty() &&
                    !txb대표자명.Text.IsNullOrEmpty() &&
                    !txb사업장주소.Text.IsNullOrEmpty() &&
                    !txb사업장번지.Text.IsNullOrEmpty() &&
                    !txb전화번호앞.Text.IsNullOrEmpty() &&
                    !txb전화번호뒤.Text.IsNullOrEmpty() &&
                    !txb업태.Text.IsNullOrEmpty() &&
                    !txb종목.Text.IsNullOrEmpty() &&
                    !txb관할세무서명.Text.IsNullOrEmpty()
                   )
                {
                    사업장추가 = FillWorkPlace(dgv사업장.CurrentCell.RowIndex);
                    DB.사업장.Insert(사업장추가);
                }
            }
            else
            {
                var list = DB.사업장.GetAll();
                ClassLibrary.사업장등록 comparer = FillWorkPlace(dgv사업장.CurrentCell.RowIndex);
                int index = dgv사업장.CurrentCell.RowIndex;

                if (
                     list[index].사업장코드 != comparer.사업장코드 ||
                     list[index].사업장명 != comparer.사업장명 ||
                     list[index].사업장등록번호 != comparer.사업장등록번호 ||
                     list[index].대표자명 != comparer.대표자명 ||
                     list[index].사업장주소 != comparer.사업장주소 ||
                     list[index].사업장번지 != comparer.사업장번지 ||
                     list[index].사업장전화번호 != comparer.사업장전화번호 ||
                     list[index].업태 != comparer.업태 ||
                     list[index].종목 != comparer.종목 ||
                     list[index].관할세무서 != comparer.관할세무서 ||
                     list[index].개업년월일 != comparer.개업년월일 ||
                     list[index].폐업년월일 != comparer.폐업년월일
                   )
                {
                    DB.사업장.Update(comparer);
                }
            }
        }

        private void Dgv사업장_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                e.SuppressKeyPress = true;

                if (DialogResult.Yes == MessageBox.Show("선택한 사업장을 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo))
                    DB.사업장.Delete(FillWorkPlace(dgv사업장.CurrentCell.RowIndex));

               사업장등록BindingSource.DataSource = DB.사업장.GetAll();
            }
        }
    }
}