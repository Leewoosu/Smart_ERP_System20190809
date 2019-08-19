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
    public partial class 생산계획현황 : UserControl
    {
        public 생산계획현황()
        {
            InitializeComponent();
            제품BindingSource.DataSource = DB.제품.Get품목군();
        }
    }
}
