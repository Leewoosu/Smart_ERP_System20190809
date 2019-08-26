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
    public partial class 품목등록 : UserControl
    {
        public 품목등록()
        {
            InitializeComponent();
            string[] 검사여부 = { "1. 예", "2. 아니요" };
            cbbSearch검사여부.Items.AddRange(검사여부);
            cbb검사여부.Items.AddRange(검사여부);
            SetData();
        }       

        private void dgv제품_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int colum = dgv제품.CurrentCell.ColumnIndex;       

            if (colum == 0)
            {
                if (dgv제품.CurrentRow.Cells[0].Value == null)
                {
                    MessageBox.Show("데이터를 입력하세요");
                    return;
                }

                if (DB.제품.IsSearch제품번호(dgv제품.CurrentRow.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("등록되어있는 제품번호입니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgv제품.CurrentCell = dgv제품.CurrentRow.Cells[0];
                    return;
                }
            }

            string 제품번호 = dgv제품.CurrentRow.Cells[0].Value.ToString();

            if (colum == 1)
            {
                if (dgv제품.CurrentRow.Cells[1].Value == null)
                {
                    MessageBox.Show("데이터를 입력하세요");
                    return;
                }

                if (DB.제품.Get제품(제품번호, dgv제품.CurrentRow.Cells[1].Value.ToString()).Count != 0)
                {
                    txb제품번호.Text = 제품번호;
                    txb제품명.Text = dgv제품.CurrentRow.Cells[1].Value.ToString();
                    txbLOT수량.Text = DB.제품.SearchLOT수량(제품번호);
                    if (DB.제품.Search검사여부(제품번호) == true)
                        cbb검사여부.Text = "1. 예";
                    else cbb검사여부.Text = "2. 아니요";
                    txb리드타임.Text = DB.제품.Search리드타임(제품번호);
                    txb실제원가.Text = DB.제품.Search실제원가(제품번호);
                    txb안전재고량.Text = DB.제품.Search안전재고량(제품번호);
                    txb외경.Text = DB.제품.Search외경(제품번호);
                    txb일별생산량.Text = DB.제품.Search일별생산량(제품번호);

                    txb층.Text = DB.제품.Search층(제품번호);
                    txb표준원가.Text = DB.제품.Search표준원가(제품번호);
                    txb품목군.Text = DB.제품.Search품목군(제품번호);
                    return;
                }

                else
                {                  

                    if (DB.제품.IsSearch제품명(dgv제품.CurrentRow.Cells[1].Value.ToString()))
                    {
                        MessageBox.Show("등록되어있는 제품이름입니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgv제품.CurrentCell = dgv제품.CurrentRow.Cells[1];
                        return;
                    }

                    txb품목군.Focus();
                    txb제품번호.Text = dgv제품.CurrentRow.Cells[0].Value.ToString();
                    txb제품명.Text = dgv제품.CurrentRow.Cells[1].Value.ToString();
                    txbLOT수량.Text = null;
                    cbb검사여부.Text = null;
                    txb리드타임.Text = null;
                    txb실제원가.Text = null;
                    txb안전재고량.Text = null;
                    txb외경.Text = null;
                    txb일별생산량.Text = null;
                    
                    txb층.Text = null;
                    txb표준원가.Text = null;
                    txb품목군.Text = null;
                                      
                }
            }
        }

        private void dgv제품_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv제품.CurrentRow.Cells[0].Value == null || dgv제품.CurrentRow.Cells[1].Value == null) return;


            string 제품번호 = dgv제품.CurrentRow.Cells[0].Value.ToString();
            //제품정보불러오기
            txb제품번호.Text = 제품번호.ToString();
            txb제품명.Text = dgv제품.CurrentRow.Cells[1].Value.ToString();
            txbLOT수량.Text = DB.제품.SearchLOT수량(제품번호);
            if (DB.제품.Search검사여부(제품번호) == true)
                cbb검사여부.Text = "1. 예";
            else cbb검사여부.Text = "2. 아니요";
            
            txb리드타임.Text = DB.제품.Search리드타임(제품번호);
            txb실제원가.Text = DB.제품.Search실제원가(제품번호);
            txb안전재고량.Text = DB.제품.Search안전재고량(제품번호);
            txb외경.Text = DB.제품.Search외경(제품번호);
            txb일별생산량.Text = DB.제품.Search일별생산량(제품번호);

            txb층.Text = DB.제품.Search층(제품번호);
            txb표준원가.Text = DB.제품.Search표준원가(제품번호);
            txb품목군.Text = DB.제품.Search품목군(제품번호);
        }

        private void btn등록_Click(object sender, EventArgs e)
        {
            제품 productInfo = new 제품();

            productInfo.제품번호 = txb제품번호.Text;
            productInfo.제품명 = txb제품명.Text;
            productInfo.LOT수량 = int.Parse(txbLOT수량.Text);

            if (cbb검사여부.Text == "1. 예")
                productInfo.검사여부 = true;
            else productInfo.검사여부 = false;
            productInfo.리드타임 = int.Parse(txb리드타임.Text);
            productInfo.실제원가 = int.Parse(txb실제원가.Text);
            productInfo.안전재고량 = int.Parse(txb안전재고량.Text);
            productInfo.외경 = int.Parse(txb외경.Text);
            productInfo.일별생산량 = int.Parse(txb일별생산량.Text);

            productInfo.층 = int.Parse(txb층.Text);
            productInfo.표준원가 = int.Parse(txb표준원가.Text);
            productInfo.품목군 = txb품목군.Text;

            DB.제품.Insert(productInfo);
            MessageBox.Show("등록");

        }

        private void btn삭제_Click(object sender, EventArgs e)
        {
            제품 orderList = 
                DB.제품.Get제품(dgv제품.CurrentRow.Cells[0].Value.ToString(), dgv제품.CurrentRow.Cells[1].Value.ToString()).First();            

            DB.제품.Delete(orderList);
            MessageBox.Show("삭제");

            조회();
        }

        private void btn변경_Click(object sender, EventArgs e)
        {
            제품 productInfo = new 제품();

            productInfo.제품번호 = txb제품번호.Text;
            productInfo.제품명 = txb제품명.Text;
            productInfo.LOT수량 = int.Parse(txbLOT수량.Text);
            if (cbb검사여부.Text == "1. 예")
                productInfo.검사여부 = true;
            else productInfo.검사여부 = false;
            productInfo.리드타임 = int.Parse(txb리드타임.Text);
            productInfo.실제원가 = int.Parse(txb실제원가.Text);
            productInfo.안전재고량 = int.Parse(txb안전재고량.Text);
            productInfo.외경 = int.Parse(txb외경.Text);
            productInfo.일별생산량 = int.Parse(txb일별생산량.Text);
            productInfo.층 = int.Parse(txb층.Text);
            productInfo.표준원가 = int.Parse(txb표준원가.Text);
            productInfo.품목군 = txb품목군.Text;

            DB.제품.Update(productInfo);
            MessageBox.Show("변경");

            조회();
        }

        private void btn조회_Click(object sender, EventArgs e)
        {
            조회();
        }

        private void 품목등록_Load(object sender, EventArgs e)
        {
            제품BindingSource.DataSource = DB.제품.GetAll();

            cbb품목군.SelectedIndex = -1;

            dgv제품.Rows.Add();
            DB.사원등록.SearchDepartment(loginMember.EmployeeCode, out string code1, out string name1);
            cbb부서코드.Text = code1;
            txb부서명.Text = name1;
        }

        private void Dgv제품_KeyDown(object sender, KeyEventArgs e)
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
                    if (dgv제품.CurrentRow.Cells[1].Value == null)
                    {
                        MessageBox.Show("데이터를 입력하세요");
                        return;
                    }
                    if (dgv.Rows[maxRow-1].Cells[0].Value != null || dgv.Rows[maxRow - 1].Cells[1].Value != null)
                    {
                        dgv.Rows.Add();
                    }
                    dgv.CurrentCell = dgv[0, nowRow + 1];
                }
                else
                {
                    if (dgv제품.CurrentRow.Cells[0].Value == null)
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
            string 품목군 = cbb품목군.Text;
            string 검사여부 = cbbSearch검사여부.Text;
            var list = DB.제품.Search제품(품목군, 검사여부);

            dgv제품.Rows.Clear();
            dgv제품.Rows.Add();

            for (int i = 0; i < list.Count; i++)
            {
                dgv제품.Rows[i].Cells[0].Value = list[i].제품번호;
                dgv제품.Rows[i].Cells[1].Value = list[i].제품명;
                if (i != list.Count - 1)
                    dgv제품.Rows.Add();
            }
        }

        private void Cbb부서코드_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbb부서코드.SelectedValue != null)
                txb부서명.Text = DB.부서.SearchChangedValue(cbb부서코드.SelectedValue.ToString());
        }

        private void Cbb사원코드_SelectionChangeCommitted(object sender, EventArgs e)
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
