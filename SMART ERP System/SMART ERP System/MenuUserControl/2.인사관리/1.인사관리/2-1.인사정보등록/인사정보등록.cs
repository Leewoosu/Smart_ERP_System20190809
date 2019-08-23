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
    public partial class 인사정보등록 : UserControl
    {
        public 인사정보등록()
        {
            InitializeComponent();
		}

        private void Btn사진등록_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            pbox사진등록.Load(open.FileName);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string value = txb사원검색.Text;
            var list = DB.사원등록.GetAll();

            if (radiobtn재직.Checked && value != "")
                사원등록BindingSource.DataSource = list.Where
                    (x => (x.사원명 == value || x.사원코드 == value) && x.퇴사일 == null).ToList();

            else if (radiobtn재직.Checked && value == "")
                사원등록BindingSource.DataSource = list.Where
                    (x => x.퇴사일 == null).ToList();

            else if (radiobtn퇴직.Checked && value != "")
                사원등록BindingSource.DataSource = list.Where
                    (x => (x.사원명 == value || x.사원코드 == value) && x.퇴사일 != null).ToList();

            else if (radiobtn퇴직.Checked && value == "")
                사원등록BindingSource.DataSource = list.Where
                    (x => x.퇴사일 != null).ToList();

            else if (radiobtn전체.Checked && value == "")
                사원등록BindingSource.DataSource = list;

            else if (radiobtn전체.Checked && value != "")
                사원등록BindingSource.DataSource = list.Where
                    (x => (x.사원명 == value || x.사원코드 == value)).ToList();

        }

        private void Button8_Click(object sender, EventArgs e)
        {


            사원상세정보 사원상세정보 = new 사원상세정보();

			
            
            사원상세정보.사원코드 = dataGridView1.CurrentRow.Cells[0].
                Value.ToString();
			사원상세정보.사원사진 = pbox사진등록.ImageLocation.ToString();
            사원상세정보.사원이름_영문_ = txb성명영문.Text;
            사원상세정보.내외국인구분 = cbb내외국인구분.Text;
            사원상세정보.주민등록번호 = txb주민등록번호.Text;
            사원상세정보.성별 = cbb성별.Text;
            사원상세정보.생년월일 = dtp생년월일.Value;
            사원상세정보.전화번호 = txb전화번호.Text;
            사원상세정보.비상연락_HP_ = txb비상연락.Text;
            사원상세정보.최종학력 = cbb최종학력.Text;
            사원상세정보.주민등록주소 = txb주민등록주소2.Text;
            사원상세정보.상세주소 = txb상세주소.Text;
            사원상세정보.E_MAIL = txb이메일.Text;
            사원상세정보.입사일 = dtp입사일.Value;
            사원상세정보.퇴직일 = dtp퇴직일.Value;
            사원상세정보.중도퇴사일 = dtp중도퇴사일.Value;
            사원상세정보.그룹입사일 = dtp그룹입사일.Value;
            사원상세정보.휴직기간시작일 = dtp휴직기간1.Value;
            사원상세정보.휴직기간종료일 = dtp휴직기간2.Value;
            사원상세정보.재직구분 = cbb재직구분.Text;
            사원상세정보.부서 =  txb부서2.Text;
            사원상세정보.직종 = txb직종2.Text;
            사원상세정보.급여형태 = txb급여형태2.Text;
            사원상세정보.프로젝트 =  txb프로젝트2.Text;
            사원상세정보.근무조 =  txb근무조2.Text;
            사원상세정보.직급 =  txb직급2.Text;
            사원상세정보.직책 = txb직책2.Text;
            사원상세정보.퇴직사유 = txb퇴직사유2.Text;
            사원상세정보.호봉 = txb호봉2.Text;
            사원상세정보.계정유형 = txb성명영문.Text;
            사원상세정보.급여이체은행 = txb급여이체은행.Text;
            사원상세정보.계좌번호 = txb계좌번호.Text;
            사원상세정보.예금주 = txb예금주.Text;

            if (DialogResult.Yes == MessageBox.Show("변경사항을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo))
            {
                DB.사원상세정보.Insert(사원상세정보);
                MessageBox.Show("저장되었습니다.");
            }
            else
                MessageBox.Show("취소되었습니다.");
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.CurrentRow.Cells[0].Value == null) return;
            var list = DB.사원상세정보.Get사원상세정보(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    txb성명영문.Text = item.사원이름_영문_.ToString();
					pbox사진등록.Load(item.사원사진.ToString());
                    cbb내외국인구분.Text = item.내외국인구분.ToString();
                    txb주민등록번호.Text = item.주민등록번호.ToString();
                    cbb성별.Text = item.성별.ToString();
                    dtp생년월일.Value = item.생년월일;
                    txb전화번호.Text = item.전화번호.ToString();
                    txb비상연락.Text = item.비상연락_HP_.ToString();
                    cbb최종학력.Text = item.최종학력.ToString();
                    txb주민등록주소2.Text = item.주민등록주소.ToString();
                    txb상세주소.Text = item.상세주소.ToString();
                    txb이메일.Text = item.E_MAIL.ToString();
                    dtp입사일.Value = item.입사일; 
                    dtp퇴직일.Value = item.퇴직일.Value;
                    dtp중도퇴사일.Value = item.중도퇴사일.Value;
                    dtp그룹입사일.Value = item.그룹입사일;
                    dtp휴직기간1.Value = item.휴직기간시작일.Value;
                    dtp휴직기간2.Value = item.휴직기간종료일.Value;
                    cbb재직구분.Text = item.재직구분.ToString();
                    txb부서2.Text = item.부서.ToString();
                    txb직종2.Text = item.직종.ToString();
                    txb급여형태2.Text = item.급여형태.ToString();
                    txb프로젝트2.Text = item.프로젝트.ToString();
                    txb근무조2.Text = item.근무조.ToString();
                    txb직급2.Text = item.직급.ToString();
                    txb직책2.Text = item.직책.ToString();
                    txb퇴직사유2.Text = item.퇴직사유.ToString();
                    txb호봉2.Text = item.호봉.ToString();
                    txb계정유형.Text = item.계정유형.ToString();
                    txb급여이체은행.Text = item.급여이체은행.ToString();
                    txb계좌번호.Text = item.계좌번호.ToString();
                    txb예금주.Text = item.예금주.ToString();
                }
            }
            else
            {
                txbValueClear();
            }
        }
        private void txbValueClear()
        {
			txb성명영문.Text = "";
			pbox사진등록.ImageLocation = "";
			cbb내외국인구분.Text = "";
			txb주민등록번호.Text = "";
			cbb성별.Text = "";
			dtp생년월일.Value = DateTime.Now;
			txb전화번호.Text = "";
			txb비상연락.Text = "";
			cbb최종학력.Text = "";
			txb주민등록주소2.Text = "";
			txb상세주소.Text = "";
			txb이메일.Text = "";
			dtp입사일.Value = DateTime.Now;
			dtp퇴직일.Value = DateTime.Now;
			dtp중도퇴사일.Value = DateTime.Now;
			dtp그룹입사일.Value = DateTime.Now;
			dtp휴직기간1.Value = DateTime.Now;
			dtp휴직기간2.Value = DateTime.Now;
			cbb재직구분.Text = "";
			txb부서2.Text = "";
			txb직종2.Text = "";
			txb급여형태2.Text = "";
			txb프로젝트2.Text = "";
			txb근무조2.Text = "";
			txb직급2.Text = "";
			txb직책2.Text = "";
			txb퇴직사유2.Text = "";
			txb호봉2.Text = "";
			txb계정유형.Text = "";
			txb급여이체은행.Text = "";
			txb계좌번호.Text = "";
			txb예금주.Text = "";
		}
      
		private void Button5_Click(object sender, EventArgs e)
		{
			사원상세정보 사원상세정보 = new 사원상세정보();

			사원상세정보.사원코드 = dataGridView1.CurrentRow.Cells[0].
				Value.ToString();
			사원상세정보.사원사진 = pbox사진등록.ImageLocation.ToString();
			사원상세정보.사원이름_영문_ = txb성명영문.Text;
			사원상세정보.내외국인구분 = cbb내외국인구분.Text;
			사원상세정보.주민등록번호 = txb주민등록번호.Text;
			사원상세정보.성별 = cbb성별.Text;
			사원상세정보.생년월일 = dtp생년월일.Value;
			사원상세정보.전화번호 = txb전화번호.Text;
			사원상세정보.비상연락_HP_ = txb비상연락.Text;
			사원상세정보.최종학력 = cbb최종학력.Text;
			사원상세정보.주민등록주소 = txb주민등록주소2.Text;
			사원상세정보.상세주소 = txb상세주소.Text;
			사원상세정보.E_MAIL = txb이메일.Text;
			사원상세정보.입사일 = dtp입사일.Value;
			사원상세정보.퇴직일 = dtp퇴직일.Value;
			사원상세정보.중도퇴사일 = dtp중도퇴사일.Value;
			사원상세정보.그룹입사일 = dtp그룹입사일.Value;
			사원상세정보.휴직기간시작일 = dtp휴직기간1.Value;
			사원상세정보.휴직기간종료일 = dtp휴직기간2.Value;
			사원상세정보.재직구분 = cbb재직구분.Text;
			사원상세정보.부서 = txb부서2.Text;
			사원상세정보.직종 = txb직종2.Text;
			사원상세정보.급여형태 = txb급여형태2.Text;
			사원상세정보.프로젝트 = txb프로젝트2.Text;
			사원상세정보.근무조 = txb근무조2.Text;
			사원상세정보.직급 = txb직급2.Text;
			사원상세정보.직책 = txb직책2.Text;
			사원상세정보.퇴직사유 = txb퇴직사유2.Text;
			사원상세정보.호봉 = txb호봉2.Text;
			사원상세정보.계정유형 = txb성명영문.Text;
			사원상세정보.급여이체은행 = txb급여이체은행.Text;
			사원상세정보.계좌번호 = txb계좌번호.Text;
			사원상세정보.예금주 = txb예금주.Text;

			if (DialogResult.Yes == MessageBox.Show("변경사항을 수정하시겠습니까?", "수정", MessageBoxButtons.YesNo))
			{
				DB.사원상세정보.Update(사원상세정보);
				MessageBox.Show("수정되었습니다.");
			}
			else
				MessageBox.Show("취소되었습니다.");
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			사원상세정보 사원상세정보 = new 사원상세정보();

			사원상세정보.사원코드 = dataGridView1.CurrentRow.Cells[0].Value.ToString();

			if (DialogResult.Yes == MessageBox.Show("사원상세정보를 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo))
			{
				DB.사원상세정보.Delete(사원상세정보);
				MessageBox.Show("삭제되었습니다.");
			}
			else
				MessageBox.Show("취소되었습니다.");
		}
	}
}
