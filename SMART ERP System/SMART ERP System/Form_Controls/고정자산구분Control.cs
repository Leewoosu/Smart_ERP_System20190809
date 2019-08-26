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
using ClassLibrary;
using SMART_ERP_System.Class;

namespace SMART_ERP_System.MainForm_Control
{
    public partial class 고정자산구분Control : UserControl
    {
        CodeHelperForm codeHelperForm;

        public 고정자산구분Control()
        {
            InitializeComponent();
            고정자산계정과목BindingSource.DataSource = DB.고정자산계정과목.GetAll();
        }

        private void TxbSearch_TextChanged(object sender, EventArgs e)
        {
            List<고정자산계정과목> list = DB.고정자산계정과목.SearchListByCode(txbSearch.Text);

            if (list != null)
            {
                고정자산계정과목BindingSource.DataSource = list;
            }
        }

        private void Dgv고정자산List_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string fixedAssetsCode = dgv고정자산List.CurrentRow.Cells[0].Value.ToString();
                string fixedAssetsName = dgv고정자산List.CurrentRow.Cells[1].Value.ToString();

                고정자산단위.FixedAssetsCode = fixedAssetsCode;
                고정자산단위.FixedAssetsName = fixedAssetsName;

                codeHelperForm.Close();
            }

            if (e.KeyData == Keys.Escape)
            {
                codeHelperForm.Close();
            }
        }

        public void RecieveLoginForm(CodeHelperForm menuForm)
        {
            this.codeHelperForm = menuForm;
        }

        private void Dgv고정자산List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string fixedAssetsCode = dgv고정자산List.CurrentRow.Cells[0].Value.ToString();
            string fixedAssetsName = dgv고정자산List.CurrentRow.Cells[1].Value.ToString();

            고정자산단위.FixedAssetsCode = fixedAssetsCode;
            고정자산단위.FixedAssetsName = fixedAssetsName;

            codeHelperForm.Close();
        }

        private void Dgv고정자산List_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv고정자산List.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv고정자산List.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
