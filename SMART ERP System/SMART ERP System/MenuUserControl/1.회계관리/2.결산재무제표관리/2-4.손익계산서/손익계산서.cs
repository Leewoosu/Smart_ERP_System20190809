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
            if (e.KeyData == Keys.Enter)
            {
                손익계산서BindingSource.DataSource = DB.재무상태표.GetAll().Where(x => x.기간.ToShortDateString() == dtp입력날짜.Value.ToShortDateString()).ToList();
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
            회사등록BindingSource.DataSource = DB.회사.GetAll();

            if (cbb회사코드.SelectedValue != null)
                txb회사명.Text = DB.회사.Search(cbb회사코드.Text);
        }
    }
}
