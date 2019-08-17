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
    public partial class 일반거래처등록 : UserControl
    {
        public 일반거래처등록()
        {
            InitializeComponent();
            일반거래처등록BindingSource.DataSource = DB.일반거래처.GetAll();
        }
    }
}
