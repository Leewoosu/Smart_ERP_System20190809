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

namespace SMART_ERP_System.MainForm_Control
{
    public partial class MenuControl : UserControl
    {
        public MenuControl()
        {
            InitializeComponent();
            계정과목BindingSource.DataSource = DB.계정과목.GetAll();
        }

        private void DgvList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void TxbSearch_TextChanged(object sender, EventArgs e)
        {
            List<계정과목> list = DB.계정과목.SearchCode(txbSearch.Text);

            if (list == null)
                계정과목BindingSource.DataSource = DB.계정과목.GetAll();

            계정과목BindingSource.DataSource = list;
        }
    }
}
