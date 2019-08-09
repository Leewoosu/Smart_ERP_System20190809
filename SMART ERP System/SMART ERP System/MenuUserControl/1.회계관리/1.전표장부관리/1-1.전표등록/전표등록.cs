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
    public partial class 전표등록 : UserControl
    {
        List<string> Month;
        int 전표Index;
        int 전표리스트Index;

        public 전표등록()
        {
            InitializeComponent();

            lbl회계년도.Text = DateTime.Now.Year.ToString();
            SetCbbMonth();
        }

        // 콤보박스에 월의 데이터를 넣음
        private void SetCbbMonth()
        {
            Month = new List<string>();
            Month.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbb월.DataSource = Month;
        }

        // dgv전표 첫번째 컬럼 헤드 체크박스 넣기
        private void Dgv전표_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex == -1)
            {
                e.PaintBackground(e.ClipBounds, false);

                Point point = e.CellBounds.Location;

                int nCbxWidth = 15;
                int nCbxHeight = 15;
                int offSetX = (e.CellBounds.Width - nCbxWidth) / 2;
                int offSetY = (e.CellBounds.Height - nCbxHeight) / 2;

                point.X += offSetX;
                point.Y += offSetY;

                CheckBox cbx = new CheckBox();
                cbx.Size = new Size(nCbxWidth, nCbxHeight);
                cbx.Location = point;
                cbx.CheckedChanged += new EventHandler(dgv전표_CheckedChanged);

                ((DataGridView)sender).Controls.Add(cbx);

                e.Handled = true;
            }
        }

        // dgv전표 첫번째 컬럼 체크박스 체크변동 함수
        private void dgv전표_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv전표.Rows)
            {
                row.Cells["CheckColumn"].Value = ((CheckBox)sender).Checked;
            }
        }

        // 자동 행번호 매기기
        private void Dgv전표리스트_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv전표리스트.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv전표리스트.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        // 엔터키를 누르면 일자 확인 후 "일"의 열에 일자가 들어감
        private void Txb일_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int month = 0;

                if (cbb월.SelectedItem != null)
                {
                    month = int.Parse(cbb월.SelectedItem.ToString());
                }
                else if (cbb월.Text != null)
                {
                    month = int.Parse(cbb월.Text);
                }
                else
                {
                    return;
                }

                int year = int.Parse(lbl회계년도.Text);
                int day = int.Parse(txb일.Text);

                if (IsDate(year, month, day) == true)
                {
                    dgv전표.Focus();
                    dgv전표.Rows[0].Cells[1].Value = txb일.Text;
                    dgv전표.CurrentCell = dgv전표.Rows[0].Cells[2];
                }
                else
                {
                    return;
                }
            }
        }

        /// <summary>
        /// 연, 월, 일의 해당 날짜가 아닌 경우 해당 월의 마지막날로 입력됨
        /// </summary>
        /// <param name="iYear"></param>
        /// <param name="iMonth"></param>
        /// <param name="iDay"></param>
        /// <returns></returns>
        public bool IsDate(int iYear, int iMonth, int iDay)
        {
            if ((DateTime.MinValue.Year > iYear) || (iYear > DateTime.MaxValue.Year))
            {
                return false;
            }

            if ((DateTime.MinValue.Month > iMonth) || (iMonth > DateTime.MaxValue.Month))
            {
                return false;
            }

            int iLastDay = DateTime.DaysInMonth(iYear, iMonth);

            if ((DateTime.MinValue.Day > iDay) || (iDay > iLastDay))
            {
                txb일.Text = iLastDay.ToString();
                dgv전표.Rows[0].Cells[1].Value = iLastDay.ToString();
                return false;
            }

            return true;
        }

        private void Dgv전표_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                int column = dgv전표.CurrentCell.ColumnIndex;
                int row = dgv전표.CurrentCell.RowIndex;

                if (column == (dgv전표.Columns.Count - 1))
                {
                    dgv전표.CurrentCell = dgv전표[0, row + 1];
                }
                else if (column == 4)
                {
                    전표Index = dgv전표.CurrentRow.Index;
                    dgv전표리스트.Focus();
                    dgv전표리스트.Rows.Add();
                    dgv전표리스트.CurrentCell = dgv전표리스트.Rows[0].Cells[1];
                }
                else
                {
                    dgv전표.CurrentCell = dgv전표[column + 1, row];
                }
            }
        }

        private void Txb일_TextChanged(object sender, EventArgs e)
        {
            dgv전표.Rows.Clear();
            dgv전표리스트.Rows.Clear();
        }

        private void Dgv전표리스트_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                int column = dgv전표리스트.CurrentCell.ColumnIndex;
                int row = dgv전표리스트.CurrentCell.RowIndex;
                전표리스트Index = row;

                if (column == (dgv전표리스트.Columns.Count - 1))
                {
                    if ((dgv전표리스트.Rows.Count - 1 == row) && (dgv전표리스트.Rows[전표리스트Index].Cells[dgv전표리스트.Columns.Count - 1].Value != null))
                    {
                        dgv전표리스트.Rows.Add();
                        dgv전표리스트.CurrentCell = dgv전표리스트[0, row + 1];
                    }
                }
                else
                {
                    dgv전표리스트.CurrentCell = dgv전표리스트[column + 1, row];
                }
            }

            if (e.KeyData == Keys.Escape)
            {
                전표리스트 전표리스트 = new 전표리스트();
                전표리스트.전표리스트ID = int.Parse(dgv전표리스트.CurrentRow.Cells[0].Value.ToString());
                전표리스트.구분 = dgv전표리스트.CurrentRow.Cells[1].Value.ToString();
                전표리스트.계정과목코드번호 = int.Parse(dgv전표리스트.CurrentRow.Cells[2].Value.ToString());

                if (dgv전표리스트.CurrentRow.Cells[4].Value != null)
                    전표리스트.거래처코드번호 = dgv전표리스트.CurrentRow.Cells[4].Value.ToString();
                전표리스트.금액 = int.Parse(dgv전표리스트.CurrentRow.Cells[7].Value.ToString());
                전표리스트.적요명 = dgv전표리스트.CurrentRow.Cells[8].Value.ToString();

                dgv전표.Focus();
                dgv전표.CurrentCell = dgv전표.Rows[전표Index].Cells[2];

                int year = int.Parse(lbl회계년도.Text);
                int month = int.Parse(cbb월.Text);
                int day = int.Parse(txb일.Text);
                DateTime dateTime = new DateTime(year, month, day);

                전표 전표 = new 전표();
                전표.입력날짜 = dateTime;
                전표.전표번호 = int.Parse(dgv전표.CurrentRow.Cells[1].Value.ToString());
                전표.품의내역 = dgv전표.CurrentRow.Cells[1].Value.ToString();

                dgv전표.CurrentRow.Cells[5].Value = $"{dateTime}"+"-"+$"000{dgv전표.CurrentRow.Index}";
                dgv전표.CurrentRow.Cells[6].Value = "승인";

                전표.유형 = dgv전표.CurrentRow.Cells[4].Value.ToString();
                전표.기표번호 = dgv전표.CurrentRow.Cells[5].Value.ToString();
                전표.승인상태 = dgv전표.CurrentRow.Cells[6].Value.ToString();
                전표.승인자 = loginMember.Name;
                전표.작업자 = loginMember.Name;
                
                // DB.전표.Insert(전표);
                // DB.전표리스트.Insert(전표리스트);
            }
        }
    }
}
