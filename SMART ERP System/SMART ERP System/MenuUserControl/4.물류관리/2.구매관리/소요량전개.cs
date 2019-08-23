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
    public partial class 소요량전개 : UserControl
    {
        public 소요량전개()
        {
            InitializeComponent();
        }

        private void btn소요량전개_Click(object sender, EventArgs e)
        {
            dgv소요량전개.Rows.Clear();
            dgv소요량전개.Rows.Add();

            var 수주List = DB.수주.GetAll(txb제품이름.Text, FirstDate.Value, LastDate.Value);

            List<string> 제품번호 = 수주List.Select(x => x.제품번호).Distinct().ToList();
           
            List<자재명세서> Input자재명세서 = new List<자재명세서>();

            for (int i = 0; i < 제품번호.Count; i++)
                Input자재명세서.AddRange(DB.자재명세서.Get자재명세서(제품번호[i]));

            var Output자재명세서 = new List<자재명세서>();

            List<string> 자재이름 = new List<string>();
            List<int> 수량 = new List<int>();

            for (int i = 0; i < Input자재명세서.Count; i++)
                자재이름.Add(Input자재명세서[i].자재번호);


            자재이름 = 자재이름.Distinct().ToList();

            for (int i = 0; i < 자재이름.Count; i++)
                수량.Add(0);


            for (int i = 0; i < 제품번호.Count; i++)
                Output자재명세서.AddRange(DB.자재명세서.Get자재명세서(제품번호[i]));          

            for (int i = 0; i < Output자재명세서.Count; i++)
                Output자재명세서[i].수량 = 0;     

            for (int i = 0; i < Input자재명세서.Count; i++)
            {
                for (int j = 0; j < 수주List.Count; j++)
                {
                    if (Input자재명세서[i].제품번호 == 수주List[j].제품번호)
                    { 
                        Output자재명세서[i].수량 = 
                            Input자재명세서[i].수량 * 수주List[j].주문수량;

                        for (int k = 0; k < 자재이름.Count; k++)
                        {
                            if(자재이름[k] == Output자재명세서[i].자재번호)
                                수량[k] += Output자재명세서[i].수량;
                        }
                    }       
                }
            }

            for (int i = 0; i < 자재이름.Count; i++)
            {
                dgv소요량전개.Rows[i].Cells[0].Value = DB.자재.Get자재이름(자재이름[i]);
                dgv소요량전개.Rows[i].Cells[1].Value = 수량[i];
                if (i != Output자재명세서.Count)
                    dgv소요량전개.Rows.Add();
            }
        }
    }
}
