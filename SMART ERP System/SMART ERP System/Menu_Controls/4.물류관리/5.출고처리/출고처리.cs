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
        List<제품> 제품Info = DB.제품.GetAll();
        int TotPrice = 0;
        int TotCnt = 0;

        public 출고처리()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            if (rbtn처리.Checked)
            {
                datafind(true);
            }
            else
            {
                datafind(false);
            }
            txbMaterialCnt.Text = dataGridView1.RowCount.ToString();
            txbTotalCnt.Text = TotCnt.ToString();
            txbTotalPrice.Text = DoubleToString(TotPrice.ToString());
            TotPrice = 0;
            TotCnt = 0;
        }

        private void datafind(bool check)
        {
            dataGridView1.Rows.Clear();

            var List = DB.수주.납기조회(품번1.Text, null, DateTime.Parse(dtps.Value.ToShortDateString()), DateTime.Parse(dtpe.Value.ToShortDateString()));

            int i = 0, ii = 0;
            //dataGridView1.Rows[i].Cells[ii++].Value = item.주문일.ToShortDateString();
            foreach (var item in List)
            {
                if (item.출고여부 == check)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[ii++].Value = item.납품업체번호.ToString();
                    dataGridView1.Rows[i].Cells[ii++].Value = item.수주번호.ToString();
                    dataGridView1.Rows[i].Cells[ii++].Value = item.수주번호2.ToString();
                    dataGridView1.Rows[i].Cells[ii++].Value = item.제품번호.ToString();
                    dataGridView1.Rows[i].Cells[ii++].Value = item.주문수량.ToString();
                    dataGridView1.Rows[i].Cells[ii++].Value = item.주문일.ToShortDateString();
                    dataGridView1.Rows[i].Cells[ii++].Value = item.납기일.ToShortDateString();
                    dataGridView1.Rows[i].Cells[ii++].Value = item.잔량.ToString();
                    dataGridView1.Rows[i].Cells[ii++].Value = item.잔량.ToString();
                    dataGridView1.Rows[i].Cells[ii++].Value = item.단가.ToString();
                    dataGridView1.Rows[i].Cells[ii++].Value = item.금액.ToString();
                    if (check == false)
                    {
                        TotCnt += item.잔량;
                        TotPrice += item.단가 * item.잔량;
                    }
                    else
                    {
                        TotCnt += item.주문수량;
                        TotPrice += item.단가 * item.주문수량;
                    }


                    if (item.주문수량 != item.잔량)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.PaleGreen;
                    }
                    dataGridView1.Rows[i++].Cells[ii++].Value = item.출고여부;
                    ii = 0;

                }
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count ; i++)
            {
                dataGridView1.Rows[i].Cells[11].Value = true;
            }
        }


        private void update(object sender, EventArgs e)
        {
            int MaxRow = dataGridView1.RowCount;
            if (MaxRow == 0)
            {
                MessageBox.Show("처리할 자료가 없습니다.");
                return;
            }

            for (int i = 0; i < MaxRow; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[11].Value == true)
                {

                    int ii = 1;
                    string Num1, Num2;
                    Num1 = dataGridView1.Rows[i].Cells[ii++].Value.ToString();
                    Num2 = dataGridView1.Rows[i].Cells[ii].Value.ToString();
                    List<수주> 수주list = new List<수주>();
                    List<제품> 제품list = new List<제품>();
                    수주list = DB.수주.Get수주(Num1, Num2);
                    제품list = DB.제품.Get제품(수주list[0].제품번호.ToString());
                    int price = 0;
                    int 금액 = 0;
                    int chulQty = 0;
                    int orderQty = 0;
                    int janQty = 0;
                    orderQty = 수주list[0].주문수량;
                    chulQty = int.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                    janQty = int.Parse(수주list[0].잔량.ToString());
                    price = int.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString());
                    
                    if ((chulQty + 수주list[0].출고량.Value) > orderQty)
                    {
                        MessageBox.Show("OverFlow => Order Qty!! ");
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
                        continue;
                    }
                    if (제품list[0].재고량 < chulQty)
                    {
                        MessageBox.Show("OverFlow => 재고 Qty!! ");
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                        continue;
                    }


                    제품list[0].재고량 -= chulQty;
                    DB.제품.Update(제품list[0]);
                    수주list[0].출고량 = chulQty;
                    수주list[0].잔량 = janQty - chulQty;
                    수주list[0].단가 = price;
                    금액 = price * (orderQty - 수주list[0].잔량);
                    수주list[0].단가 = price;
                    수주list[0].금액 = 금액;

                    if (수주list[0].잔량 == 0)
                        수주list[0].출고여부 = true;
                    else
                        수주list[0].출고여부 = false;

                    DB.수주.Update(수주list[0]);

                }
            }

            //Button5_Click(null, null);

        }




        private void RollBack(object sender, EventArgs e)
        {
            int MaxRow = dataGridView1.RowCount;
            if (MaxRow == 0)
            {
                MessageBox.Show("처리할 자료가 없습니다.");
                return;
            }

            for (int i = 0; i < MaxRow; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[11].Value == true)
                {
                    int ii = 1; 
                    string Num1, Num2;
                    List<수주> 수주list = new List<수주>();
                    List<제품> 제품list = new List<제품>();

                    Num1 = dataGridView1.Rows[i].Cells[ii++].Value.ToString();
                    Num2 = dataGridView1.Rows[i].Cells[ii].Value.ToString();

                    수주list = DB.수주.Get수주(Num1,Num2);
                    제품list = DB.제품.Get제품(수주list[0].제품번호.ToString());
                    수주list[0].잔량 = 수주list[0].주문수량;
                    수주list[0].출고량 = 0;
                    수주list[0].금액 = 수주list[0].단가 * 수주list[0].주문수량;
                    수주list[0].출고여부 = false;
                    제품list[0].재고량 += 수주list[0].주문수량;
                    DB.제품.Update(제품list[0]);
                    DB.수주.Update(수주list[0]);
                }
               
            }
            Button5_Click(null, null);
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[11].Value = false;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "출고처리")
                update(null, null);
            else
                RollBack(null, null);

            제품Info = DB.제품.GetAll();
        }


        public static string DoubleToString(string szData)
        {
            string szReturn = string.Empty;
            if (szData != "")
            {
                string szValue = szData.Replace(",", "");
                Double data = Double.Parse(szValue);
                szReturn = string.Format("{0:###,###,###,###,###,###}", data);
            }
            return szReturn;
        }

       

        private void Rbtn조회_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rbtn = (RadioButton)sender;
            if (rbtn.Name == "rbtn처리" && button3.Text != "출고취소")
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns[7].HeaderText = "출고량";
                button3.Text = "출고취소";
            }
            else if (rbtn.Name == "rbtn조회" && button3.Text != "출고처리")
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns[7].HeaderText = "출고가능수량";
                button3.Text = "출고처리";

            }
            else if (rbtn.Name == "rbtn조회")
            {
                button3.Text = "출고처리";
            }
            else
            {
                button3.Text = "출고취소";
            }
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int xPoint = dataGridView1.CurrentCell.RowIndex;
            int yPoint = dataGridView1.CurrentCell.ColumnIndex;
            if (dataGridView1.Rows[xPoint].Cells[3].Value == null)
                return;
                
            string material = dataGridView1.Rows[xPoint].Cells[3].Value.ToString();

            var info = 제품Info.Where(x => x.제품번호 == material).ToList();
            txbMaterialName.Text = info[0].제품명.ToString();
            txbMaterial.Text = info[0].품목군.ToString();
            txbMaterialQty.Text = info[0].재고량.ToString();
        }
    }
}
