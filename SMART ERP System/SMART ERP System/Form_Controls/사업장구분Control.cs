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

namespace SMART_ERP_System.MainForm_Control
{
    public partial class 사업장구분Control : UserControl
    {
        CodeHelperForm menuForm;

        public 사업장구분Control()
        {
            InitializeComponent();
            사업장등록BindingSource.DataSource = DB.사업장.GetAll();
        }

        public void RecieveLoginForm(CodeHelperForm menuForm)
        {
            this.menuForm = menuForm;
        }
        private void SelectWorkPlace()
        {
            if (dgv사업장.CurrentRow.Cells[0].Value != null && dgv사업장.CurrentRow.Cells[1].Value != null)
            {
                사업장단위.WorkPlaceCode = dgv사업장.CurrentRow.Cells[0].Value.ToString();
                사업장단위.WorkPlaceName = dgv사업장.CurrentRow.Cells[1].Value.ToString();

                menuForm.Close();
            }
        }

        private void Dgv사업장_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                SelectWorkPlace();
            }

            if (e.KeyData == Keys.Escape)
            {
                menuForm.Close();
            }
        }

        private void Dgv사업장_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectWorkPlace();
        }
    }
}
