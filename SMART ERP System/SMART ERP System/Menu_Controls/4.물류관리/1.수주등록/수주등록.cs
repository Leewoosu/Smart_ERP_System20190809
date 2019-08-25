using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using ClassLibrary.EntityData;
using ClassLibrary;
using SMART_ERP_System.MenuUserControl;

namespace SMART_ERP_System
{
    public partial class 수주등록 : UserControl
    {
        public DateTime firstDate;
        public DateTime lastDate;
        public 수주등록()
        {
            InitializeComponent();
        }

        public void ImportExcelData_Read(string fileName, DataGridView dgv)
        {


            // 엑셀 문서 내용 추출
            string connectionString = string.Empty;

            if (File.Exists(fileName))  // 파일 확장자 검사
            {
                if (Path.GetExtension(fileName).ToLower() == ".xls")
                {   // Microsoft.Jet.OLEDB.4.0 은 32 bit 에서만 동작되므로 빌드할 때 64비트로 하면 에러가 발생함.
                    connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0};Extended Properties=Excel 8.0;", fileName);
                }
                else if (Path.GetExtension(fileName).ToLower() == ".xlsx")
                {
                    connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0};Extended Properties=Excel 12.0;", fileName);
                }
            }

            DataSet data = new DataSet();

            string strQuery = "SELECT * FROM [Sheet1$]";  // 엑셀 시트명 Sheet1의 모든 데이터를 가져오기
            OleDbConnection oleConn = new OleDbConnection(connectionString);
            oleConn.Open();

            OleDbCommand oleCmd = new OleDbCommand(strQuery, oleConn);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(oleCmd);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            data.Tables.Add(dataTable);

            dgv.DataSource = data.Tables[0].DefaultView;

            // 데이터에 맞게 칼럼 사이즈 조정하기
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
            }
            dgv.AllowUserToAddRows = false;  // 빈레코드 표시 안하기
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // 화면크기에 맞춰 채우기

            dataTable.Dispose();
            dataAdapter.Dispose();
            oleCmd.Dispose();

            oleConn.Close();
            oleConn.Dispose();

            if (dgv.Columns.Count > 9)
                dgv.Columns.Remove("column0");

            if (dgv.Columns.Count == 9)
                dgv.Columns.Add("column0", "비고");

            UpdataData();

        }

        public void UpdataData()
        {
            int maxRow = dgv엑셀.Rows.Count;
            수주 orderList = new 수주();
            List<수주> 수주 = DB.수주.GetAll();

            if (수주.Count != 0)
            {
                for (int j = 0; j < maxRow; j++)
                {
                    if (수주.Where(x => x.수주번호 == dgv엑셀.Rows[j].Cells[0].Value.ToString() && x.수주번호2 == dgv엑셀.Rows[j].Cells[1].Value.ToString()).Count() >= 1)
                    {

                        if (int.Parse(dgv엑셀.Rows[j].Cells[3].Value.ToString()) < int.Parse(수주.Where(x => x.수주번호 == dgv엑셀.Rows[j].Cells[0].Value.ToString() && x.수주번호2 == dgv엑셀.Rows[j].Cells[1].Value.ToString()).Select(x => x.주문수량).First().ToString()))
                            dgv엑셀.Rows[j].Cells[9].Value = "수량 감소 ".ToString();

                        else if (int.Parse(dgv엑셀.Rows[j].Cells[3].Value.ToString()) > int.Parse(수주.Where(x => x.수주번호 == dgv엑셀.Rows[j].Cells[0].Value.ToString() && x.수주번호2 == dgv엑셀.Rows[j].Cells[1].Value.ToString()).Select(x => x.주문수량).First().ToString()))
                            dgv엑셀.Rows[j].Cells[9].Value = "수량 증가 ".ToString();


                        if (DateTime.Parse(dgv엑셀.Rows[j].Cells[8].Value.ToString()).Date < 수주.Where(x => x.수주번호 == dgv엑셀.Rows[j].Cells[0].Value.ToString() && x.수주번호2 == dgv엑셀.Rows[j].Cells[1].Value.ToString()).Select(x => x.납기일).First().Date)
                            dgv엑셀.Rows[j].Cells[9].Value = "납기일 당겨짐".ToString();


                        else if (DateTime.Parse(dgv엑셀.Rows[j].Cells[8].Value.ToString()).Date > 수주.Where(x => x.수주번호 == dgv엑셀.Rows[j].Cells[0].Value.ToString() && x.수주번호2 == dgv엑셀.Rows[j].Cells[1].Value.ToString()).Select(x => x.납기일).First().Date)
                            dgv엑셀.Rows[j].Cells[9].Value = "납기일 늦어짐".ToString();


                        else
                            dgv엑셀.Rows[j].Cells[9].Value = "New Data".ToString();



                    }

                }
            }
            else
            {
                for (int j = 0; j < maxRow; j++)
                    dgv엑셀.Rows[j].Cells[9].Value = "New Data".ToString();

                return;
            }
        }

        public void InsertDB()
        {
            수주 orderList = new 수주();
            List<수주> 수주 = DB.수주.GetAll();
            발주등록.BehindSujuListCnt = DB.수주.GetAll().Count;
            if (수주.Where(x => x.수주번호 == dgv엑셀.CurrentRow.Cells[0].Value.ToString()).ToList().Count == 0 || 수주.
                Where(x => x.수주번호2 == dgv엑셀.CurrentRow.Cells[1].Value.ToString()).Count() == 0)
            {
                orderList.수주번호 = dgv엑셀.CurrentRow.Cells[0].Value.ToString();
                orderList.수주번호2 = dgv엑셀.CurrentRow.Cells[1].Value.ToString();
                orderList.제품번호 = dgv엑셀.CurrentRow.Cells[2].Value.ToString();
                orderList.주문수량 = int.Parse(dgv엑셀.CurrentRow.Cells[3].Value.ToString());
                orderList.납품업체번호 = dgv엑셀.CurrentRow.Cells[4].Value.ToString();
                orderList.단가 = int.Parse(dgv엑셀.CurrentRow.Cells[5].Value.ToString());
                orderList.금액 = int.Parse(dgv엑셀.CurrentRow.Cells[6].Value.ToString());
                orderList.주문일 = DateTime.Parse(dgv엑셀.CurrentRow.Cells[7].Value.ToString());
                orderList.납기일 = DateTime.Parse(dgv엑셀.CurrentRow.Cells[8].Value.ToString());
                orderList.잔량 = orderList.주문수량;
                orderList.출고량 = 0;
                orderList.출고여부 = false;

                DB.수주.Insert(orderList);
                MessageBox.Show($"수주번호 {orderList.수주번호} / {orderList.수주번호2} 가 등록되엇습니다.");
                bds수주.DataSource
                                = DB.수주.조회(txb품목명.Text, txb납품업체이름.Text, firstDate, lastDate);
                Register발주();
            }

            else
                MessageBox.Show("이미 등록된 수주 데이터 입니다");
        }

        void Register발주()
        {

            var Last수주 = DB.수주.Search수주(dgv엑셀.CurrentRow.Cells[0].Value.ToString(), dgv엑셀.CurrentRow.Cells[1].Value.ToString()).FirstOrDefault(); //최근에 등록된 수주
            var 자재명세서 = DB.자재명세서.Get자재명세서(Last수주.제품번호); //등록된 수주의 자재명세서           
            var 자재 = DB.자재.GetAll();
            var 제품 = DB.제품.Get제품(Last수주.제품번호);
            var Last제품 = 제품[제품.Count - 1]; //수주받은 제품에 대한 정보
            var 수량 = new List<int>();
            발주리스트 발주리스트 = new 발주리스트();
            var list = new List<발주서>();
            var 자재List = new List<string>();

            //만들어야할 제품의 갯수
            Last제품.재고량 = (int)Last제품.재고량 - Last수주.주문수량 - (int)Last제품.안전재고량;

            for (int i = 0; i < 자재명세서.Count; i++)
            {
                for (int j = 0; j < 자재.Count; j++)
                {
                    if (자재명세서[i].자재번호 == 자재[j].자재번호)
                    {
                        if (Last제품.재고량 < 0)
                        {
                            자재[j].재고량 = 자재[j].재고량 + 자재명세서[i].수량 * (int)Last제품.재고량 - 자재[j].안전재고량;
                        }

                        if (자재[j].재고량 < 0)
                        {
                            발주서 발주서 = new 발주서();
                            if (DB.발주서.GetCount() == 0) 발주서.발주번호 = "1";
                            else 발주서.발주번호 = (int.Parse(DB.발주서.GetAll().LastOrDefault().발주번호) + 1).ToString();
                            발주서.공급업체번호 = DB.공급자재리스트.Get공급업체번호(자재명세서[i].자재번호);
                            발주서.주문날짜 = DateTime.Today;
                            발주서.납기일 = Last수주.납기일.AddDays(-Last제품.리드타임 - 자재[j].리드타임);

                            list.Add(발주서);
                            수량.Add(자재[j].재고량);
                            자재List.Add(자재[j].자재번호);
                            
                            자재[j].재고량 = 자재[j].재고량 - (자재명세서[i].수량 * (int)Last제품.재고량 - 자재[j].안전재고량);
                        }
                    }
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i].공급업체번호 == list[j].공급업체번호)
                    {
                        list[i].발주번호 = list[j].발주번호;
                        if (list[i].납기일 <= list[j].납기일)
                            list[i].납기일 = list[j].납기일;
                        else
                            list[j].납기일 = list[i].납기일;
                        break;
                    }

                }
                if (DB.발주서.Is발주번호(list[i].발주번호).Count == 0)
                {
                    DB.발주서.Insert(list[i]);
                    발주리스트.발주번호 = list[i].발주번호;
                    발주리스트.자재번호 = 자재List[i];
                    발주리스트.수량 = 수량[i] * (-1);
                    DB.발주리스트.Insert(발주리스트);
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        list[j].발주번호 = (int.Parse(DB.발주서.GetAll().LastOrDefault().발주번호) + 1).ToString();
                    }
                }
                else
                {
                    발주리스트.발주번호 = list[i].발주번호;
                    발주리스트.자재번호 = 자재List[i];
                    발주리스트.수량 = 수량[i] * (-1);
                    DB.발주리스트.Insert(발주리스트);
                }
            }           
        }

        private void btn조회_Click(object sender, EventArgs e)
        {
            조회();
        }

        private void btn변경_Click(object sender, EventArgs e)
        {
            수주 orderList = new 수주();

            DialogResult result = MessageBox.Show("변경 하기겠습니까?", "알림",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                orderList.수주번호 = dgv엑셀.CurrentRow.Cells[0].Value.ToString();
                orderList.수주번호2 = dgv엑셀.CurrentRow.Cells[1].Value.ToString();
                orderList.제품번호 = dgv엑셀.CurrentRow.Cells[2].Value.ToString();
                orderList.주문수량 = int.Parse(dgv엑셀.CurrentRow.Cells[3].Value.ToString());
                orderList.납품업체번호 = dgv엑셀.CurrentRow.Cells[4].Value.ToString();
                orderList.주문일 = (DateTime)dgv엑셀.CurrentRow.Cells[5].Value;
                orderList.납기일 = (DateTime)dgv엑셀.CurrentRow.Cells[6].Value;
                DB.수주.Update(orderList);

                MessageBox.Show("변경하였습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bds수주.DataSource = DB.수주.GetAll();
            }
            조회();
        }

        private void btn삭제_Click(object sender, EventArgs e)
        {
            수주 orderList = dgv수주.CurrentRow.DataBoundItem as 수주;

            if (orderList == null) return;

            DialogResult result = MessageBox.Show("삭제 하시겠습니까?", "알림",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                DB.수주.Delete(orderList);
                //List<수주> DeleteOrderList = (dgv수주.CurrentRow.DataBoundItem.ToString()).ToList();
                MessageBox.Show("삭제하였습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bds수주.DataSource = DB.수주.GetAll();
            }
            조회();
        }

        private void RegisterSujuExcelControl_Load(object sender, EventArgs e)
        {
            firstDate = FirstDate.Value;
            lastDate = LastDate.Value;
        }

        private void FirstDate_ValueChanged(object sender, EventArgs e)
        {
            firstDate = FirstDate.Value;
        }

        private void LastDate_ValueChanged(object sender, EventArgs e)
        {
            lastDate = LastDate.Value;
        }

        private void Btn엑셀_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dlg = new OpenFileDialog()) // 파일 선택창 객체를 생성
                {
                    dlg.Filter = "Excel Files(97~2003)|*.xls";
                    dlg.InitialDirectory = @"C:\test.xls";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        ImportExcelData_Read(dlg.FileName, dgv엑셀); // 메서드를 호출
                    }
                }
            }
            catch (Exception ex)  // 엑셀파일이 다른 프로그렘에서 이미 열었거나 에러가 발생하면 에러를 출력해준다.
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn등록_Click(object sender, EventArgs e)
        {
            InsertDB();
            조회();
        }

        public void 조회()
        {
            bds수주.DataSource
                = DB.수주.조회(txb품목명.Text, txb납품업체이름.Text, firstDate, lastDate);
            for (int i = 0; i < dgv수주.RowCount - 1; i++)
            {
                dgv수주.Rows[i].Cells[2].Value = DB.제품.Get제품(dgv수주.Rows[i].Cells[2].Value.ToString()).Select(x => x.제품명).First().ToString();
                dgv수주.Rows[i].Cells[4].Value = DB.일반거래처.Get공급업체이름From번호(dgv수주.Rows[i].Cells[4].Value.ToString());
            }
        }
    }
}