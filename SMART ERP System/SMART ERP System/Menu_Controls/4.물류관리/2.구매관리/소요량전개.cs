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
using SMART_ERP_System.Class;

namespace SMART_ERP_System.MenuUserControl
{
    public partial class 소요량전개 : UserControl
    {
        public 소요량전개()
        {
            InitializeComponent();
            SetData();
            
        }
        
        private void btn소요량전개_Click(object sender, EventArgs e)
        {
            dgv소요량전개.Rows.Clear();
            
            var 수주List = DB.수주.GetAll(txb제품이름.Text, FirstDate.Value, LastDate.Value);

            List<string> 제품번호 = 수주List.Select(x => x.제품번호).Distinct().ToList();
           
            List<자재명세서> Input자재명세서 = new List<자재명세서>();

            for (int i = 0; i < 제품번호.Count; i++)
                Input자재명세서.AddRange(DB.자재명세서.Get자재명세서(제품번호[i]));

            var Output자재명세서 = new List<자재명세서>();

            List<string> 자재번호 = new List<string>();
            List<int> 수량 = new List<int>();

            for (int i = 0; i < Input자재명세서.Count; i++)
                자재번호.Add(Input자재명세서[i].자재번호);

            자재번호 = 자재번호.Distinct().ToList();

            for (int i = 0; i < 자재번호.Count; i++)
                수량.Add(0);

            for (int i = 0; i < 제품번호.Count; i++)
                Output자재명세서.AddRange(DB.자재명세서.Get자재명세서(제품번호[i]));          

            for (int i = 0; i < Output자재명세서.Count; i++)
                Output자재명세서[i].수량 = 0;     

            for (int i = 0; i < 수주List.Count; i++)
            {
                for (int j = 0; j < Input자재명세서.Count; j++)
                {
                    if (Input자재명세서[j].제품번호 == 수주List[i].제품번호)
                    { 
                        Output자재명세서[j].수량 = 
                            Input자재명세서[j].수량 * 수주List[i].잔량;

                        for (int k = 0; k < 자재번호.Count; k++)
                        {
                            if(자재번호[k] == Output자재명세서[j].자재번호)
                                수량[k] += Output자재명세서[j].수량;
                        }
                    }       
                }
            }

            for (int i = 0; i < 자재번호.Count; i++)
            {
                if (i != Output자재명세서.Count)
                    dgv소요량전개.Rows.Add();
                dgv소요량전개.Rows[i].Cells[0].Value = 자재번호[i];
                dgv소요량전개.Rows[i].Cells[1].Value = DB.자재.Get자재이름(자재번호[i]);
                if(dgv소요량전개.Rows[i].Cells[1].Value.ToString() == "PIPE")
                    dgv소요량전개.Rows[i].Cells[2].Value = 수량[i]/6000;
    
                else
                    dgv소요량전개.Rows[i].Cells[2].Value = 수량[i];               
            }
        }

        private void Cbb부서코드_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbb부서코드.SelectedValue != null)
                txb부서명.Text = DB.부서.SearchChangedValue(cbb부서코드.SelectedValue.ToString());
        }

        private void Cbb사원코드_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbb사원코드.SelectedValue != null)
                txb사원명.Text = DB.사원등록.SearchChangedValue(cbb사원코드.SelectedValue.ToString());
        }

        private void 소요량전개_Load(object sender, EventArgs e)
        {
            DB.사원등록.SearchDepartment(loginMember.EmployeeCode, out string code1, out string name1);
            cbb부서코드.Text = code1;
            txb부서명.Text = name1;
        }
        private void SetData()
        {
            사원등록BindingSource.DataSource = DB.사원등록.GetAll().Select(x => x.사원코드);
            부서등록BindingSource.DataSource = DB.부서.GetAll().Select(x => x.부서코드);
        }
    }
}
