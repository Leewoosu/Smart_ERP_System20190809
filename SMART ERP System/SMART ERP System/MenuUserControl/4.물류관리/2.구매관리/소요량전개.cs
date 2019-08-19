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

namespace SMART_ERP_System.MenuUserControl
{
    public partial class 소요량전개 : UserControl
    {
        public 소요량전개()
        {
            InitializeComponent();          
        }
        
        public void MaterialCalculate()
        {           
           // DB.소요량전개.Register소요량();
            //bds소요량전개.DataSource = DB.소요량전개.GetAll();
        }

       

        private void btn소요량전개_Click(object sender, EventArgs e)
        {
            MaterialCalculate();
        }
    }
}
