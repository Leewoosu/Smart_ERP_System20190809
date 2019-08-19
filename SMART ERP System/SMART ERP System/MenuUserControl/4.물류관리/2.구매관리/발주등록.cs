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
    public partial class 발주등록 : UserControl
    {
        public static int BehindSujuListCnt;
        public 발주등록()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            dgv발주서.DataSource = DB.발주서.GetAll();
        }

        private void Dgv발주서_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv발주리스트.DataSource = DB.발주리스트.Search발주리스트(dgv발주서.CurrentRow.Cells[0].Value.ToString());
        }

        public void Register발주등록()
        {
            List<수주> 수주List = DB.수주.GetAll();
            List<제품> 제품List = DB.제품.GetAll();
            List<자재명세서> 자재명세List = DB.자재명세서.GetAll();
            List<자재> 자재List = DB.자재.GetAll();

            자재 자재 = new 자재();

            int i = 1;
            for (int j = BehindSujuListCnt; j < 수주List.Count; j++)
            {
                for (int k = 0; k < 제품List.Count; k++)
                {
                    if (수주List[j].제품번호 == 제품List[k].제품번호)
                    {
                        수주List[j].주문수량 =
                            (int)(수주List[j].주문수량 - 제품List[k].재고량);

                        if ((제품List[k].재고량 -= 수주List[j].주문수량) < 0) 제품List[k].재고량 = 0;

                        if (수주List[j].주문수량 > 0)
                        {
                            for (int m = 0; m < 자재명세List.Count; m++)
                            {
                                if (자재명세List[m].제품번호 == 수주List[j].제품번호)
                                {
                                    자재명세List[m].수량 *= 수주List[j].주문수량;

                                    for (int n = 0; n < 자재List.Count; n++)
                                    {
                                        if (자재명세List[m].자재번호 == 자재List[n].자재번호)
                                        {
                                            자재List[n].재고량 -= 자재명세List[m].수량;

                                            if (자재List[n].재고량 < 0)
                                            {
                                                발주리스트 orderDetailList = new 발주리스트();
                                                발주서 order = new 발주서();

                                                order.발주번호 = i++.ToString();
                                                orderDetailList.발주번호 = order.발주번호;
                                                orderDetailList.자재번호 = 자재List[n].자재번호;
                                                orderDetailList.수량 = 자재List[n].재고량 * (-1);
                                                자재List[n].재고량 = 0;
                                                
                                                //발주서에 자재에 따른 공급업체 및 날짜 넣기
                                                DB.자재.Update(자재List[n]);
                                                DB.발주서.Insert(order);
                                                DB.발주리스트.Insert(orderDetailList);
                                            }

                                            DB.자재.Update(자재List[n]);
                                        }
                                    }
                                    자재명세List[m].수량 /= 수주List[j].주문수량;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void 발주등록_Load(object sender, EventArgs e)
        {
            //Register발주등록();
        }
    }
}
