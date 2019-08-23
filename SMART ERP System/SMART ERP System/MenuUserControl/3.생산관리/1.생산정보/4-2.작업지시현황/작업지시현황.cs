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
    public partial class 작업지시현황 : UserControl
    {
        public 작업지시현황()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn조회_Click(object sender, EventArgs e)
        {
            string 지시번호 = txb지시번호.Text;
            string 품번 = txb품번.Text;
            dataGridView1.DataSource = DB.작업지시현황.Search_작업지시현황(지시번호, 품번,
                DateTime.Parse(dtp작업지시일1.Value.ToLongDateString()), DateTime.Parse(dtp작업지시일2.Value.ToLongDateString()));
        }
    }
}
