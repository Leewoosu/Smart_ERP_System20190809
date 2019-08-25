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
using System.Runtime.InteropServices;

namespace SMART_ERP_System.MainForm_Control
{
    public partial class 계정코드구분Control : UserControl
    {
        CodeHelperForm codeHelperForm;

        public 계정코드구분Control()
        {
            InitializeComponent();
            계정과목BindingSource.DataSource = DB.계정과목.GetAll();
        }

        private void TxbSearch_TextChanged(object sender, EventArgs e)
        {
            List<계정과목> list = DB.계정과목.SearchListByCode(txbSearch.Text);

            if (list != null)
            {
                계정과목BindingSource.DataSource = list;
            }
        }

        [DllImport("User32.dll")]
        public static extern void keybd_event(uint vk, uint scan, uint flags, uint extraInfo);
        private void DgvList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string accountCode = dgv계정과목List.CurrentRow.Cells[0].Value.ToString();
                string accountName = dgv계정과목List.CurrentRow.Cells[1].Value.ToString();

                전표리스트단위.AccountCode = accountCode;
                전표리스트단위.AccountName = accountName;

                계정과목단위.AccountCode = accountCode;
                계정과목단위.AccountName = accountName;

                codeHelperForm.Close();
                keybd_event((byte)Keys.Enter, 0x0D, 0x01, 0); // DownUp
            }

            if(e.KeyData == Keys.Escape)
            {
                codeHelperForm.Close();
            }
        }

        public void RecieveLoginForm(CodeHelperForm menuForm)
        {
            this.codeHelperForm = menuForm;
        }

        private void Dgv계정과목List_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv계정과목List.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv계정과목List.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Dgv계정과목List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string accountCode = dgv계정과목List.CurrentRow.Cells[0].Value.ToString();
            string accountName = dgv계정과목List.CurrentRow.Cells[1].Value.ToString();

            전표리스트단위.AccountCode = accountCode;
            전표리스트단위.AccountName = accountName;

            계정과목단위.AccountCode = accountCode;
            계정과목단위.AccountName = accountName;

            codeHelperForm.Close();
            keybd_event((byte)Keys.Enter, 0x0D, 0x01, 0); // DownUp
        }
    }
}
