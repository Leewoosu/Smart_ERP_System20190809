using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SMART_ERP_System.Class;
using ClassLibrary.EntityData;
using ClassLibrary;

namespace SMART_ERP_System.MainForm_Control
{
    public partial class 금융거래처구분Control : UserControl
    {
        CodeHelperForm menuForm;

        public 금융거래처구분Control()
        {
            InitializeComponent();
            금융거래처등록BindingSource.DataSource = DB.금융거래처.GetAll();
        }

        public void RecieveLoginForm(CodeHelperForm menuForm)
        {
            this.menuForm = menuForm;
        }

        [DllImport("User32.dll")]
        public static extern void keybd_event(uint vk, uint scan, uint flags, uint extraInfo);
        private void Dgv거래처List_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string customerCode = dgv거래처List.CurrentRow.Cells[0].Value.ToString();
                string customerName = dgv거래처List.CurrentRow.Cells[1].Value.ToString();
                string accontNumber = dgv거래처List.CurrentRow.Cells[2].Value.ToString();
                string corporateRegistrationNumber = dgv거래처List.CurrentRow.Cells[3].Value.ToString();

                전표리스트단위.FinanceCustomerCode = customerCode;
                전표리스트단위.FinanceCustomerName = customerName;
                전표리스트단위.FinanceAccontNumber = accontNumber;
                전표리스트단위.FinanceCorporateRegistrationNumber = corporateRegistrationNumber;

                menuForm.Close();
                keybd_event((byte)Keys.Enter, 0x0D, 0x01, 0); // DownUp
            }
        }

        private void TxbSearch_TextChanged(object sender, EventArgs e)
        {
            List<금융거래처등록> list = DB.금융거래처.SearchCustomerCode(txbSearch.Text);

            if (list != null)
            {
                금융거래처등록BindingSource.DataSource = list;
            }
        }

        private void Dgv거래처List_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv거래처List.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv거래처List.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv거래처List.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv거래처List.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Dgv거래처List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string customerCode = dgv거래처List.CurrentRow.Cells[0].Value.ToString();
            string customerName = dgv거래처List.CurrentRow.Cells[1].Value.ToString();
            string accontNumber = dgv거래처List.CurrentRow.Cells[2].Value.ToString();
            string corporateRegistrationNumber = dgv거래처List.CurrentRow.Cells[3].Value.ToString();

            전표리스트단위.FinanceCustomerCode = customerCode;
            전표리스트단위.FinanceCustomerName = customerName;
            전표리스트단위.FinanceAccontNumber = accontNumber;
            전표리스트단위.FinanceCorporateRegistrationNumber = corporateRegistrationNumber;

            menuForm.Close();
            keybd_event((byte)Keys.Enter, 0x0D, 0x01, 0); // DownUp
        }
    }
}
