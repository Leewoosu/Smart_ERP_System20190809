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
using ClassLibrary.FormHelper;

namespace SMART_ERP_System.MenuUserControl
{
    public partial class 재무상태표 : UserControl
    {
        public 재무상태표()
        {
            InitializeComponent();
            SetDataGridView();
        }

        private void SetDataGridView()
        {
            dgv재무상태표.AutoGenerateColumns = false;

            for (int j = 0; j < dgv재무상태표.ColumnCount; j++)
            {
                dgv재무상태표.Columns[j].Width = 203;
            }

            dgv재무상태표.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv재무상태표.ColumnHeadersHeight = dgv재무상태표.ColumnHeadersHeight * 2;
            dgv재무상태표.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        private void Dtp입력날짜_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                재무상태표BindingSource.DataSource = DB.재무상태표.GetAll().Where(x => x.기간.ToShortDateString() == dtp입력날짜.Value.ToShortDateString()).ToList();
            }
        }

        /// <summary>
        /// 데이터 그리드 뷰 페인트시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void Dgv재무상태표_Paint(object sender, PaintEventArgs e)
        {
            string[] separations = { "당기", "전기" };

            dgv재무상태표.MergeHeaderCell(e, separations[0], 1, 3);
            dgv재무상태표.MergeHeaderCell(e, separations[1], 3, 5);
            dgv재무상태표.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv재무상태표.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Dgv재무상태표_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgv재무상태표.RowCount - 1; i++)
            {
                string comparer = dgv재무상태표.Rows[i].Cells[0].Value.ToString();

                if (comparer.StartsWith("["))
                {
                    dgv재무상태표.Rows[i].DefaultCellStyle.BackColor = Color.LightCyan;
                    dgv재무상태표.Rows[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
                else if (comparer.StartsWith("(") || comparer.StartsWith("1") || comparer.StartsWith("2") || comparer.StartsWith("3") || comparer.StartsWith("4") || comparer.StartsWith("5"))
                {
                    dgv재무상태표.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                    dgv재무상태표.Rows[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
                else
                {
                    dgv재무상태표.Rows[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }

        /// <summary>
        /// 데이터 그리드 뷰 컬럼 너비 변경시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void Dgv재무상태표_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Rectangle rtHeader = dgv재무상태표.DisplayRectangle;
            rtHeader.Height = dgv재무상태표.ColumnHeadersHeight / 2;
            dgv재무상태표.Invalidate(rtHeader);
        }

        /// <summary>
        /// 데이터 그리드 뷰 스크롤시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void Dgv재무상태표_Scroll(object sender, ScrollEventArgs e)
        {
            Rectangle rtHeader = dgv재무상태표.DisplayRectangle;
            rtHeader.Height = dgv재무상태표.ColumnHeadersHeight / 2;
            dgv재무상태표.Invalidate(rtHeader);
        }

        /// <summary>
        /// 데이터 그리드 뷰 셀 페인트시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void Dgv재무상태표_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void 재무상태표_Load(object sender, EventArgs e)
        {
            회사등록BindingSource.DataSource = DB.회사.GetAll();

            if (cbb회사코드.SelectedValue != null)
                txb회사명.Text = DB.회사.Search(cbb회사코드.Text);
        }
    }
}
