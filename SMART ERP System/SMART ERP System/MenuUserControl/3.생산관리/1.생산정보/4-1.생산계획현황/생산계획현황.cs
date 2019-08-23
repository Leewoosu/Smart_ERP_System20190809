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
    public partial class 생산계획현황 : UserControl
    {
        public 생산계획현황()
        {
            InitializeComponent();
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            string 품번 = txb품번.Text;
            string 품목군 = cbb품목군.Text;

            if (radioButton1.Checked)
            {
                dataGridView1.DataSource = DB.제품.Search_작업예정일(품번, 품목군, DateTime.Parse(dtp작업일1.Value.ToLongDateString()), DateTime.Parse(dtp작업일2.Value.ToLongDateString()));
            }
            else
            {
                dataGridView1.DataSource = DB.제품.Search_작업마감일(품번, 품목군, DateTime.Parse(dtp작업일1.Value.ToLongDateString()), DateTime.Parse(dtp작업일2.Value.ToLongDateString()));
            }

        }


        //  List<ClassLibrary.생산계획현황> list = DB.생산계획.Search(txb품번.Text);
        //  생산계획현황BindingSource.DataSource = list;


        private void tbx품목군_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // 품목군 List가 중복이 안되게 해줌
        private void 품목군초기화()
        {
            //List<string> list 
            제품BindingSource.DataSource = DB.제품.GetAll().Select(x => x.품목군).Distinct();
        }

        private void 생산계획현황_Load(object sender, EventArgs e)
        {
            품목군초기화();
        }
    }


}