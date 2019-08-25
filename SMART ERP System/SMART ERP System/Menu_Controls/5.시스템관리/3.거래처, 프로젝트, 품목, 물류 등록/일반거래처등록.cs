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
    public partial class 일반거래처등록 : UserControl
    {
        public 일반거래처등록()
        {
            InitializeComponent();
            일반거래처등록bds.DataSource = DB.일반거래처.GetAll();
            var list = DB.거래처.GetAll();
            
            cbb거래처코드.DataSource = list.Select(x=>x.거래처코드번호).ToList();
            cbb거래처코드.SelectedIndex = -1;
        }

        private void 일반거래처등록_Load(object sender, EventArgs e)
        {
            txb거래처명.Text = DB.일반거래처.NormalSearch(cbb거래처코드.Text);
        }

        private void Cbb거래처코드_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbb거래처코드.SelectedIndex !=-1)
            {
                txb거래처명.Text = DB.일반거래처.SearchChangedValue(cbb거래처코드.SelectedValue.ToString());
                일반거래처등록bds.DataSource = DB.일반거래처.검색(txb거래처명.Text);
            }
            else
                일반거래처등록bds.DataSource = DB.일반거래처.GetAll();
        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassLibrary.일반거래처등록 일반거래처 = DB.일반거래처.SearchCode(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txb사업자등록번호.Text = 일반거래처.사업자등록번호;
            txb주민등록번호.Text = 일반거래처.주민등록번호;
            txb대표자성명.Text = 일반거래처.대표자성명;
            txb업태.Text = 일반거래처.업태;
            txb종목.Text = 일반거래처.종목;
            txb사업장주소.Text = 일반거래처.사업장주소;
            txb사업장번지.Text = 일반거래처.사업장번지;
            txb사업장전화번호.Text = 일반거래처.사업장전화번호;
            dtp거래시작일.Value = 일반거래처.거래시작일;
            //dtp거래종료일.Value = 일반거래처.거래종료일;
        }


        public void Insert일반거래처등록()
        {
            ClassLibrary.일반거래처등록 일반거래처등록 = new ClassLibrary.일반거래처등록();
            일반거래처등록.일반거래처코드 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            일반거래처등록.거래처코드번호 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            일반거래처등록.거래처명 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            일반거래처등록.구분 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            일반거래처등록.사업자등록번호 = txb사업자등록번호.Text;
            일반거래처등록.주민등록번호 = txb주민등록번호.Text;
            일반거래처등록.대표자성명 = txb대표자성명.Text;
            일반거래처등록.업태 = txb업태.Text;
            일반거래처등록.종목 = txb종목.Text;
            일반거래처등록.사업장주소 = txb사업장주소.Text;
            일반거래처등록.사업장번지 = txb사업장번지.Text;
            일반거래처등록.사업장전화번호 = txb사업장전화번호.Text;
            일반거래처등록.거래시작일 = (DateTime )dtp거래시작일.Value;
            일반거래처등록.거래종료일 = (DateTime)dtp거래종료일.Value;


            DB.일반거래처.Insert(일반거래처등록);
            MessageBox.Show("등록되었습니다.");
        }

        public void Delete일반거래처등록()
        {
            ClassLibrary.일반거래처등록 일반거래처등록 = new ClassLibrary.일반거래처등록();
            일반거래처등록 = dataGridView1.CurrentRow.DataBoundItem as ClassLibrary.일반거래처등록;

            if (일반거래처등록 == null) return;

            DialogResult result = MessageBox.Show("삭제 하시겠습니까?", "알림",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                DB.일반거래처.Delete(일반거래처등록);
                MessageBox.Show("삭제하였습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                일반거래처등록bds.DataSource = DB.일반거래처.GetAll();
            }
        }

        public void Update일반거래처등록()
        {
            ClassLibrary.일반거래처등록 일반거래처등록 = new ClassLibrary.일반거래처등록();

            DialogResult result = MessageBox.Show("변경 하시겠습니까?", "알림",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                일반거래처등록.일반거래처코드 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                일반거래처등록.거래처코드번호 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                일반거래처등록.거래처명 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                일반거래처등록.구분 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                일반거래처등록.사업자등록번호 = txb사업자등록번호.Text;
                일반거래처등록.주민등록번호 = txb주민등록번호.Text;
                일반거래처등록.대표자성명 = txb대표자성명.Text;
                일반거래처등록.업태 = txb업태.Text;
                일반거래처등록.종목 = txb종목.Text;
                일반거래처등록.사업장주소 = txb사업장주소.Text;
                일반거래처등록.사업장번지 = txb사업장번지.Text;
                일반거래처등록.사업장전화번호 = txb사업장전화번호.Text;
                일반거래처등록.거래시작일 = (DateTime)dtp거래시작일.Value;
                일반거래처등록.거래종료일 = (DateTime)dtp거래종료일.Value;
                DB.일반거래처.Update(일반거래처등록);

                MessageBox.Show("변경하였습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                일반거래처등록bds.DataSource = DB.일반거래처.GetAll();
            }
        }

        private void btn일반등록_Click(object sender, EventArgs e)
        {
            Insert일반거래처등록();
        }

        private void btn일반삭체_Click(object sender, EventArgs e)
        {
            Delete일반거래처등록();
        }

        private void btn일반수정_Click(object sender, EventArgs e)
        {
            Update일반거래처등록();
        }
    }


}
