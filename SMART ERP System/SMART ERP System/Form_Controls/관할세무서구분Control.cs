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
    public partial class 관할세무서구분Control : UserControl
    {
        CodeHelperForm menuForm;

        public 관할세무서구분Control()
        {
            InitializeComponent();
            관할세무서BindingSource.DataSource = DB.관할세무서.GetAll();
        }

        public void RecieveLoginForm(CodeHelperForm menuForm)
        {
            this.menuForm = menuForm;
        }

        private void SelectCompetentTaxOffice()
        {
            if (dgv관할세무서.CurrentRow.Cells[0].Value != null && dgv관할세무서.CurrentRow.Cells[1].Value != null)
            {
                관할세무서단위.CompetentTaxOfficeCode = dgv관할세무서.CurrentRow.Cells[0].Value.ToString();
                관할세무서단위.CompetentTaxOfficeName = dgv관할세무서.CurrentRow.Cells[1].Value.ToString();

                menuForm.Close();
            }
        }

        private void Dgv관할세무서_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                SelectCompetentTaxOffice();
            }

            if (e.KeyData == Keys.Escape)
            {
                menuForm.Close();
            }
        }

        private void Dgv관할세무서_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectCompetentTaxOffice();
        }
    }
}
