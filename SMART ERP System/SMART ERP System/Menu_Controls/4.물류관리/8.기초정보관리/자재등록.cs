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
    public partial class 자재등록 : UserControl
    {
        public 자재등록()
        {
            InitializeComponent();
            SetData();
        }

        private void 자재등록_Load(object sender, EventArgs e)
        {
            string[] 검사여부 = { "1. 예", "2. 아니요" };
            cbb검사여부.Items.AddRange(검사여부);
            dgv자재.Rows.Add();

            DB.사원등록.SearchDepartment(loginMember.EmployeeCode, out string code1, out string name1);
            cbb부서코드.Text = code1;
            txb부서명.Text = name1;
        }
        private void Btn조회_Click(object sender, EventArgs e)
        {
            조회();
        }
        private void Btn등록_Click(object sender, EventArgs e)
        {
            if (DB.일반거래처.Get공급업체번호From이름(txb공급업체.Text).Count == 0)
            {
                MessageBox.Show($"{txb공급업체.Text}라는 공급업체가 등록되지 않았습니다");
                return;
            }

            자재 productInfo = new 자재();
            공급자재리스트 공급자재리스트 = new 공급자재리스트();

            productInfo.자재번호 = txb자재번호.Text;
            productInfo.자재명 = txb자재이름.Text;
            productInfo.품목군 = txb품목군.Text;
            if (cbb검사여부.Text == "1.예") productInfo.검사여부 = true;
            else productInfo.검사여부 = false;
            productInfo.리드타임 = int.Parse(txb리드타임.Text);
            productInfo.재고량 = int.Parse(txb재고량.Text);
            productInfo.안전재고량 = int.Parse(txb안전재고량.Text);

            productInfo.품목군 = txb품목군.Text;

            DB.자재.Insert(productInfo);
            MessageBox.Show("등록");

            공급자재리스트.자재번호 = txb자재번호.Text;
            공급자재리스트.공급업체번호 = DB.일반거래처.Get공급업체번호From이름(txb공급업체.Text).Select(x => x.거래처코드번호).First();

            DB.공급자재리스트.Insert(공급자재리스트);
        }
        private void Btn변경_Click(object sender, EventArgs e)
        {
            string 공급업체번호 = DB.일반거래처.Get공급업체번호From이름(txb공급업체.Text).Select(x => x.거래처코드번호).First();
            if (DB.공급자재리스트.Search공급자재리스트(공급업체번호, dgv자재.CurrentRow.Cells[0].Value.ToString()).Count == 0)
            {
                공급자재리스트 공급자재리스트 = new 공급자재리스트();
                공급자재리스트.자재번호 = txb자재번호.Text;
                공급자재리스트.공급업체번호 = DB.일반거래처.Get공급업체번호From이름(txb공급업체.Text).Select(x => x.거래처코드번호).First();

                DB.공급자재리스트.Update(공급자재리스트);
            }

            자재 productInfo = new 자재();

            productInfo.자재번호 = txb자재번호.Text;
            productInfo.자재명 = txb자재이름.Text;
            productInfo.품목군 = txb품목군.Text;
            if (cbb검사여부.Text == "1.예") productInfo.검사여부 = true;
            else productInfo.검사여부 = false;

            productInfo.리드타임 = int.Parse(txb리드타임.Text);
            productInfo.재고량 = int.Parse(txb재고량.Text);
            productInfo.안전재고량 = int.Parse(txb안전재고량.Text);

            productInfo.품목군 = txb품목군.Text;

            DB.자재.Update(productInfo);
            MessageBox.Show("변경");

            조회();
        }

        private void Btn삭제_Click(object sender, EventArgs e)
        {
            공급자재리스트 공급자재리스트 = DB.공급자재리스트.Search공급자재리스트(dgv자재.CurrentRow.Cells[0].Value.ToString(),
                dgv자재.CurrentRow.Cells[0].Value.ToString()).First();

            DB.공급자재리스트.Delete(공급자재리스트);

            자재 orderList =
                DB.자재.Get자재(dgv자재.CurrentRow.Cells[0].Value.ToString()).First();

            DB.자재.Delete(orderList);

            MessageBox.Show("삭제");

            조회();
        }
        private void Dgv자재_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv자재.CurrentRow.Cells[0].Value == null || dgv자재.CurrentRow.Cells[1].Value == null) return;

            string 자재번호 = dgv자재.CurrentRow.Cells[0].Value.ToString();
            txb자재번호.Text = 자재번호;
            txb자재이름.Text = dgv자재.CurrentRow.Cells[1].Value.ToString();
            txb품목군.Text = DB.자재.Search품목군(자재번호);
            txb안전재고량.Text = DB.자재.Search안전재고량(자재번호);
            txb재고량.Text = DB.자재.Search재고량(자재번호);
            txb리드타임.Text = DB.자재.Search리드타임(자재번호);
            if (DB.자재.Search검사여부(자재번호) == true)
                cbb검사여부.Text = "1. 예";
            else cbb검사여부.Text = "2. 아니요";
            txb공급업체.Text = DB.자재.Search공급업체(자재번호);
        }

        private void Dgv자재_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            int colum = dgv.CurrentCell.ColumnIndex;

            if (colum == 0)
            {
                if (dgv.CurrentRow.Cells[0].Value == null)
                {
                    MessageBox.Show("데이터를 입력하세요");
                    return;
                }

                if (DB.자재.Get자재(dgv.CurrentRow.Cells[0].Value.ToString()).Count != 0)
                {
                    MessageBox.Show("등록되어있는 자재번호입니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgv.CurrentCell = dgv.CurrentRow.Cells[0];
                    return;
                }
            }

            if (colum == 1)
            {
                if (dgv.CurrentRow.Cells[1].Value == null)
                {
                    MessageBox.Show("데이터를 입력하세요");
                    return;
                }
                string 자재번호 = dgv.CurrentRow.Cells[0].Value.ToString();

                if (DB.자재.Get자재(자재번호).Count != 0)
                {
                    txb자재번호.Text = 자재번호;
                    txb자재이름.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                    txb품목군.Text = DB.자재.Search품목군(자재번호);
                    txb안전재고량.Text = DB.자재.Search안전재고량(자재번호);
                    txb재고량.Text = DB.자재.Search재고량(자재번호);
                    txb리드타임.Text = DB.자재.Search리드타임(자재번호);
                    if (DB.자재.Search검사여부(자재번호) == true)
                        cbb검사여부.Text = "1. 예";
                    else cbb검사여부.Text = "2. 아니요";
                    txb공급업체.Text = DB.자재.Search공급업체(자재번호);
                    return;
                }

                else
                {

                    if (DB.자재.IsSearch자재명(dgv.CurrentRow.Cells[1].Value.ToString()))
                    {
                        MessageBox.Show("등록되어있는 자재이름입니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgv.CurrentCell = dgv.CurrentRow.Cells[1];
                        return;
                    }

                    txb품목군.Focus();
                    txb자재번호.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                    txb자재이름.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                    txb품목군.Text = null;
                    txb안전재고량.Text = null;
                    txb재고량.Text = null;
                    txb리드타임.Text = null;
                    cbb검사여부.Text = null;

                    txb공급업체.Text = null;
                }
            }
        }

        private void Dgv자재_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int nowColum = dgv.CurrentCell.ColumnIndex;
            int nowRow = dgv.CurrentCell.RowIndex;
            int maxRow = dgv.RowCount;
            int maxColum = dgv.ColumnCount;

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (nowColum == maxColum - 1)
                {
                    if (dgv.CurrentRow.Cells[1].Value == null)
                    {
                        MessageBox.Show("데이터를 입력하세요");
                        return;
                    }
                    if (dgv.Rows[maxRow - 1].Cells[0].Value != null || dgv.Rows[maxRow - 1].Cells[1].Value != null)
                        dgv.Rows.Add();

                    dgv.CurrentCell = dgv[0, nowRow + 1];
                }

                else
                {
                    if (dgv.CurrentRow.Cells[0].Value == null)
                    {
                        MessageBox.Show("데이터를 입력하세요");
                        return;
                    }

                    dgv.CurrentCell = dgv[nowColum + 1, nowRow];
                }
            }
        }

        public void 조회()
        {
            string 품목군 = txbSearch품목군.Text;
            string 공급업체이름 = txbSearch공급업체.Text;

            var list = DB.자재.Search자재(품목군, 공급업체이름);

            dgv자재.Rows.Clear();
            dgv자재.Rows.Add();

            for (int i = 0; i < list.Count; i++)
            {
                dgv자재.Rows[i].Cells[0].Value = list[i].자재번호;
                dgv자재.Rows[i].Cells[1].Value = list[i].자재명;
                if (i != list.Count - 1)
                    dgv자재.Rows.Add();
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
        private void SetData()
        {
            사원등록BindingSource.DataSource = DB.사원등록.GetAll().Select(x => x.사원코드);
            부서등록BindingSource.DataSource = DB.부서.GetAll().Select(x => x.부서코드);
        }
    }
}