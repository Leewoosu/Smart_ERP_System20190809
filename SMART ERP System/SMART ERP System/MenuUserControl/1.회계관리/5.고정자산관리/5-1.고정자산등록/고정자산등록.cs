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
    public partial class 고정자산등록 : UserControl
    {
        public 고정자산등록()
        {
            InitializeComponent();
            
        }

        public void Load_DepreciationMethod()
        {
            cbb상각방법.SelectedIndex = -1;
        }

        private void 고정자산등록_Load(object sender, EventArgs e)
        {          
            Load_DepreciationMethod();

            고정자산bds.DataSource = DB.고정자산.GetAll();

            var list = DB.회사.GetAll();
            cbb회사코드.DataSource = list.Select(x => x.회사코드).ToList();
            cbb회사코드.SelectedIndex = -1;

            var list2 = DB.고정자산계정과목.GetAll();
            cbb고정자산계정코드.DataSource = list2.Select(x => x.고정자산과목코드).ToList();
            cbb고정자산계정코드.SelectedIndex = -1;

            txb회사명.Text = DB.회사.Search(cbb회사코드.Text);
            txb고정자산계정명.Text = DB.고정자산계정과목.Search(cbb고정자산계정코드.Text);
        }

        private void Cbb회사코드_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbb회사코드.SelectedIndex != -1)
            {
                txb회사명.Text = DB.회사.SearchChangedValue(cbb회사코드.Text);
                고정자산bds.DataSource = DB.고정자산.회사검색(txb회사명.Text);
            }
            else
                고정자산bds.DataSource = DB.고정자산.GetAll();
        }



        private void Cbb고정자산계정코드_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbb고정자산계정코드.SelectedIndex != -1)
            {
                txb고정자산계정명.Text = DB.고정자산계정과목.SearchangedValue(cbb고정자산계정코드.Text);
                고정자산bds.DataSource = DB.고정자산.검색(txb고정자산계정명.Text);
            }
            else
                고정자산bds.DataSource = DB.고정자산.GetAll();
        }

        private void 고정자산dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassLibrary.고정자산 고정자산 = DB.고정자산.SearchCode(고정자산dgv.CurrentRow.Cells[0].Value.ToString());
            txb취득원가.Text = 고정자산.취득원가.ToString();
            txb전기말상각누계액.Text = 고정자산.전기말상각누계액.ToString();
            cbb상각방법.Text = 고정자산.상각방법;
            txb내용연수.Text = 고정자산.내용연수.ToString();
            txb경비구분.Text = 고정자산.경비구분;
            txb취득수.Text = 고정자산.취득수량.ToString();
            txb일반상각비.Text = 고정자산.일반상각비.ToString();
            txb당기말상각누계액.Text = 고정자산.당기말상각누계액.ToString();
            dtp입력일자.Value = 고정자산.입력일자;
            dtp수정일자.Value = 고정자산.수정일자;
            txb구입처명.Text = 고정자산.구입처;
            txb제작사명.Text = 고정자산.제작사;
            txb규격.Text = 고정자산.규격.ToString();
            txb모델명.Text = 고정자산.모델;
            txb비고.Text = 고정자산.비고;

        }

        public void 고정자산등록Insert()
        {
            ClassLibrary.고정자산 고정자산 = new ClassLibrary.고정자산();
            고정자산.고정자산코드 = 고정자산dgv.CurrentRow.Cells[0].Value.ToString();
            고정자산.고정자산명 = 고정자산dgv.CurrentRow.Cells[1].Value.ToString();
            고정자산.계정과목코드번호 = 고정자산dgv.CurrentRow.Cells[2].Value.ToString();
            고정자산.취득일 = (DateTime)고정자산dgv.CurrentRow.Cells[3].Value;
            고정자산.처리여부 = 고정자산dgv.CurrentRow.Cells[4].Value.ToString();
            고정자산.취득원가 = int.Parse(txb취득원가.Text);
            고정자산.전기말상각누계액 = int.Parse(txb전기말상각누계액.Text);
            고정자산.상각방법 = cbb상각방법.Text;
            고정자산.내용연수 = int.Parse(txb내용연수.Text);
            고정자산.경비구분 = txb경비구분.Text;
            고정자산.취득수량 = int.Parse(txb취득수.Text);
            고정자산.일반상각비 = int.Parse(txb일반상각비.Text);
            고정자산.당기말상각누계액 = int.Parse(txb당기말상각누계액.Text);
            고정자산.입력일자 = (DateTime)dtp입력일자.Value;
            고정자산.수정일자 = (DateTime)dtp수정일자.Value;
            고정자산.구입처 = txb구입처명.Text;
            고정자산.제작사 = txb제작사명.Text;
            고정자산.규격 = int.Parse(txb규격.Text);
            고정자산.모델 = txb모델명.Text;
            고정자산.비고 = txb비고.Text;

            DB.고정자산.Insert(고정자산);
            MessageBox.Show("등록되었습니다.");

        }

        public void 고정자산등록Update()
        {
            ClassLibrary.고정자산 고정자산 = new ClassLibrary.고정자산();

            DialogResult result = MessageBox.Show("변경 하시겠습니까?", "알림",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                고정자산.고정자산코드 = 고정자산dgv.CurrentRow.Cells[0].Value.ToString();
                고정자산.고정자산명 = 고정자산dgv.CurrentRow.Cells[1].Value.ToString();
                고정자산.계정과목코드번호 = 고정자산dgv.CurrentRow.Cells[2].Value.ToString();
                고정자산.취득일 = (DateTime)고정자산dgv.CurrentRow.Cells[3].Value;
                고정자산.처리여부 = 고정자산dgv.CurrentRow.Cells[4].Value.ToString();
                고정자산.취득원가 = int.Parse(txb취득원가.Text);
                고정자산.전기말상각누계액 = int.Parse(txb전기말상각누계액.Text);
                고정자산.상각방법 = cbb상각방법.Text;
                고정자산.내용연수 = int.Parse(txb내용연수.Text);
                고정자산.경비구분 = txb경비구분.Text;
                고정자산.취득수량 = int.Parse(txb취득수.Text);
                고정자산.일반상각비 = int.Parse(txb일반상각비.Text);
                고정자산.당기말상각누계액 = int.Parse(txb당기말상각누계액.Text);
                고정자산.입력일자 = (DateTime)dtp입력일자.Value;
                고정자산.수정일자 = (DateTime)dtp수정일자.Value;
                고정자산.구입처 = txb구입처명.Text;
                고정자산.제작사 = txb제작사명.Text;
                고정자산.규격 = int.Parse(txb규격.Text);
                고정자산.모델 = txb모델명.Text;
                고정자산.비고 = txb비고.Text;
                DB.고정자산.Update(고정자산);

                MessageBox.Show("변경하였습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                고정자산bds.DataSource = DB.고정자산.GetAll();
            }
        }

        public void 고정자산등록Delete()
        {

            ClassLibrary.고정자산 고정자산 = new ClassLibrary.고정자산();
            고정자산 = 고정자산dgv.CurrentRow.DataBoundItem as ClassLibrary.고정자산;

            if (고정자산 == null) return;

            DialogResult result = MessageBox.Show("삭제 하시겠습니까?", "알림",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                DB.고정자산.Delete(고정자산);
                MessageBox.Show("삭제하였습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                고정자산bds.DataSource = DB.고정자산.GetAll();
            }
        }

        private void 등록btn_Click(object sender, EventArgs e)
        {
            고정자산등록Insert();
        }

        private void 수정btn_Click(object sender, EventArgs e)
        {
            고정자산등록Update();
        }

        private void 삭제btn_Click(object sender, EventArgs e)
        {
            고정자산등록Delete();
        }

    
    }
}
