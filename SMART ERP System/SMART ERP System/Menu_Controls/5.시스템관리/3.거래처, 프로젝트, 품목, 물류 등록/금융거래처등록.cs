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
    public partial class 금융거래처등록 : UserControl
    {
        public 금융거래처등록()
        {
            InitializeComponent();
            금융거래처등록bds.DataSource = DB.금융거래처.GetAll();
            var list1 = DB.금융거래처.GetAll();
            cbb금융기관코드.DataSource = list1.Select(x =>x.금융기관명).ToList();
            cbb금융기관코드.SelectedIndex = -1;

            var list2 = DB.예금종류.GetAll();
            cbb금융예금종류.DataSource = list2.Select(x => x.예금내역명).ToList();
            cbb금융예금종류.SelectedIndex = -1;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassLibrary.금융거래처등록 금융거래처 = DB.금융거래처.SearchCode(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txb금융계좌번호.Text = 금융거래처.계좌번호;
            txb금융계좌개설점.Text = 금융거래처.계좌개설점;
            txb금융사업자등록번호.Text = 금융거래처.사업자등록번호;
            txb금융사업장주소.Text = 금융거래처.사업장주소;
            txb금융사업장번지.Text = 금융거래처.사업장번지;
            txb금융사업장전화번호1.Text = 금융거래처.사업장전화번호;
            cbb금융기관코드.SelectedItem = 금융거래처.금융기관명;
            cbb금융예금종류.SelectedItem = 금융거래처.예금종류;
            txb금융예금명.Text = 금융거래처.예금명;
            txb금융예금주명.Text = 금융거래처.예금주;
            dtp금융계좌개설일.Value = 금융거래처.계좌개설일.Value;
            dtp금융거래종료일.Value = 금융거래처.거래종료일.Value;
        }

        public void Insert금융거래처등록()
        {
            ClassLibrary.금융거래처등록 금융거래처등록 = new ClassLibrary.금융거래처등록();
            금융거래처등록.금융거래처코드 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            금융거래처등록.거래처코드번호 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            금융거래처등록.금융거래처명 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            금융거래처등록.구분 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            금융거래처등록.계좌번호 = txb금융계좌번호.Text;
            금융거래처등록.계좌개설점 = txb금융계좌개설점.Text;
            금융거래처등록.사업자등록번호 = txb금융사업자등록번호.Text;
            금융거래처등록.사업장주소 = txb금융사업장주소.Text;
            금융거래처등록.사업장번지 = txb금융사업장번지.Text;
            금융거래처등록.사업장전화번호 = txb금융사업장전화번호1.Text;
            금융거래처등록.금융기관명 = cbb금융기관코드.Text;
            금융거래처등록.예금종류 = cbb금융예금종류.Text;
            금융거래처등록.예금명 = txb금융예금명.Text;
            금융거래처등록.예금주 = txb금융예금주명.Text;
            금융거래처등록.계좌개설일 = (DateTime)dtp금융계좌개설일.Value;
            금융거래처등록.거래종료일 = (DateTime)dtp금융거래종료일.Value;

            DB.금융거래처.Insert(금융거래처등록);
            MessageBox.Show("등록되었습니다.");
        }

        public void Delete금융거래처등록()
        {
            ClassLibrary.금융거래처등록 금융거래처등록 = new ClassLibrary.금융거래처등록();
          금융거래처등록 = dataGridView1.CurrentRow.DataBoundItem as ClassLibrary.금융거래처등록;

            if (금융거래처등록 == null) return;

            DialogResult result = MessageBox.Show("삭제 하시겠습니까?", "알림",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                DB.금융거래처.Delete(금융거래처등록);
                MessageBox.Show("삭제하였습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                금융거래처등록bds.DataSource = DB.금융거래처.GetAll();
            }
        }

        public void Update금융거래처등록()
        {
            ClassLibrary.금융거래처등록 금융거래처등록 = new ClassLibrary.금융거래처등록();

            DialogResult result = MessageBox.Show("변경 하시겠습니까?", "알림",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                금융거래처등록.금융거래처코드 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                금융거래처등록.거래처코드번호 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                금융거래처등록.금융거래처명 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                금융거래처등록.구분 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                금융거래처등록.계좌번호 = txb금융계좌번호.Text;
                금융거래처등록.계좌개설점 = txb금융계좌개설점.Text;
                금융거래처등록.사업자등록번호 = txb금융사업자등록번호.Text;
                금융거래처등록.사업장주소 = txb금융사업장주소.Text;
                금융거래처등록.사업장번지 = txb금융사업장번지.Text;
                금융거래처등록.사업장전화번호 = txb금융사업장전화번호1.Text;
                금융거래처등록.금융기관명 = cbb금융기관코드.Text;
                금융거래처등록.예금종류 = cbb금융예금종류.Text;
                금융거래처등록.예금명 = txb금융예금명.Text;
                금융거래처등록.예금주 = txb금융예금주명.Text;
                금융거래처등록.계좌개설일 = (DateTime)dtp금융계좌개설일.Value;
                금융거래처등록.거래종료일 = (DateTime)dtp금융거래종료일.Value;
                DB.금융거래처.Update(금융거래처등록);

                MessageBox.Show("변경하였습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                금융거래처등록bds.DataSource = DB.금융거래처.GetAll();
            }
        }

        private void Btn등록_Click(object sender, EventArgs e)
        {
            Insert금융거래처등록();
        }

        private void btn삭제_Click(object sender, EventArgs e)
        {
            Delete금융거래처등록();
        }

        private void btn수정_Click(object sender, EventArgs e)
        {
            Update금융거래처등록();
        }
    }
}
