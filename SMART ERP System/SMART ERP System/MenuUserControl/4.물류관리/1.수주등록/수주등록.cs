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

namespace SMART_ERP_System
{
    public partial class 수주등록 : UserControl
    {
        public int firstDate;
        public int lastDate;
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

            InsertDB();
        }

        public void InsertDB()
        {
            int maxRow = dgv엑셀.Rows.Count;
            List<수주> 수주 = DB.수주.GetAll();
            수주 orderList = new 수주();

            for (int j = 0; j < maxRow; j++)
            {
                string Superkey = dgv엑셀.Rows[j].Cells[0].Value.ToString() + dgv엑셀.Rows[j].Cells[1].Value.ToString();
                int cnt = 0;
                for (int i = 0; i < 수주.Count; i++)
                {                   
                    string DBSuperKey =
                        dgv엑셀.Rows[i].Cells[0].Value.ToString() + dgv엑셀.Rows[i].Cells[1].Value.ToString();

                    if (Superkey != DBSuperKey)
                    {
                        cnt++;
                        if (cnt == 수주.Count)
                        {
                            orderList.수주번호 = dgv엑셀[0, j].Value.ToString();
                            orderList.수주번호2 = dgv엑셀[1, j].Value.ToString();
                            orderList.제품번호 = int.Parse(dgv엑셀[2, j].Value.ToString());
                            orderList.주문수량 = int.Parse(dgv엑셀[3, j].Value.ToString());
                            orderList.납품업체번호 = int.Parse(dgv엑셀[4, j].Value.ToString());
                            orderList.주문일 = int.Parse(dgv엑셀[5, j].Value.ToString());
                            orderList.납기일 = int.Parse(dgv엑셀[6, j].Value.ToString());

                            DB.수주.Insert(orderList);
                            cnt = 0;
                        }
                    }
                    else break;
                }

                foreach (var item in 수주)
                {
                    string DBSuperKey = item.수주번호 + item.수주번호2;

                    if (Superkey == DBSuperKey)
                    {
                        if (int.Parse(dgv엑셀.Rows[j].Cells[3].Value.ToString()) < item.주문수량)
                            dgv엑셀.Rows[j].Cells[7].Value = "다운";

                        else if (int.Parse(dgv엑셀.Rows[j].Cells[3].Value.ToString()) > item.주문수량)
                            dgv엑셀.Rows[j].Cells[7].Value = "업";


                        if (int.Parse(dgv엑셀.Rows[j].Cells[6].Value.ToString()) < item.납기일)
                            dgv엑셀.Rows[j].Cells[8].Value = "빨라짐";

                        else if (int.Parse(dgv엑셀.Rows[j].Cells[6].Value.ToString()) > item.납기일)
                            dgv엑셀.Rows[j].Cells[8].Value = "늦어짐";

                        break;
                    }
                }

            }
        }

        private void btn조회_Click(object sender, EventArgs e)
        {
            bds수주.DataSource
                = DB.수주.조회(txb품목명.Text, txb납품업체이름.Text, firstDate, lastDate);
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
                orderList.제품번호 = int.Parse(dgv엑셀.CurrentRow.Cells[2].Value.ToString());
                orderList.주문수량 = int.Parse(dgv엑셀.CurrentRow.Cells[3].Value.ToString());
                orderList.납품업체번호 = int.Parse(dgv엑셀.CurrentRow.Cells[4].Value.ToString());
                orderList.주문일 = int.Parse(dgv엑셀.CurrentRow.Cells[5].Value.ToString());
                orderList.납기일 = int.Parse(dgv엑셀.CurrentRow.Cells[6].Value.ToString());
                DB.수주.Update(orderList);

                MessageBox.Show("변경하였습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bds수주.DataSource = DB.수주.GetAll();
            }
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

                MessageBox.Show("삭제하였습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bds수주.DataSource = DB.수주.GetAll();
            }
        }

        private void RegisterSujuExcelControl_Load(object sender, EventArgs e)
        {
            firstDate = int.Parse(FirstDate.Value.ToString("yyyyMMdd"));
            lastDate = int.Parse(LastDate.Value.ToString("yyyyMMdd"));          
        }

        private void FirstDate_ValueChanged(object sender, EventArgs e)
        {
            firstDate = int.Parse(FirstDate.Value.ToString("yyyyMMdd"));
        }

        private void LastDate_ValueChanged(object sender, EventArgs e)
        {
            lastDate = int.Parse(LastDate.Value.ToString("yyyyMMdd"));
        }

        private void Dgv수주_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            int maxColumn = dgv수주.ColumnCount;
            int column = dgv수주.CurrentCell.ColumnIndex;
            int row = dgv수주.CurrentCell.RowIndex;
            if (!string.IsNullOrEmpty(dgv수주.CurrentRow.Cells[5].ToString()))
                return;
            if (column == 6)
            {
                DB.수주.수주등록(dgv수주.CurrentRow.DataBoundItem,
                    dgv수주.CurrentRow.Cells[0].Value.ToString(),
                    dgv수주.CurrentRow.Cells[1].Value.ToString());
                bds수주.DataSource = DB.수주.GetAll();
            }

        }

        private void Btn엑셀_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dlg = new OpenFileDialog()) // 파일 선택창 객체를 생성
                {
                    dlg.Filter = "Excel Files(2007이상)|*.xlsx|Excel Files(97~2003)|*.xls";
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
    }



}


