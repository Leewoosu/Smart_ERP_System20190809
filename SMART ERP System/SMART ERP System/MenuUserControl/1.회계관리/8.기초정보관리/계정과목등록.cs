using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.FormHelper;

namespace SMART_ERP_System.MenuUserControl
{
    public partial class 계정과목등록 : UserControl
    {       
        public 계정과목등록()
        {
            InitializeComponent();

            List<ClassLibrary.계정과목등록> MenuItems;
            treeView.SetMenuItemsByAccount(out MenuItems);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
