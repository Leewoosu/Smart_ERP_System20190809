using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMART_ERP_System.Class;
using ClassLibrary.EntityData;
using ClassLibrary.FormHelper;

namespace SMART_ERP_System.MenuUserControl
{
    public partial class 합계잔액시산표 : UserControl
    {
        public 합계잔액시산표()
        {
            InitializeComponent();
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            MenuLists.SetDictionary();

            dgv합계잔액시산표.AutoGenerateColumns = false;

            for (int j = 0; j < dgv합계잔액시산표.ColumnCount; j++)
            {
                dgv합계잔액시산표.Columns[j].Width = 203;
                if (j != 2)
                {
                    dgv합계잔액시산표.Columns[j].DefaultCellStyle.Format = "###,##0";
                    dgv합계잔액시산표.Columns[j].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }

            dgv합계잔액시산표.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv합계잔액시산표.ColumnHeadersHeight = dgv합계잔액시산표.ColumnHeadersHeight * 2;
            dgv합계잔액시산표.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        /// <summary>
        /// 데이터 그리드 뷰 셀 페인트시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void Dgv합계잔액시산표_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                Rectangle rectangle = e.CellBounds;
                rectangle.Y += e.CellBounds.Height / 2;
                rectangle.Height = e.CellBounds.Height / 2;
                e.PaintBackground(rectangle, true);
                e.PaintContent(rectangle);
                e.Handled = true;
            }
        }

        /// <summary>
        /// 데이터 그리드 뷰 페인트시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void Dgv합계잔액시산표_Paint(object sender, PaintEventArgs e)
        {
            string[] separations = { "차변", "대변" };

            dgv합계잔액시산표.MergeHeaderCell(e, separations[0], 0, 2);
            dgv합계잔액시산표.MergeHeaderCell(e, separations[1], 3, 5);
            dgv합계잔액시산표.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv합계잔액시산표.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        /// <summary>
        /// 데이터 그리드 뷰 스크롤시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void Dgv합계잔액시산표_Scroll(object sender, ScrollEventArgs e)
        {
            Rectangle rtHeader = dgv합계잔액시산표.DisplayRectangle;
            rtHeader.Height = dgv합계잔액시산표.ColumnHeadersHeight / 2;
            dgv합계잔액시산표.Invalidate(rtHeader);
        }

        /// <summary>
        /// 데이터 그리드 뷰 컬럼 너비 변경시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void Dgv합계잔액시산표_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Rectangle rtHeader = dgv합계잔액시산표.DisplayRectangle;
            rtHeader.Height = dgv합계잔액시산표.ColumnHeadersHeight / 2;
            dgv합계잔액시산표.Invalidate(rtHeader);
        }

        private void Dtp입력날짜_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                합계잔액시산표BindingSource.DataSource = DB.합계잔액시산표.GetAll();

                var list = DB.전표리스트.GetAll();
                for (int i = 0; i < dgv합계잔액시산표.RowCount; i++)
                {
                    var list1 = DB.전표리스트.Serch합계잔액시산표(dtp입력날짜.Value, dgv합계잔액시산표.Rows[i].Cells[2].Value.ToString(), out long leftSum, out long rightSum);

                    if (leftSum != 0)
                        dgv합계잔액시산표.Rows[i].Cells[1].Value = leftSum;

                    if (rightSum != 0)
                        dgv합계잔액시산표.Rows[i].Cells[3].Value = rightSum;

                    if (leftSum > rightSum)
                        dgv합계잔액시산표.Rows[i].Cells[0].Value = leftSum - rightSum;
                    else
                        dgv합계잔액시산표.Rows[i].Cells[4].Value = rightSum - leftSum;
                }

                long leftTotal = 0;
                long leftBalance = 0;
                long rightTotal = 0;
                long rightBalance = 0;

                for (int i = 0; i < dgv합계잔액시산표.RowCount; i++)
                {
                    if (i < 39)
                    {
                        if (dgv합계잔액시산표.Rows[i].Cells[0].Value != null)
                            leftBalance += long.Parse(dgv합계잔액시산표.Rows[i].Cells[0].Value.ToString());

                        if (dgv합계잔액시산표.Rows[i].Cells[1].Value != null)
                            leftTotal += long.Parse(dgv합계잔액시산표.Rows[i].Cells[1].Value.ToString());
                    }
                    else
                    {
                        if (dgv합계잔액시산표.Rows[i].Cells[3].Value != null)
                            rightTotal += long.Parse(dgv합계잔액시산표.Rows[i].Cells[3].Value.ToString());

                        if (dgv합계잔액시산표.Rows[i].Cells[4].Value != null)
                            rightBalance += long.Parse(dgv합계잔액시산표.Rows[i].Cells[4].Value.ToString());
                    }
                }

                #region 그룹별 합산
                long left1 = 0, left2 = 0, right1 = 0, right2 = 0;
                long x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0;

                // 당좌자산
                SumLeftNRight(ref left1, ref left2, ref right1, ref right2, 3, 16, 2);
                InitializeSum(out left1, out left2, out right1, out right2);

                // 재고자산
                SumLeftNRight(ref left1, ref left2, ref right1, ref right2, 17, 21, 16);
                InitializeSum(out left1, out left2, out right1, out right2);

                // 임대주택자산
                SumLeftNRight2(ref left1, ref left2, ref right1, ref right2, 22, 21);
                InitializeSum(out left1, out left2, out right1, out right2);


                // 유동자산
                GroupTotal(ref x1, ref x2, ref x3, 2, 16, 21, 1);
                InitializeParams(out x1, out x2, out x3, out x4, out x5);

                // 유형자산
                SumLeftNRight(ref left1, ref left2, ref right1, ref right2, 25, 34, 24);
                InitializeSum(out left1, out left2, out right1, out right2);

                // 무형자산
                SumLeftNRight2(ref left1, ref left2, ref right1, ref right2, 35, 34);
                InitializeSum(out left1, out left2, out right1, out right2);

                // 기타비유동자산
                SumLeftNRight2(ref left1, ref left2, ref right1, ref right2, 37, 36);
                InitializeSum(out left1, out left2, out right1, out right2);

                // 비유동자산
                GroupTotal(ref x1, ref x2, ref x3, 24, 34, 36, 23);
                InitializeParams(out x1, out x2, out x3, out x4, out x5);

                // 자산
                GroupTotal(ref x1, ref x2, 1, 23, 0);
                InitializeParams(out x1, out x2, out x3, out x4, out x5);

                //========================================//

                // 유동부채
                SumLeftNRight(ref left1, ref left2, ref right1, ref right2, 40, 49, 39);
                InitializeSum(out left1, out left2, out right1, out right2);

                // 비유동부채
                SumLeftNRight(ref left1, ref left2, ref right1, ref right2, 50, 52, 49);
                InitializeSum(out left1, out left2, out right1, out right2);

                // 부채
                GroupTotal(ref x1, ref x2, 39, 49, 38);
                InitializeParams(out x1, out x2, out x3, out x4, out x5);

                //========================================//

                // 자본금
                SumLeftNRight2(ref left1, ref left2, ref right1, ref right2, 54, 53);
                InitializeSum(out left1, out left2, out right1, out right2);

                // 자본조정
                SumLeftNRight2(ref left1, ref left2, ref right1, ref right2, 56, 55);
                InitializeSum(out left1, out left2, out right1, out right2);

                // 이익잉여금
                SumLeftNRight(ref left1, ref left2, ref right1, ref right2, 58, 60, 57);
                InitializeSum(out left1, out left2, out right1, out right2);

                // 자본
                GroupTotal(ref x1, ref x2, ref x3, 53, 55, 57, 52);
                InitializeParams(out x1, out x2, out x3, out x4, out x5);

                //========================================//

                InitializeSum(out left1, out left2, out right1, out right2);

                // 매출액
                SumLeftNRight(ref left1, ref left2, ref right1, ref right2, 62, 64, 61);
                InitializeSum(out left1, out left2, out right1, out right2);

                // 매출원가
                SumLeftNRight(ref left1, ref left2, ref right1, ref right2, 65, 67, 64);
                InitializeSum(out left1, out left2, out right1, out right2);

                // 제조원가
                SumLeftNRight(ref left1, ref left2, ref right1, ref right2, 68, 82, 67);
                InitializeSum(out left1, out left2, out right1, out right2);

                // 판매관리비
                SumLeftNRight(ref left1, ref left2, ref right1, ref right2, 83, 98, 82);
                InitializeSum(out left1, out left2, out right1, out right2);

                // 영업외비용
                SumLeftNRight(ref left1, ref left2, ref right1, ref right2, 99, 101, 98);
                InitializeSum(out left1, out left2, out right1, out right2);

                // 손익
                GroupTotal(ref x1, ref x2, ref x3, ref x4, ref x5, 61, 64, 67, 83, 98, 60);
                #endregion

                txb차변잔액총액.Text = leftBalance.ToString("###,##0");
                txb차변합계총액.Text = leftTotal.ToString("###,##0");
                txb대변합계총액.Text = rightTotal.ToString("###,##0");
                txb대변잔액총액.Text = rightBalance.ToString("###,##0");
            }
        }

        /// <summary>
        /// 매개변수 초기화
        /// </summary>
        /// <param name="x1">매개변수1</param>
        /// <param name="x2">매개변수2</param>
        /// <param name="x3">매개변수3</param>
        /// <param name="x4">매개변수4</param>
        /// <param name="x5">매개변수5</param>
        private static void InitializeParams(out long x1, out long x2, out long x3, out long x4, out long x5)
        {
            x1 = 0;
            x2 = 0;
            x3 = 0;
            x4 = 0;
            x5 = 0;
        }

        /// <summary>
        /// 그룹별 최종 합계
        /// </summary>
        /// <param name="x1">매개변수1</param>
        /// <param name="x2">매개변수2</param>
        /// <param name="x3">매개변수3</param>
        /// <param name="x4">매개변수4</param>
        /// <param name="x5">매개변수5</param>
        /// <param name="index1">매개변수 인덱스1</param>
        /// <param name="index2">매개변수 인덱스2</param>
        /// <param name="index3">매개변수 인덱스3</param>
        /// <param name="index4">매개변수 인덱스4</param>
        /// <param name="index5">매개변수 인덱스5</param>
        /// <param name="inputIndex">저장될 데이터의 인덱스</param>
        private void GroupTotal(ref long x1, ref long x2, ref long x3, ref long x4, ref long x5, int index1, int index2, int index3, int index4, int index5, int inputIndex)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i != 2)
                {
                    if (dgv합계잔액시산표.Rows[index1].Cells[i].Value != null)
                        x1 = long.Parse(dgv합계잔액시산표.Rows[index1].Cells[i].Value.ToString());

                    if (dgv합계잔액시산표.Rows[index2].Cells[i].Value != null)
                        x2 = long.Parse(dgv합계잔액시산표.Rows[index2].Cells[i].Value.ToString());

                    if (dgv합계잔액시산표.Rows[index3].Cells[i].Value != null)
                        x3 = long.Parse(dgv합계잔액시산표.Rows[index3].Cells[i].Value.ToString());

                    if (dgv합계잔액시산표.Rows[index4].Cells[i].Value != null)
                        x4 = long.Parse(dgv합계잔액시산표.Rows[index4].Cells[i].Value.ToString());

                    if (dgv합계잔액시산표.Rows[index5].Cells[i].Value != null)
                        x5 = long.Parse(dgv합계잔액시산표.Rows[index5].Cells[i].Value.ToString());

                    dgv합계잔액시산표.Rows[inputIndex].Cells[i].Value = x1 + x2 + x3 + x4 + x5;
                }
            }
        }
        
        /// <summary>
        /// 그룹별 최종 합계
        /// </summary>
        /// <param name="x1">매개변수1</param>
        /// <param name="x2">매개변수2</param>
        /// <param name="x3">매개변수3</param>
        /// <param name="index1">매개변수 인덱스1</param>
        /// <param name="index2">매개변수 인덱스2</param>
        /// <param name="index3">매개변수 인덱스3</param>
        /// <param name="inputIndex">저장될 데이터의 인덱스</param>
        private void GroupTotal(ref long x1, ref long x2, ref long x3, int index1, int index2, int index3, int inputIndex)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i != 2)
                {
                    if (dgv합계잔액시산표.Rows[index1].Cells[i].Value != null)
                        x1 = long.Parse(dgv합계잔액시산표.Rows[index1].Cells[i].Value.ToString());

                    if (dgv합계잔액시산표.Rows[index2].Cells[i].Value != null)
                        x2 = long.Parse(dgv합계잔액시산표.Rows[index2].Cells[i].Value.ToString());

                    if (dgv합계잔액시산표.Rows[index3].Cells[i].Value != null)
                        x3 = long.Parse(dgv합계잔액시산표.Rows[index3].Cells[i].Value.ToString());

                    dgv합계잔액시산표.Rows[inputIndex].Cells[i].Value = x1 + x2 + x3;
                }
            }
        }

        /// <summary>
        /// 그룹별 최종 합계
        /// </summary>
        /// <param name="x1">매개변수1</param>
        /// <param name="x2">매개변수2</param>
        /// <param name="index1">매개변수 인덱스1</param>
        /// <param name="index2">매개변수 인덱스2</param>
        /// <param name="inputIndex">저장될 데이터의 인덱스</param>
        private void GroupTotal(ref long x1, ref long x2, int index1, int index2, int inputIndex)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i != 2)
                {
                    if (dgv합계잔액시산표.Rows[index1].Cells[i].Value != null)
                        x1 = long.Parse(dgv합계잔액시산표.Rows[index1].Cells[i].Value.ToString());

                    if (dgv합계잔액시산표.Rows[index2].Cells[i].Value != null)
                        x2 = long.Parse(dgv합계잔액시산표.Rows[index2].Cells[i].Value.ToString());

                    dgv합계잔액시산표.Rows[inputIndex].Cells[i].Value = x1 + x2;
                }
            }
        }

        /// <summary>
        /// 그룹별 합계 2
        /// </summary>
        /// <param name="left1">차변잔액</param>
        /// <param name="left2">차변합계</param>
        /// <param name="right1">대변합계</param>
        /// <param name="right2">대변잔액</param>
        /// <param name="index">매개 인덱스</param>
        /// <param name="input">저장될 데이터의 인덱스</param>
        private void SumLeftNRight2(ref long left1, ref long left2, ref long right1, ref long right2, int index, int input)
        {
            if (dgv합계잔액시산표.Rows[index].Cells[0].Value != null)
                left1 += long.Parse(dgv합계잔액시산표.Rows[index].Cells[0].Value.ToString());

            if (dgv합계잔액시산표.Rows[index].Cells[1].Value != null)
                left2 += long.Parse(dgv합계잔액시산표.Rows[index].Cells[1].Value.ToString());

            if (dgv합계잔액시산표.Rows[index].Cells[3].Value != null)
                right1 += long.Parse(dgv합계잔액시산표.Rows[index].Cells[3].Value.ToString());

            if (dgv합계잔액시산표.Rows[index].Cells[4].Value != null)
                right2 += long.Parse(dgv합계잔액시산표.Rows[index].Cells[4].Value.ToString());

            dgv합계잔액시산표.Rows[input].Cells[0].Value = left1;
            dgv합계잔액시산표.Rows[input].Cells[1].Value = left2;
            dgv합계잔액시산표.Rows[input].Cells[3].Value = right1;
            dgv합계잔액시산표.Rows[input].Cells[4].Value = right2;
        }

        /// <summary>
        /// 그룹별 합계 1
        /// </summary>
        /// <param name="left1">차변잔액</param>
        /// <param name="left2">차변합계</param>
        /// <param name="right1">대변합계</param>
        /// <param name="right2">대변잔액</param>
        /// <param name="start">시작 인덱스</param>
        /// <param name="end">끝 인덱스</param>
        /// <param name="input">저장될 데이터의 인덱스</param>
        private void SumLeftNRight(ref long left1, ref long left2, ref long right1, ref long right2, int start, int end, int input)
        {
            for (int i = start; i < end; i++)
            {
                if (dgv합계잔액시산표.Rows[i].Cells[0].Value != null)
                    left1 += long.Parse(dgv합계잔액시산표.Rows[i].Cells[0].Value.ToString());

                if (dgv합계잔액시산표.Rows[i].Cells[1].Value != null)
                    left2 += long.Parse(dgv합계잔액시산표.Rows[i].Cells[1].Value.ToString());

                if (dgv합계잔액시산표.Rows[i].Cells[3].Value != null)
                    right1 += long.Parse(dgv합계잔액시산표.Rows[i].Cells[3].Value.ToString());

                if (dgv합계잔액시산표.Rows[i].Cells[4].Value != null)
                    right2 += long.Parse(dgv합계잔액시산표.Rows[i].Cells[4].Value.ToString());
            }

            dgv합계잔액시산표.Rows[input].Cells[0].Value = left1;
            dgv합계잔액시산표.Rows[input].Cells[1].Value = left2;
            dgv합계잔액시산표.Rows[input].Cells[3].Value = right1;
            dgv합계잔액시산표.Rows[input].Cells[4].Value = right2;
        }

        /// <summary>
        /// 차변, 대변 변수 초기화
        /// </summary>
        /// <param name="left1">차변잔액</param>
        /// <param name="left2">차변합계</param>
        /// <param name="right1">대변합계</param>
        /// <param name="right2">대변잔액</param>
        private static void InitializeSum(out long left1, out long left2, out long right1, out long right2)
        {
            left1 = 0;
            left2 = 0;
            right1 = 0;
            right2 = 0;
        }

        private void Dgv합계잔액시산표_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgv합계잔액시산표.RowCount - 1; i++)
            {
                string comparer = dgv합계잔액시산표.Rows[i].Cells[2].Value.ToString();

                if (comparer.StartsWith("<") || comparer.StartsWith("["))
                    dgv합계잔액시산표.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }

        private void 합계잔액시산표_Load(object sender, EventArgs e)
        {
            회사등록BindingSource.DataSource = DB.회사.GetAll();

            if (cbb회사코드.SelectedValue != null)
                txb회사명.Text = DB.회사.Search(cbb회사코드.Text);
        }
    }
}
