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
using ClassLibrary.FormHelper;
using ClassLibrary;
using SMART_ERP_System.Class;
using SMART_ERP_System.MainForm_Control;

namespace SMART_ERP_System.MenuUserControl
{
    public partial class 전표출력 : UserControl
    {
        계정합계Control 계정합계Control;
        List<전표리스트> 전표리스트s;

        public 전표출력()
        {
            InitializeComponent();
            SetData();
        }

        public void Recieve계정합계Control(계정합계Control 계정합계Control)
        {
            this.계정합계Control = 계정합계Control;
        }

        private void SetData()
        {
            회사등록BindingSource.DataSource = DB.회사.GetAll().Select(x=>x.회사코드);
            사원등록BindingSource.DataSource = DB.사원등록.GetAll().Select(x => x.사원코드);
            부서등록BindingSource.DataSource = DB.부서.GetAll().Select(x => x.부서코드);
            cbb전표구분.DataSource = MenuLists.separations;
            cbb전표유형.DataSource = MenuLists.types;
            cbb전표상태.DataSource = MenuLists.status;
        }

        private void Cbb부서코드_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbb부서코드.SelectedValue != null)
                txb부서명.Text = DB.부서.SearchChangedValue(cbb부서코드.SelectedValue.ToString());
        }

        private void Cbb사원코드_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbb사원코드.SelectedValue != null)
                txb사원명.Text = DB.사원등록.SearchChangedValue(cbb사원코드.SelectedValue.ToString());
        }

        private void 전표출력_Load(object sender, EventArgs e)
        {
            txb회사명.Text = DB.회사.Search(cbb회사코드.Text);

            DB.부서.Search(loginMember.EmployeeCode, out string code1, out string name1);
            cbb부서코드.Text = code1;
            txb부서명.Text = name1;

            DB.사원등록.Search(loginMember.EmployeeCode, out string code2, out string name2);
            cbb사원코드.Text = code2;
            txb사원명.Text = name2;
        }

        private void Dgv전표리스트_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            for (int i = 0; i < dgv전표리스트.RowCount - 1; i++)
            {
                dgv전표리스트.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void StartSearch()
        {
            cbb전표유형.Enabled = true;
            cbb전표상태.Enabled = true;
            cbb전표구분.Enabled = true;
            string comparer = "전체";

            if (cbb전표구분.Text == comparer && cbb전표상태.Text == comparer && cbb전표유형.Text == comparer)
            {
                전표리스트s = DB.전표리스트.SearchPeriod(dtpFrom.Value, dtpTo.Value);
                전표리스트BindingSource.DataSource = 전표리스트s;
            }
        }

        private void Cbb전표상태_SelectedValueChanged(object sender, EventArgs e)
        {
            전표리스트s = DB.전표리스트.SearchPeriod(dtpFrom.Value, dtpTo.Value);
            string comparer = "전체";

            if (cbb전표상태.SelectedValue != null)
                ChangeSearchingTerms(전표리스트s, comparer);
        }

        private void Cbb전표구분_SelectedValueChanged(object sender, EventArgs e)
        {
            전표리스트s = DB.전표리스트.SearchPeriod(dtpFrom.Value, dtpTo.Value);
            string comparer = "전체";

            if (cbb전표구분.SelectedValue != null)
                ChangeSearchingTerms(전표리스트s, comparer);
        }

        private void Cbb전표유형_SelectedValueChanged(object sender, EventArgs e)
        {
            전표리스트s = DB.전표리스트.SearchPeriod(dtpFrom.Value, dtpTo.Value);
            string comparer = "전체";

            if (cbb전표유형.SelectedValue != null)
                ChangeSearchingTerms(전표리스트s, comparer);
        }

        private void ChangeSearchingTerms(List<전표리스트> 전표리스트s, string comparer)
        {
            if ((cbb전표상태.Text == comparer)
                 && (cbb전표구분.Text == comparer)
                 && (cbb전표유형.Text == comparer))
            {
                전표리스트BindingSource.DataSource = 전표리스트s;
            }
            else
            {
                전표리스트BindingSource.DataSource
                    = 전표리스트s.Where(x =>
               x.전표상태 == cbb전표상태.Text &&
               x.구분 == cbb전표구분.Text &&
               x.전표유형 == cbb전표유형.Text
                    ).ToList();
            }

            if ((cbb전표상태.Text == comparer)
            && (cbb전표구분.Text == comparer)
            && (cbb전표유형.Text != comparer))
            {
                전표리스트BindingSource.DataSource
                = 전표리스트s.Where(x => x.전표유형 == cbb전표유형.Text
                ).ToList();
            }

            if ((cbb전표상태.Text == comparer)
            && (cbb전표구분.Text != comparer)
            && (cbb전표유형.Text == comparer))
            {
                전표리스트BindingSource.DataSource
                = 전표리스트s.Where(x => x.구분 == cbb전표구분.Text
                ).ToList();
            }

            if ((cbb전표상태.Text != comparer)
            && (cbb전표구분.Text == comparer)
            && (cbb전표유형.Text == comparer))
            {
                전표리스트BindingSource.DataSource
                = 전표리스트s.Where(x => x.전표상태 == cbb전표상태.Text
                ).ToList();
            }

            if ((cbb전표상태.Text != comparer)
            && (cbb전표구분.Text != comparer)
            && (cbb전표유형.Text == comparer))
            {
                전표리스트BindingSource.DataSource
                   = 전표리스트s.Where(x => x.전표상태 == cbb전표상태.Text
                   && x.구분 == cbb전표구분.Text
                   ).ToList();
            }

            if ((cbb전표상태.Text != comparer)
            && (cbb전표구분.Text == comparer)
            && (cbb전표유형.Text != comparer))
            {
                전표리스트BindingSource.DataSource
                   = 전표리스트s.Where(x => x.전표상태 == cbb전표상태.Text
                   && x.전표유형 == cbb전표유형.Text
                   ).ToList();
            }

            if ((cbb전표상태.Text == comparer)
            && (cbb전표구분.Text != comparer)
            && (cbb전표유형.Text != comparer))
            {
                전표리스트BindingSource.DataSource
                   = 전표리스트s.Where(x => x.전표상태 == cbb전표상태.Text
                   && x.전표유형 == cbb전표유형.Text
                   ).ToList();
            }
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            전표리스트s = DB.전표리스트.SearchPeriod(dtpFrom.Value, dtpTo.Value);

            계정합계Control = new 계정합계Control();
            계정합계Control.SendList(전표리스트s);

            CodeHelperForm form = new CodeHelperForm(계정합계Control);

            form.Text = "계정별합계";
            form.Size = new Size(630, 440);
            form.Resizable = false;
            form.SetFormLocation();
            form.ShowDialog();
        }

        private void DtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFrom.Value != null)
                전표리스트s = DB.전표리스트.SearchPeriod(dtpFrom.Value, dtpTo.Value);
        }

        private void DtpTo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTo.Value != null)
                전표리스트s = DB.전표리스트.SearchPeriod(dtpFrom.Value, dtpTo.Value);
        }

        private void DtpTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                StartSearch();
            }
        }

        private void DtpFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Cbb부서코드_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
            {
                e.SuppressKeyPress = true;
                if ((sender is ComboBox))
                    ((ComboBox)sender).DroppedDown = true;
            }

            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
