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

namespace SMART_ERP_System.MenuUserControl
{
    public partial class 사원등록 : UserControl
    {
        public 사원등록()
        {
            InitializeComponent();
        }

        private void 사원등록_Load(object sender, EventArgs e)
        {
            dgv사원.Rows.Add();
            var list = DB.사원등록.GetAll().Select(x => x.부서코드).Distinct().ToList();
            for (int i = 0; i < list.Count; i++)
                cbb부서코드.Items.Add(list[i]);
        }

        private void Dgv사원_KeyDown(object sender, KeyEventArgs e)
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
                    {
                        dgv.Rows.Add();
                    }
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

        private void Dgv사원_CellEndEdit(object sender, DataGridViewCellEventArgs e)
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

                if (DB.사원등록.Is사원코드(dgv.CurrentRow.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("등록되어있는 사원번호입니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string 사원번호 = dgv.CurrentRow.Cells[0].Value.ToString();

                if (DB.사원등록.Is사원코드(사원번호))
                {
                    txb사원코드.Text = 사원번호;
                    txb사원명.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                    txb영문이름.Text = DB.사원등록.Get사원정보(사원번호).Select(x=> x.사원명_영문_).FirstOrDefault();
                    txb부서코드.Text = DB.사원등록.Get사원정보(사원번호).Select(x => x.부서코드).FirstOrDefault();
                    dtp입사일.Value = DB.사원등록.Get사원정보(사원번호).Select(x => x.입사일).FirstOrDefault();
                    txb사용자여부.Text = DB.사원등록.Get사원정보(사원번호).Select(x => x.사용자여부).FirstOrDefault();
                    txb조회권한.Text = DB.사원등록.Get사원정보(사원번호).Select(x => x.조회권한).FirstOrDefault();
                    txb비상연락망.Text = DB.사원등록.Get사원정보(사원번호).Select(x => x.비상연락망).FirstOrDefault();
                    txb암호.Text = DB.사원등록.Get사원정보(사원번호).Select(x => x.암호).FirstOrDefault();
                    return;
                }

                else
                {
                    txb영문이름.Focus();
                    txb사원코드.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                    txb사원명.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                    txb영문이름.Text = null;
                    txb부서코드.Text = null;
                    dtp입사일.Value = DateTime.Today;
                    dtp퇴사일.Value= DateTime.Today;
                    txb사용자여부.Text = null;
                    txb조회권한.Text = null;
                    txb비상연락망.Text = null;
                    txb암호.Text = null;
                }
            }
        }

        private void Dgv사원_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.CurrentRow.Cells[0].Value == null || dgv.CurrentRow.Cells[1].Value == null) return;

            string 사원번호 = dgv.CurrentRow.Cells[0].Value.ToString();

            txb사원코드.Text = 사원번호;
            txb사원명.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            txb영문이름.Text = DB.사원등록.Get사원정보(사원번호).Select(x => x.사원명_영문_).FirstOrDefault();
            txb부서코드.Text = DB.사원등록.Get사원정보(사원번호).Select(x => x.부서코드).FirstOrDefault();
            dtp입사일.Value = DB.사원등록.Get사원정보(사원번호).Select(x => x.입사일).FirstOrDefault();
            txb사용자여부.Text = DB.사원등록.Get사원정보(사원번호).Select(x => x.사용자여부).FirstOrDefault();
            txb조회권한.Text = DB.사원등록.Get사원정보(사원번호).Select(x => x.조회권한).FirstOrDefault();
            txb비상연락망.Text = DB.사원등록.Get사원정보(사원번호).Select(x => x.비상연락망).FirstOrDefault();
            txb암호.Text = DB.사원등록.Get사원정보(사원번호).Select(x => x.암호).FirstOrDefault();
            return;
        }

        private void Btn등록_Click(object sender, EventArgs e)
        {
            ClassLibrary.사원등록 productInfo = new ClassLibrary.사원등록();

            productInfo.사원코드 = txb사원코드.Text;
            productInfo.사원명 = txb사원명.Text;
            productInfo.사원명_영문_ = txb영문이름.Text;
            productInfo.부서코드 = txb부서코드.Text;
            productInfo.사용자여부 = txb사용자여부.Text;
            productInfo.조회권한 = txb조회권한.Text;
            productInfo.암호 = txb암호.Text;
            productInfo.비상연락망 = txb비상연락망.Text;
            productInfo.입사일 = DateTime.Parse(dtp입사일.Value.ToShortDateString());
            DB.사원등록.Insert(productInfo);
            MessageBox.Show("등록");

            조회();
        }

        private void Btn변경_Click(object sender, EventArgs e)
        {
            ClassLibrary.사원등록 productInfo = new ClassLibrary.사원등록();
            
            productInfo.사원코드 = txb사원코드.Text;
            productInfo.사원명 = txb사원명.Text;
            productInfo.사원명_영문_ = txb영문이름.Text;
            productInfo.부서코드 = txb부서코드.Text;
            productInfo.사용자여부 = txb사용자여부.Text;
            productInfo.조회권한 = txb조회권한.Text;
            if (dtp퇴사일.Enabled == true)
                productInfo.퇴사일 = dtp퇴사일.Value;
            productInfo.입사일 = dtp입사일.Value;
            productInfo.암호 = txb암호.Text;
            productInfo.비상연락망 = txb비상연락망.Text;
            productInfo.입사일 = DateTime.Parse(dtp입사일.Value.ToShortDateString());
            
            DB.사원등록.Update(productInfo);
            MessageBox.Show("변경");

            조회();
        }

        private void Btn삭제_Click(object sender, EventArgs e)
        {
            ClassLibrary.사원등록 사원등록 = DB.사원등록.Get사원정보(dgv사원.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault();
                
            DB.사원등록.Delete(사원등록);
            MessageBox.Show("삭제");

            조회();
        }

        public void 조회()
        {
            var list = DB.사원등록.Get사원정보(txb부서.Text, txb사원.Text);

            dgv사원.Rows.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                dgv사원.Rows.Add();
                dgv사원.Rows[i].Cells[0].Value = list[i].사원코드;
                dgv사원.Rows[i].Cells[1].Value = list[i].사원명;               
            }
        }

        private void Btn조회_Click(object sender, EventArgs e)
        {
            조회();
        }

        private void Cbb부서코드_SelectedValueChanged(object sender, EventArgs e)
        {
            txb부서.Text = cbb부서코드.Text;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            dtp퇴사일.Enabled = checkBox2.Checked;
        }
    }
}
