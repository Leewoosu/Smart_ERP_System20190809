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
    public partial class 입고현황 : UserControl
    {
        public 입고현황()
        {
            InitializeComponent();
            SetData();
        }

        private void Btn조회_Click(object sender, EventArgs e)
        {
            dgv입고등록리스트.Rows.Clear();
            dgv발주입고.Rows.Clear();
            dgv예외입고.Rows.Clear();

            if (tab입고.SelectedTab == 발주입고)
            {
                var list = new List<입고등록리스트>();
                var list3 = new List<ClassLibrary.입고등록>();
                var list1 = DB.입고등록.Search입고등록(txb공급업체.Text, txb입고번호.Text,
                    DateTime.Parse(OrderStart.Value.ToShortDateString()), DateTime.Parse(OrderLast.Value.ToShortDateString()));

                for (int i = 0; i < list1.Count; i++)
                {
                    var list2 = DB.입고등록리스트.Search입고등록리스트(list1[i].입고등록번호);//자재번호, 입고등록번호가 있는 입고등록리스트전부를 저장
                    for (int j = 0; j < list2.Count; j++)
                    {
                        if (list2[j].양품수량 != 0) list.Add(list2[j]);
                        for (int k = 0; k < list.Count; k++)
                        {
                            if (list[k].입고등록번호 == list2[j].입고등록번호)
                            {
                                j++;
                                break;
                            }
                        } 
                    }
                }

                for (int i = 0; i < list.Count; i++)
                    list3.AddRange(DB.입고등록.Is입고등록(list[i].입고등록번호));

                if (list3.Count == 0) return;

                for (int i = 0; i < list3.Count; i++)
                {
                    if (i != list3.Count) dgv발주입고.Rows.Add();

                    dgv발주입고.Rows[i].Cells[0].Value = list3[i].입고등록번호;
                    dgv발주입고.Rows[i].Cells[1].Value = list3[i].발주번호;
                    dgv발주입고.Rows[i].Cells[2].Value = DB.일반거래처.Get공급업체이름From번호(list3[i].공급업체번호);
                    dgv발주입고.Rows[i].Cells[3].Value = list3[i].검사일자;
                }
            }

            if (tab입고.SelectedTab == 예외입고)
            {
                bds반품처리서.DataSource = DB.반품처리서.Search입고등록(txb공급업체.Text, txb입고번호.Text,
                    DateTime.Parse(OrderStart.Value.ToShortDateString()), DateTime.Parse(OrderLast.Value.ToShortDateString()));
                for (int i = 0; i < dgv예외입고.RowCount; i++)
                    dgv예외입고.Rows[i].Cells[1].Value = DB.일반거래처.Get공급업체이름From번호(dgv예외입고.Rows[i].Cells[1].Value.ToString());

            }
        }

        private void Dgv발주입고_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var list = DB.입고등록리스트.Search입고등록리스트(dgv발주입고.CurrentRow.Cells[0].Value.ToString());
            dgv입고등록리스트.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].양품수량 == 0) break;
                if(i != list.Count)dgv입고등록리스트.Rows.Add();
                dgv입고등록리스트.Rows[i].Cells[0].Value = DB.자재.Get자재이름(list[i].자재번호);
                dgv입고등록리스트.Rows[i].Cells[1].Value = list[i].양품수량;
            }
        }

        private void Dgv예외입고_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var list = DB.반품처리리스트.Search반품처리리스트(dgv예외입고.CurrentRow.Cells[0].Value.ToString());

            dgv입고등록리스트.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != list.Count) dgv입고등록리스트.Rows.Add();
                dgv입고등록리스트.Rows.Add();
                dgv입고등록리스트.Rows[i].Cells[0].Value = DB.자재.Get자재이름(list[i].자재번호);
                dgv입고등록리스트.Rows[i].Cells[1].Value = list[i].수량;
            }
        }

        private void Tab입고_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab입고.SelectedTab == 예외입고) dgv입고등록리스트.Rows.Clear();
            if (tab입고.SelectedTab == 발주입고) dgv입고등록리스트.Rows.Clear();
        }

        private void 입고현황_Load(object sender, EventArgs e)
        {
            DB.사원등록.SearchDepartment(loginMember.EmployeeCode, out string code1, out string name1);
            cbb부서코드.Text = code1;
            txb부서명.Text = name1;
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
        private void SetData()
        {
            사원등록BindingSource.DataSource = DB.사원등록.GetAll().Select(x => x.사원코드);
            부서등록BindingSource.DataSource = DB.부서.GetAll().Select(x => x.부서코드);
        }
    }
}
