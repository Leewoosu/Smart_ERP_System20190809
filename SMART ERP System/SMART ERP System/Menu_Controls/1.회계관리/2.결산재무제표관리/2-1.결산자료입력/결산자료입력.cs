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

namespace SMART_ERP_System.MenuUserControl
{
    public partial class 결산자료입력 : UserControl
    {
        public 결산자료입력()
        {
            InitializeComponent();
        }

        private void 결산자료입력_Load(object sender, EventArgs e)
        {
            결산자료입력bds.DataSource = DB.결산자료.GetAll();
        }

        private void Dtp종료일_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

            }
        }
    }
}