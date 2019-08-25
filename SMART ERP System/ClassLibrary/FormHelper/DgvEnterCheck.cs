using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class DgvEnterCheck : DataGridView
    {
        int itemCnt = 0;

        public void DataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int xPoint = dgv.CurrentCell.RowIndex;
            int yPoint = dgv.CurrentCell.ColumnIndex;
            int ColCnt = dgv.ColumnCount - 1;
            int RowCnt = dgv.RowCount - 1;


            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (yPoint < ColCnt)
                {
                    dgv.CurrentCell = dgv[yPoint + 1, xPoint];
                }
                else if (xPoint < RowCnt)
                {
                    dgv.CurrentCell = dgv[1, xPoint + 1];
                }
                else if (xPoint == RowCnt && dgv.Rows[xPoint].Cells[1].Value != null && xPoint == itemCnt - 1)
                {
                    dgv.Rows.Add();
                    dgv.CurrentCell = dgv[1, xPoint + 1];
                }
            }
        }
    }
}
