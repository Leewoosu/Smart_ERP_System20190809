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
    public partial class 발주현황 : UserControl
    {
        public 발주현황()
        {
            InitializeComponent();
        }

        private void Btn조회_Click(object sender, EventArgs e)
        {
            bds발주.DataSource = DB.발주서.Search발주서(txb거래처이름.Text, OrderFirstDate.Value,
                   OrderLastDate.Value, DeliveryFirstDate.Value, DeliveryLastDate.Value);

            dgv발주리스트.Rows.Clear();
        }

        private void Dgv발주_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv발주리스트.Rows.Clear();
            var list1 = DB.발주리스트.Search발주리스트(dgv발주.CurrentRow.Cells[0].Value.ToString());
            for (int i = 0; i < list1.Count; i++)
            {
                dgv발주리스트.Rows.Add();
                dgv발주리스트.Rows[i].Cells[0].Value = DB.자재.Get자재이름(list1[i].자재번호);
                dgv발주리스트.Rows[i].Cells[1].Value = list1[i].수량;              
            }

            int maxRow = dgv발주리스트.RowCount;
            if (DB.입고등록.Get입고등록번호(dgv발주.CurrentRow.Cells[0].Value.ToString()).Count == 0)
            {
                for (int i = 0; i < maxRow; i++)
                    dgv발주리스트.Rows[i].Cells[2].Value = "미입고";
                return;
            }

            //string 입고등록번호 =
            //        DB.입고등록.Get입고등록번호(dgv발주.CurrentRow.Cells[0].Value.ToString()).Select(x => x.입고등록번호).FirstOrDefault();

            //var list = DB.입고등록리스트.Search입고등록리스트(입고등록번호);

            //for (int i = 0; i < maxRow; i++)
            //{
            //    for (int j = 0; j < list.Count; j++)
            //    {
            //        if (dgv발주리스트.Rows[i].Cells[0].Value.ToString() == DB.자재.Get자재이름(list[j].자재번호))
            //        {  
            //            if (DB.발주리스트.Search발주리스트(dgv발주.CurrentRow.Cells[0].Value.ToString(),
            //                dgv발주리스트.Rows[i].Cells[0].Value.ToString()).Count != 0)
            //            {                           
            //                dgv발주리스트.Rows[i].Cells[2].Value =
            //                    int.Parse(DB.발주리스트.Search발주리스트(dgv발주.CurrentRow.Cells[0].Value.ToString(),
            //                    dgv발주리스트.Rows[i].Cells[0].Value.ToString()).Select(x => x.수량).FirstOrDefault().ToString()) -
            //                    ((int)list[j].양품수량 + (int)list[j].불량수량);
            //            }
            //        }
            //        else
            //            dgv발주리스트.Rows[i].Cells[2].Value = "미입고";
            //    }
            //}
            var 입고등록 = DB.입고등록.Get입고등록번호(dgv발주.CurrentRow.Cells[0].Value.ToString());// 발주번호로 입고등록들고오기
            var 입고등록리스트 = new List<입고등록리스트>();
            for (int i = 0; i < 입고등록.Count; i++)//입고등록번호를 통한 모든 입고등록리스트의 정보를 담아줌
                입고등록리스트.AddRange(DB.입고등록리스트.Search입고등록리스트(입고등록[i].입고등록번호));

            int total = 0;
            for (int i = 0; i < maxRow; i++)
            {
                total = 0;
                for (int j = 0; j < 입고등록리스트.Count; j++)
                {
                    //dgv리스트의 자재이름과 입고등록리스트의 자재번호를 통해 자재이름을 출력받은 것과 비교해서 일치하면
                    //
                    if (dgv발주리스트.Rows[i].Cells[0].Value.ToString() == DB.자재.Get자재이름(입고등록리스트[j].자재번호))
                    {
                        if (DB.발주리스트.Search발주리스트(dgv발주.CurrentRow.Cells[0].Value.ToString(),
                               dgv발주리스트.Rows[i].Cells[0].Value.ToString()).Count != 0)
                        {
                            //dgv발주리스트.Rows[i].Cells[2].Value =
                            //      int.Parse(DB.발주리스트.Search발주리스트(dgv발주.CurrentRow.Cells[0].Value.ToString(),
                            //      dgv발주리스트.Rows[i].Cells[0].Value.ToString()).Select(x => x.수량).FirstOrDefault().ToString()) -
                            total += ((int)입고등록리스트[j].양품수량 + (int)입고등록리스트[j].불량수량);
                        }
                    }
                }

                if (total == 0) dgv발주리스트.Rows[i].Cells[2].Value = "미입고";
                else
                {
                    dgv발주리스트.Rows[i].Cells[2].Value = int.Parse(DB.발주리스트.Search발주리스트(dgv발주.CurrentRow.Cells[0].Value.ToString(),
                               dgv발주리스트.Rows[i].Cells[0].Value.ToString()).Select(x => x.수량).FirstOrDefault().ToString()) - total;
                }
            }
        }
    }
}