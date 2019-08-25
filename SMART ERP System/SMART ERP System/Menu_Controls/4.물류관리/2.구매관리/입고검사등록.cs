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
    public partial class 입고검사등록 : UserControl
    {
        public 입고검사등록()
        {
            InitializeComponent();
        }

        public void Load입고검사Data()
        {
            bds입고검사.DataSource = DB.입고검사.GetAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Load입고검사Data();
        }

        private void 입고검사등록_Load(object sender, EventArgs e)
        {
            dgv입고검사.CurrentRow.Cells[0].ReadOnly = true;
        }

        private void dgv입고검사_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int maxColumn = dgv입고검사.ColumnCount - 1;
            int nowColumn = dgv입고검사.CurrentCell.ColumnIndex - 1;

            if (maxColumn == nowColumn)
            {
                //DB.발주확인서.Register발주확인서(dgv입고검사.CurrentRow.Cells[1].ToString(), dgv입고검사.CurrentRow.Cells[2].ToString());
                //DB.발주확인리스트.Register발주확인리스트(dgv입고검사.CurrentRow.Cells[1].ToString(), dgv입고검사.CurrentRow.Cells[2].ToString(), int.Parse(dgv입고검사.CurrentRow.Cells[3].ToString()));
                DB.입고검사.Register입고검사(dgv입고검사.CurrentRow.DataBoundItem);
            }
            
        }
    }
}
