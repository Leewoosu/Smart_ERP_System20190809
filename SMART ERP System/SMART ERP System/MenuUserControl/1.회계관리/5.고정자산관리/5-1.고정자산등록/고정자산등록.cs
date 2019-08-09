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
    public partial class 고정자산등록 : UserControl
    {
        public 고정자산등록()
        {
            InitializeComponent();
            Load_DepreciationMethod();
        }

        public void Load_DepreciationMethod()
        {
            cbbDepreciationMethod.SelectedIndex = -1;
        }
    }
}
