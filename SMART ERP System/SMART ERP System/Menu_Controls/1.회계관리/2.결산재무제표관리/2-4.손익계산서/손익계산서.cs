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
using ClassLibrary.FormHelper;
using SMART_ERP_System.Class;

namespace SMART_ERP_System.MenuUserControl
{
    public partial class 손익계산서 : UserControl
    {

        public 손익계산서()
        {
            InitializeComponent();
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            MenuLists.Set();
            cbb금액구분.DataSource = MenuLists.moneyUnit;

            dgv손익계산서.AutoGenerateColumns = false;

            for (int j = 0; j < dgv손익계산서.ColumnCount; j++)
            {
                dgv손익계산서.Columns[j].Width = 203;
            }

            dgv손익계산서.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv손익계산서.ColumnHeadersHeight = dgv손익계산서.ColumnHeadersHeight * 2;
            dgv손익계산서.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        private void Dtp입력날짜_KeyDown(object sender, KeyEventArgs e)
        {
            손익계산서BindingSource.DataSource = DB.손익계산서.GetAll();

            if (e.KeyData == Keys.Enter)
            {
                var list = DB.전표리스트.GetAll();
                for (int i = 0; i < dgv손익계산서.RowCount; i++)
                {
                    var list1 = DB.전표리스트.Serch손익계산서(dtp입력날짜.Value, dgv손익계산서.Rows[i].Cells[0].Value.ToString(), out long left, out long right);
                    dgv손익계산서.Rows[i].Cells[1].Value = left;
                    dgv손익계산서.Rows[i].Cells[2].Value = right;
                }

                //매출액 합계
                dgv손익계산서.Rows[0].Cells[2].Value = long.Parse(dgv손익계산서.Rows[1].Cells[2].Value.ToString()) 
                                                        + long.Parse(dgv손익계산서.Rows[2].Cells[2].Value.ToString());

                //매출원가 합계
                dgv손익계산서.Rows[3].Cells[2].Value = long.Parse(dgv손익계산서.Rows[4].Cells[2].Value.ToString())
                                                        + long.Parse(dgv손익계산서.Rows[9].Cells[2].Value.ToString());
                                                        

                //상품매출원가
                dgv손익계산서.Rows[4].Cells[2].Value = long.Parse(dgv손익계산서.Rows[5].Cells[2].Value.ToString())
                                                        + long.Parse(dgv손익계산서.Rows[6].Cells[2].Value.ToString())
                                                        + long.Parse(dgv손익계산서.Rows[7].Cells[2].Value.ToString())
                                                        + long.Parse(dgv손익계산서.Rows[8].Cells[2].Value.ToString());

                //제품매출원가
                dgv손익계산서.Rows[9].Cells[2].Value = long.Parse(dgv손익계산서.Rows[10].Cells[2].Value.ToString())
                                                      + long.Parse(dgv손익계산서.Rows[11].Cells[2].Value.ToString())
                                                      + long.Parse(dgv손익계산서.Rows[12].Cells[2].Value.ToString())
                                                      + long.Parse(dgv손익계산서.Rows[13].Cells[2].Value.ToString());


                //매출총이익
                dgv손익계산서.Rows[14].Cells[2].Value = long.Parse(dgv손익계산서.Rows[0].Cells[2].Value.ToString())
                                                      - long.Parse(dgv손익계산서.Rows[3].Cells[2].Value.ToString());

                //판매관리비
                dgv손익계산서.Rows[15].Cells[2].Value = long.Parse(dgv손익계산서.Rows[16].Cells[1].Value.ToString())
                                                      + long.Parse(dgv손익계산서.Rows[17].Cells[1].Value.ToString())
                                                      + long.Parse(dgv손익계산서.Rows[18].Cells[1].Value.ToString())
                                                      + long.Parse(dgv손익계산서.Rows[19].Cells[1].Value.ToString())
                                                      + long.Parse(dgv손익계산서.Rows[20].Cells[1].Value.ToString())
                                                      + long.Parse(dgv손익계산서.Rows[21].Cells[1].Value.ToString())
                                                      + long.Parse(dgv손익계산서.Rows[22].Cells[1].Value.ToString())
                                                      + long.Parse(dgv손익계산서.Rows[23].Cells[1].Value.ToString())
                                                      + long.Parse(dgv손익계산서.Rows[24].Cells[1].Value.ToString())
                                                      + long.Parse(dgv손익계산서.Rows[25].Cells[1].Value.ToString())
                                                      + long.Parse(dgv손익계산서.Rows[26].Cells[1].Value.ToString())
                                                      + long.Parse(dgv손익계산서.Rows[27].Cells[1].Value.ToString())
                                                      + long.Parse(dgv손익계산서.Rows[28].Cells[1].Value.ToString())
                                                      + long.Parse(dgv손익계산서.Rows[29].Cells[1].Value.ToString())
                                                      + long.Parse(dgv손익계산서.Rows[30].Cells[1].Value.ToString());

                //영업이익
                dgv손익계산서.Rows[31].Cells[2].Value = long.Parse(dgv손익계산서.Rows[14].Cells[2].Value.ToString())
                                                      - long.Parse(dgv손익계산서.Rows[15].Cells[2].Value.ToString());

                //영업외비용
                dgv손익계산서.Rows[33].Cells[2].Value = long.Parse(dgv손익계산서.Rows[34].Cells[1].Value.ToString())
                                                      + long.Parse(dgv손익계산서.Rows[35].Cells[1].Value.ToString());

                //법인세 차감전순이익
                dgv손익계산서.Rows[36].Cells[2].Value = long.Parse(dgv손익계산서.Rows[31].Cells[2].Value.ToString())
                                                      + long.Parse(dgv손익계산서.Rows[32].Cells[2].Value.ToString())
                                                      - long.Parse(dgv손익계산서.Rows[33].Cells[2].Value.ToString());

                //당기순이익
                dgv손익계산서.Rows[38].Cells[2].Value = long.Parse(dgv손익계산서.Rows[36].Cells[2].Value.ToString())
                                                      - long.Parse(dgv손익계산서.Rows[37].Cells[1].Value.ToString());
                                              
            }
        }


        /// <summary>
        /// 데이터 그리드 뷰 페인트시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void Dgv손익계산서_Paint(object sender, PaintEventArgs e)
        {
            string[] separations = { "당기", "전기" };

            dgv손익계산서.MergeHeaderCell(e, separations[0], 1, 3);
            dgv손익계산서.MergeHeaderCell(e, separations[1], 3, 5);
            dgv손익계산서.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv손익계산서.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Dgv손익계산서_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgv손익계산서.RowCount - 1; i++)
            {
                string comparer = dgv손익계산서.Rows[i].Cells[0].Value.ToString();

                if (comparer.StartsWith("1") || comparer.StartsWith("2") || comparer.StartsWith("3") || comparer.StartsWith("4") || comparer.StartsWith("5") || comparer.StartsWith("6"))
                {
                    dgv손익계산서.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                    dgv손익계산서.Rows[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
                else
                {
                    dgv손익계산서.Rows[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }

        /// <summary>
        /// 데이터 그리드 뷰 컬럼 너비 변경시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void Dgv손익계산서_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Rectangle rtHeader = dgv손익계산서.DisplayRectangle;
            rtHeader.Height = dgv손익계산서.ColumnHeadersHeight / 2;
            dgv손익계산서.Invalidate(rtHeader);
        }

        /// <summary>
        /// 데이터 그리드 뷰 스크롤시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void Dgv손익계산서_Scroll(object sender, ScrollEventArgs e)
        {
            Rectangle rtHeader = dgv손익계산서.DisplayRectangle;
            rtHeader.Height = dgv손익계산서.ColumnHeadersHeight / 2;
            dgv손익계산서.Invalidate(rtHeader);
        }

        /// <summary>
        /// 데이터 그리드 뷰 셀 페인트시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void Dgv손익계산서_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void 손익계산서_Load(object sender, EventArgs e)
        {
            사업장등록BindingSource.DataSource = DB.사업장.GetAll();

            if (cbb사업장코드.SelectedValue != null)
                txb사업장명.Text = DB.사업장.Search(cbb사업장코드.Text);
        }

        private void Dgv손익계산서_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv손익계산서.Columns[1].DefaultCellStyle.Format = "##,##";
            dgv손익계산서.Columns[2].DefaultCellStyle.Format = "##,##";
            dgv손익계산서.Columns[3].DefaultCellStyle.Format = "##,##";
            dgv손익계산서.Columns[4].DefaultCellStyle.Format = "##,##";
        }

        private void Dgv손익계산서_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                return;
                //MessageBox.Show("error.");
            }
        }

        private void Cbb금액구분_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
