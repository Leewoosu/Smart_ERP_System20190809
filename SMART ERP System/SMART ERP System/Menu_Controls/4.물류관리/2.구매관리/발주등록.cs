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
    public partial class 발주등록 : UserControl
    {
        public static int BehindSujuListCnt;
        public 발주등록()
        {
            InitializeComponent();
            SetData();
        }

        private void Btn조회_Click(object sender, EventArgs e)
        {
            Load발주서Date();
        }

        private void Dgv발주서_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv발주서.CurrentRow.Cells[0].Value == null) return;
            Load발주서리스트Date();
        }

        private void 발주등록_Load(object sender, EventArgs e)
        {
            dgv발주서.Rows.Add();
            dgv발주서.CurrentRow.Cells[0].ReadOnly = true;
            DB.사원등록.SearchDepartment(loginMember.EmployeeCode, out string code1, out string name1);
            cbb부서코드.Text = code1;
            txb부서명.Text = name1;
        }

        private void Dgv발주서_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            dgv.CurrentRow.Cells[0].ReadOnly = true;
            dgv.CurrentRow.Cells[2].ReadOnly = true;
            int maxRow = dgv.RowCount;
            int maxColum = dgv.ColumnCount;

            if (e.ColumnIndex == 1)
            {
                dgv[0, e.RowIndex].Value = (DB.발주서.GetCount() + 2).ToString();
                dgv[2, e.RowIndex].Value = DateTime.Today.ToShortDateString();
                if (DB.일반거래처.Get공급업체번호From이름(dgv[1, e.RowIndex].Value.ToString()).Count == 0)
                {
                    MessageBox.Show("등록되지않은 공급업체입니다.");
                    return;
                }
            }

            if (e.ColumnIndex == 3)
            {
                if (dgv[e.ColumnIndex, e.RowIndex].Value != null)
                {
                    발주서 발주서 = new 발주서();
                    발주서.발주번호 = dgv[0, e.RowIndex].Value.ToString();
                    발주서.공급업체번호 = DB.일반거래처.Get공급업체번호From이름(dgv[1, e.RowIndex].Value.ToString()).Select(x => x.거래처코드번호).First().ToString();
                    발주서.주문날짜 = DateTime.Today;
                    발주서.납기일 = DateTime.Parse(dgv.CurrentRow.Cells[3].Value.ToString());//해결하기

                    DB.발주서.Insert(발주서);
                    MessageBox.Show("발주서등록");
                    dgv발주리스트.Rows.Add();
                    dgv발주리스트.Focus();
                    dgv발주리스트.CurrentCell = dgv발주리스트[0, 0];
                }
            }
        }

        private void Dgv발주서_KeyDown(object sender, KeyEventArgs e)
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
                    if (dgv.CurrentCell != null)
                    {
                        dgv.Rows.Add();
                        dgv.CurrentCell = dgv[0, nowRow + 1];
                    }
                }
                else
                    dgv.CurrentCell = dgv[nowColum + 1, nowRow];
            }

            if (e.KeyCode == Keys.Delete && dgv.CurrentRow.Cells[0].Value != null)
            {
                e.SuppressKeyPress = true;
                var list = DB.발주서.Is발주번호(dgv[0, nowRow].Value.ToString()).First();
                var list1 = DB.발주리스트.Search발주리스트(dgv[0, nowRow].Value.ToString());

                for (int i = 0; i < list1.Count; i++)
                    DB.발주리스트.Delete(list1[i]);

                dgv발주리스트.Rows.Clear();
                DB.발주서.Delete(list);
                Load발주서Date();
            }
        }
        private void Dgv발주리스트_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            int maxRow = dgv.RowCount;
            int maxColum = dgv.ColumnCount;

            if (e.ColumnIndex == 0)
            {
                if ((DB.자재.Get자재번호(dgv[0, e.RowIndex].Value.ToString()).Count == 0))
                {
                    MessageBox.Show("등록되지 않은 자재입니다");
                    return;
                }
            }

            if (e.ColumnIndex == 1)
            {
                if (dgv[e.ColumnIndex, e.RowIndex].Value != null)
                {
                    string 자재번호 = DB.자재.Get자재번호(dgv.CurrentRow.Cells[0].Value.ToString()).Select(x => x.자재번호).First().ToString();
                    var list
                        = DB.발주리스트.Search발주리스트(자재번호, dgv발주서.CurrentRow.Cells[0].Value.ToString());

                    if (list.Count == 0)
                    {
                        발주리스트 발주리스트 = new 발주리스트();
                        발주리스트.발주번호 = dgv발주서.CurrentRow.Cells[0].Value.ToString();
                        발주리스트.자재번호 = DB.자재.Get자재번호(dgv[0, e.RowIndex].Value.ToString()).Select(x => x.자재번호).First().ToString();
                        발주리스트.수량 = int.Parse(dgv[1, e.RowIndex].Value.ToString());

                        DB.발주리스트.Insert(발주리스트);
                        MessageBox.Show("발주리스트");
                    }
                            
                    else
                    {
                        if (list.First().수량 != int.Parse(dgv.CurrentRow.Cells[1].Value.ToString()))
                        {
                            list.First().수량 = int.Parse(dgv.CurrentRow.Cells[1].Value.ToString());
                            DB.발주리스트.Update(list.First());
                            MessageBox.Show("수량변경");
                        }
                    }

                }
            }
        }
        private void Dgv발주리스트_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int nowColum = dgv.CurrentCell.ColumnIndex;
            int nowRow = dgv.CurrentCell.RowIndex;
            int maxRow = dgv.RowCount;
            int maxColum = dgv.ColumnCount;
            int 발주서nowRow = dgv발주서.CurrentCell.RowIndex;

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (nowColum == maxColum - 1)
                {
                    if (dgv.CurrentCell != null)
                    {
                        dgv.Rows.Add();
                        dgv.CurrentCell = dgv[0, nowRow + 1];
                    }
                }
                else
                    dgv.CurrentCell = dgv[nowColum + 1, nowRow];
            }

            if (e.KeyCode == Keys.Delete && dgv.CurrentRow.Cells[0].Value != null)
            {
                e.SuppressKeyPress = true;
                var list1 = DB.발주리스트.Search발주리스트(dgv발주서[0, 발주서nowRow].Value.ToString());
                for (int i = 0; i < list1.Count; i++)
                {
                    DB.발주리스트.Delete(list1[i]);
                }
                dgv발주리스트.Rows.Clear();

                Load발주서리스트Date();
            }
        }

        public void Load발주서Date()
        {
            var list = DB.발주서.Search발주서(txb거래처이름.Text, OrderFirstDate.Value,
                   OrderLastDate.Value, DeliveryFirstDate.Value, DeliveryLastDate.Value);
            dgv발주리스트.Rows.Clear();
            dgv발주서.Rows.Clear();
            dgv발주서.Rows.Add();
            for (int i = 0; i < list.Count; i++)
            {
                dgv발주서.Rows[i].Cells[0].Value = list[i].발주번호;
                dgv발주서.Rows[i].Cells[1].Value = DB.일반거래처.Get공급업체이름From번호(list[i].공급업체번호);
                dgv발주서.Rows[i].Cells[2].Value = list[i].주문날짜.ToShortDateString();
                dgv발주서.Rows[i].Cells[3].Value = list[i].납기일.ToShortDateString();
                if (i != list.Count-1)
                    dgv발주서.Rows.Add();
            }
        }

        public void Load발주서리스트Date()
        {
            var list = DB.발주리스트.Search발주리스트(dgv발주서.CurrentRow.Cells[0].Value.ToString());
            dgv발주리스트.Rows.Clear();
            dgv발주리스트.Rows.Add();
            for (int i = 0; i < list.Count; i++)
            {
                dgv발주리스트.Rows[i].Cells[0].Value = DB.자재.Get자재이름(list[i].자재번호);
                dgv발주리스트.Rows[i].Cells[1].Value = list[i].수량;

                if (i != list.Count-1)
                    dgv발주리스트.Rows.Add();
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