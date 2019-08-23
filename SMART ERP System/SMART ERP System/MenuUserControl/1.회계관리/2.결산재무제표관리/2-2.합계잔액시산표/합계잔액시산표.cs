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
            dgv합계잔액시산표.AutoGenerateColumns = false;

            for (int j = 0; j < dgv합계잔액시산표.ColumnCount; j++)
            {
                dgv합계잔액시산표.Columns[j].Width = 203;
                if (j != 2)
                {
                    dgv합계잔액시산표.Columns[j].DefaultCellStyle.Format = "###,###,##0";
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
               합계잔액시산표BindingSource.DataSource = DB.합계잔액시산표.GetAll().Where(x => x.기간 == dtp입력날짜.Value).ToList();

                string comparer;
                long? left = 0;
                long? right = 0;
                long leftTotal = 0;
                long rightTotal = 0;
                var list = DB.전표리스트.SearchPeriod(dtp입력날짜.Value);

                for (int i = 0; i < dgv합계잔액시산표.RowCount; i++)
                {
                    comparer = dgv합계잔액시산표.Rows[i].Cells[2].Value.ToString();

                    if (i < 39)
                    {
                       left = list.Where(x => x.계정과목명.Replace(" ", "") == comparer.Replace(" ", "")).Sum(x => x.차변);

                        if (left != 0)
                        {
                            dgv합계잔액시산표.Rows[i].Cells[1].Value = left;
                            leftTotal += long.Parse(dgv합계잔액시산표.Rows[i].Cells[1].Value.ToString());
                        }
                    }
                    else
                    {
                        right = list.Where(x => x.계정과목명.Replace(" ", "") == comparer.Replace(" ", "")).Sum(x => x.대변);

                        if (right != 0)
                        {
                            dgv합계잔액시산표.Rows[i].Cells[3].Value = right;
                            rightTotal += long.Parse(dgv합계잔액시산표.Rows[i].Cells[3].Value.ToString());
                        }
                    }
                }

                txb차변합계총액.Text = leftTotal.ToString("###,##0");
                txb대변합계총액.Text = rightTotal.ToString("###,##0");
            }
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
