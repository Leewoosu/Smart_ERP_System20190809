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
    public partial class 출고처리 : UserControl
    {
        public 출고처리()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            var List = DB.수주.조회(null, null, dtps.Value, dtpe.Value);

            int i = 0 ,ii = 0;

            foreach (var item in List)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[ii++].Value = item.수주번호.ToString();
                dataGridView1.Rows[i].Cells[ii++].Value = item.수주번호2.ToString();
                dataGridView1.Rows[i].Cells[ii++].Value = item.제품번호.ToString();
                dataGridView1.Rows[i].Cells[ii++].Value = item.주문수량.ToString();
                dataGridView1.Rows[i].Cells[ii++].Value = item.납품업체번호.ToString();
                dataGridView1.Rows[i].Cells[ii++].Value = item.주문일.ToShortDateString();
                dataGridView1.Rows[i++].Cells[ii++].Value = item.납기일.ToShortDateString();
                ii = 0;
            }
        }
    }
}
