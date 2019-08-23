using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using ClassLibrary.EntityData;

namespace SMART_ERP_System.MenuUserControl
{
    public partial class 매출마감 : UserControl
    {
        public 매출마감()
        {
            InitializeComponent();
        }

        private void 매출마감_Load(object sender, EventArgs e)
        {
            var Delete자재전표 = DB.자재전표.GetAll();
            var Delete자재상세전표 = DB.자재상세전표.GetAll();

            for (int i = 0; i < Delete자재상세전표.Count; i++)
                DB.자재상세전표.Delete(Delete자재상세전표[i]);
            for (int i = 0; i < Delete자재전표.Count; i++)
                DB.자재전표.Delete(Delete자재전표[i]);

            var list = new List<입고등록>();
            var list1 = DB.입고등록리스트.GetAll();

            자재전표 자재전표 = new 자재전표();
            자재상세전표 자재상세전표 = new 자재상세전표();
            for (int i = 0; i < list1.Count; i++)
            {
                if(list1[i].양품수량 > 0)
                {
                    if(DB.자재전표.Search자재전표(DB.입고등록.Is입고등록(list1[i].입고등록번호).Select(x => x.입고등록번호).FirstOrDefault()).Count == 0)
                    {
                        자재전표.자재전표번호 = (DB.자재전표.GetCount() + 1).ToString();
                        자재전표.거래처번호 = DB.입고등록.Is입고등록(list1[i].입고등록번호).Select(x => x.공급업체번호).FirstOrDefault();
                        자재전표.입고등록번호 = list1[i].입고등록번호;
                        
                        자재상세전표.자재번호 = list1[i].자재번호;
                        자재상세전표.자재전표번호 = 자재전표.자재전표번호;
                        자재상세전표.금액 = DB.자재.Get자재(list1[i].자재번호).Select(x => x.구매단가).FirstOrDefault() * (int)list1[i].양품수량;

                        자재전표.총금액 = 자재상세전표.금액;

                        DB.자재전표.Insert(자재전표);
                        DB.자재상세전표.Insert(자재상세전표);       
                    }
                    else
                    {
                        자재상세전표.자재번호 = list1[i].자재번호;
                        자재상세전표.자재전표번호 = DB.자재전표.Search자재전표(list1[i].입고등록번호).Select(x => x.자재전표번호).FirstOrDefault();
                        자재상세전표.금액 = DB.자재.Get자재(list1[i].자재번호).Select(x => x.구매단가).FirstOrDefault() * (int)list1[i].양품수량;

                        var Updata자재전표 = DB.자재전표.Search자재전표(list1[i].입고등록번호).FirstOrDefault();
                        Updata자재전표.총금액 += 자재상세전표.금액;

                        DB.자재전표.Update(Updata자재전표);
                        DB.자재상세전표.Insert(자재상세전표);
                    }
                }
            }
        }

        private void Btn조회_Click(object sender, EventArgs e)
        {
            bds자재전표.DataSource = DB.자재전표.자재전표조회(txb거래처.Text);
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bds자재상세전표.DataSource = DB.자재상세전표.Search자재상세전표(dgv자재전표.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
