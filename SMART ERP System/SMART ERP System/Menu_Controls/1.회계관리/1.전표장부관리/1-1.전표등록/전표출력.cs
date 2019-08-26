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
        string comparer = "전체";

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
            MenuLists.Set();

            사업장등록BindingSource.DataSource = DB.사업장.GetAll();
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
            txb사업장명.Text = DB.사업장.Search(cbb사업장코드.Text);

            DB.사원등록.SearchDepartment(loginMember.EmployeeCode, out string code1, out string name1);
            cbb부서코드.Text = code1;
            txb부서명.Text = name1;

            DB.사원등록.Search(loginMember.EmployeeCode, out string code2, out string name2);
            cbb사원코드.Text = code2;
            txb사원명.Text = name2;
        }

        private void Dgv전표리스트_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            for (int i = 0; i < dgv전표리스트.Columns.Count; i++)
            {
                dgv전표리스트.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgv전표리스트.Columns[9].DefaultCellStyle.Format = "##,##";
            dgv전표리스트.Columns[10].DefaultCellStyle.Format = "##,##";
        }

        private void StartSearch()
        {
            전표리스트s = DB.전표리스트.SearchPeriod(dtpFrom.Value, dtpTo.Value);
            전표리스트BindingSource.DataSource = 전표리스트s;
        }

        private void Cbb전표상태_SelectedValueChanged(object sender, EventArgs e)
        {
            var list = 전표리스트s;
            if (cbb전표구분.SelectedValue.ToString() != comparer)
                ChangeSearchingTerms(list, comparer);
        }

        private void Cbb전표구분_SelectedValueChanged(object sender, EventArgs e)
        {
            var list = 전표리스트s;
            if (cbb전표구분.SelectedValue.ToString() != comparer)
                ChangeSearchingTerms(list, comparer);
        }

        private void Cbb전표유형_SelectedValueChanged(object sender, EventArgs e)
        {
            var list = 전표리스트s;
            if (cbb전표구분.SelectedValue.ToString() != comparer)
                ChangeSearchingTerms(list, comparer);
        }

        private void ChangeSearchingTerms(List<전표리스트> 전표리스트s, string comparer)
        {
            var list = 전표리스트s;

            //if ((cbb전표상태.Text == comparer)
            // && (cbb전표구분.Text == comparer)
            // && (cbb전표유형.Text == comparer))
            //{
            //    전표리스트BindingSource.DataSource = list;
            //}
            //else
            //{
            //    전표리스트BindingSource.DataSource
            //        = list.Where(x =>
            //   x.전표상태 == cbb전표상태.Text &&
            //   x.구분 == cbb전표구분.Text &&
            //   x.전표유형 == cbb전표유형.Text
            //        ).ToList();
            //}

            if ((cbb전표상태.Text == comparer)
            && (cbb전표구분.Text == comparer)
            && (cbb전표유형.Text != comparer))
            {
                전표리스트BindingSource.DataSource
                = list.Where(x => x.전표유형 == cbb전표유형.Text
                ).ToList();
                return;
            }

            if ((cbb전표상태.Text == comparer)
            && (cbb전표구분.Text != comparer)
            && (cbb전표유형.Text == comparer))
            {
                전표리스트BindingSource.DataSource
                = list.Where(x => x.구분 == cbb전표구분.Text
                ).ToList();
                return;
            }

            if ((cbb전표상태.Text != comparer)
            && (cbb전표구분.Text == comparer)
            && (cbb전표유형.Text == comparer))
            {
                전표리스트BindingSource.DataSource
                = list.Where(x => x.전표상태 == cbb전표상태.Text
                ).ToList();
                return;
            }

            if ((cbb전표상태.Text != comparer)
            && (cbb전표구분.Text != comparer)
            && (cbb전표유형.Text == comparer))
            {
                전표리스트BindingSource.DataSource
                   = list.Where(x => x.전표상태 == cbb전표상태.Text
                   && x.구분 == cbb전표구분.Text
                   ).ToList();
                return;
            }

            if ((cbb전표상태.Text != comparer)
            && (cbb전표구분.Text == comparer)
            && (cbb전표유형.Text != comparer))
            {
                전표리스트BindingSource.DataSource
                   = list.Where(x => x.전표상태 == cbb전표상태.Text
                   && x.전표유형 == cbb전표유형.Text
                   ).ToList();
                return;
            }

            if ((cbb전표상태.Text == comparer)
            && (cbb전표구분.Text != comparer)
            && (cbb전표유형.Text != comparer))
            {
                전표리스트BindingSource.DataSource
                   = list.Where(x => x.전표상태 == cbb전표상태.Text
                   && x.전표유형 == cbb전표유형.Text
                   ).ToList();
                return;
            }
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            List<전표리스트> list = new List<전표리스트>();

            bool isChecked;  

            for (int i = 0; i < dgv전표리스트.RowCount; i++)
            {
                isChecked = Convert.ToBoolean(dgv전표리스트.Rows[i].Cells[0].Value);

                if (isChecked == true)
                   // list.Add((전표리스트)dgv전표리스트.Rows[i].DataBoundItem);
                    list.Add(전표리스트s[i]);
            }

            if (전표리스트s == null)
                return;

            if (list.Count == 0)
                list = 전표리스트s;

            계정합계Control = new 계정합계Control();
            계정합계Control.SendList(list);
            계정합계Control.Recieve전표출력(this);

            CodeHelperForm form = new CodeHelperForm(계정합계Control);
            form.ShowDialog();
        }

        private void DtpTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                dgv전표리스트.Rows.Clear();

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

        private void Dgv전표리스트_Scroll(object sender, ScrollEventArgs e)
        {
            Rectangle rtHeader = dgv전표리스트.DisplayRectangle;
            rtHeader.Height = dgv전표리스트.ColumnHeadersHeight / 2;
            dgv전표리스트.Invalidate(rtHeader);
        }

        // Dgv전표리스트 첫번째 컬럼 헤드 체크박스 넣기
        private void Dgv전표리스트_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex == -1)
            {
                e.PaintBackground(e.ClipBounds, false);

                Point point = e.CellBounds.Location;

                int nCbxWidth = 15;
                int nCbxHeight = 15;
                int offSetX = (e.CellBounds.Width - nCbxWidth) / 2;
                int offSetY = (e.CellBounds.Height - nCbxHeight) / 2;

                point.X += offSetX;
                point.Y += offSetY;

                CheckBox cbx = new CheckBox();
                cbx.Size = new Size(nCbxWidth, nCbxHeight);
                cbx.Location = point;
                cbx.CheckedChanged += new EventHandler(Dgv전표리스트_CheckedChanged);

                ((DataGridView)sender).Controls.Add(cbx);

                e.Handled = true;
            }
        }

        // Dgv전표리스트 첫번째 컬럼 체크박스 체크변동 함수
        private void Dgv전표리스트_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv전표리스트.Rows)
            {
                row.Cells["CheckColumn"].Value = ((CheckBox)sender).Checked;
            }
        }

        private void Dgv전표리스트_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                return;
                //MessageBox.Show("error.");
            }
        }
    }
}
