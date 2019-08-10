using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using SMART_ERP_System.Class;
using System.Runtime.InteropServices;

namespace SMART_ERP_System.MenuUserControl
{
    public partial class 전표등록 : UserControl
    {
        InputDate input;
        int 전표Index;
        int 전표rowCnt;
        int 전표리스트Index;
        int 전표리스트ColumnCnt;

        public 전표등록()
        {
            InitializeComponent();

            lbl회계년도.Text = DateTime.Now.Year.ToString();
            SetControlMenus();
            전표rowCnt = dgv전표.RowCount;
        }

        // 콤보박스에 월의 데이터를 넣음
        private void SetControlMenus()
        {
            MenuLists.Set();

            cbb월.DataSource = MenuLists.Month;
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
                    input = new InputDate();

                    input.Year = int.Parse(lbl회계년도.Text);
                    input.Month = int.Parse(cbb월.Text);
                    input.Day = int.Parse(txb일.Text);
                    input.Date = new DateTime(year, month, day);

                    dgv전표.Focus();
                    전표Index = dgv전표.CurrentRow.Index;
                    dgv전표.CurrentCell = dgv전표.Rows[전표Index].Cells[2];
                }
                else
                {
                    return;
                }
            }
        }

        // 연, 월, 일의 해당 날짜가 아닌 경우 해당 월의 마지막날로 입력됨
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
                return false;
            }

            return true;
        }

        // Enter 입력시 다음 셀로 이동, 4번째 셀에서 Dgv전표리스트로 이동
        // 마지막 셀에서 다음행 추가 -> 데이터가 모두 입력되면 행 추가로 변경해야함
        private void Dgv전표_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                int column = dgv전표.CurrentCell.ColumnIndex;
                int row = dgv전표.CurrentCell.RowIndex;
                전표Index = dgv전표.CurrentRow.Index;

                if (column == 4)
                {
                    dgv전표리스트.Focus();
                    dgv전표리스트.Rows.Add();
                    dgv전표리스트.CurrentCell = dgv전표리스트.Rows[0].Cells[1];
                }
                else if (column == (dgv전표.Columns.Count - 1))
                {
                    if ((dgv전표.Rows.Count - 1 == row) && (dgv전표.Rows[전표Index].Cells[dgv전표.Columns.Count - 1].Value != null))
                    {
                        dgv전표.Rows.Add();
                        전표rowCnt = dgv전표.RowCount;
                        dgv전표.CurrentCell = dgv전표[0, row + 1];
                    }
                }                
                else
                {
                    dgv전표.CurrentCell = dgv전표[column + 1, row];
                }
            }
        }

        // Dgv전표 - 현재 행의 4번째 셀에 아래 메뉴에서 아이템 클릭
        // Enter키 입력 이벤트 발생
        [DllImport("User32.dll")]
        public static extern void keybd_event(uint vk, uint scan, uint flags, uint extraInfo);
        private void Dgv전표_TypeMenuClick(object obj, EventArgs e)
        {
            if (dgv전표.CurrentCell != dgv전표.Rows[전표Index].Cells[4])
                return;

            MenuItem menuItem = (MenuItem)obj;
            string str = menuItem.Text;

            foreach (string item in MenuLists.menuItems)
            {
                if (item == str)
                {
                    dgv전표.Rows[전표Index].Cells[4].Value = str;

                    // VK_RETURN 0x0D : EnterKey
                    keybd_event((byte)Keys.Enter, 0x0D, 0x02, 0); // Up
                    keybd_event((byte)Keys.Enter, 0x0D, 0x00, 0); // Down
                }
            }
        }

        // Dgv전표 - 현재 행의 4번째 셀에 들어가면 Context메뉴 팝업
        private void Dgv전표_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv전표.CurrentCell.ColumnIndex == 4)
            {
                var cellRectangle = dgv전표.GetCellDisplayRectangle(4, 전표Index, true);

                EventHandler eventHandler = new EventHandler(Dgv전표_TypeMenuClick);

                MenuItem[] items =
                {
                    new MenuItem("일반", eventHandler),
                    new MenuItem("매입", eventHandler),
                    new MenuItem("매출", eventHandler),
                    new MenuItem("수금", eventHandler),
                    new MenuItem("수정", eventHandler),
                    new MenuItem("결산", eventHandler)
                };

                ContextMenu = new ContextMenu(items);
                ContextMenu.Show(dgv전표, new Point(cellRectangle.Left, cellRectangle.Bottom));
            }
        }

        // 일자가 변경되면 모든 Dgv리스트 행 초기화
        private void Txb일_TextChanged(object sender, EventArgs e)
        {
            dgv전표.Rows.Clear();
            dgv전표리스트.Rows.Clear();
        }

        // Enter 입력시 다음 셀로 이동, 마지막 셀에서 데이터가 없으면 개행추가 금지
        // ESC 입력시 Dgv전표의 2번 셀로 이동 후 입력된 데이터를 DB에 Insert
        private void Dgv전표리스트_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                int column = dgv전표리스트.CurrentCell.ColumnIndex;
                int row = dgv전표리스트.CurrentCell.RowIndex;
                전표리스트Index = dgv전표리스트.CurrentRow.Index;
                전표리스트ColumnCnt = dgv전표리스트.Columns.Count;

                if (column == (전표리스트ColumnCnt - 1))
                {
                    if ((dgv전표리스트.Rows.Count - 1 == row) && (dgv전표리스트.Rows[전표리스트Index].Cells[전표리스트ColumnCnt - 1].Value != null))
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
                int i = 1;
                int rowCnt = dgv전표리스트.RowCount;

                //dgv전표.Rows[전표Index].Cells[1].Value = $"{txb일.Text}";

                if (dgv전표.Rows.Count == 전표rowCnt)
                    dgv전표.Rows[전표Index].Cells[2].Value = $"0000{전표rowCnt}";

                dgv전표.Rows[전표Index].Cells[5].Value
                    = $"{input.Date.ToString("yyyyMMdd")}" + "-" + $"0000{i++}";

                dgv전표.Rows[전표Index].Cells[6].Value = "승인";
                dgv전표.Rows[전표Index].Cells[7].Value = loginMember.EmployeeName;
                dgv전표.Rows[전표Index].Cells[9].Value = loginMember.EmployeeName;

                for (int j = 0; j < rowCnt; j++)
                {
                    for (int k = 0; k < dgv전표리스트.Rows[j].Cells.Count; k++)
                    {
                        if (dgv전표리스트.Rows[j].Cells[k].Value == null)
                        {
                            dgv전표.CurrentCell = dgv전표.Rows[전표Index].Cells[2];
                            dgv전표.Focus();

                            if (dgv전표.Rows[전표Index].Cells[dgv전표.Columns.Count - 1].Value != null)
                                dgv전표.Rows.Add();
                                                            
                            return;
                        }
                    }
                }

                List<전표리스트> 전표리스트s = new List<전표리스트>();

                전표 전표 = new 전표();
                전표.입력날짜 = input.Date;
                전표.전표번호 = int.Parse(dgv전표.Rows[전표Index].Cells[1].Value.ToString());
                전표.품의내역 = dgv전표.Rows[전표Index].Cells[1].Value.ToString();
                전표.유형 = dgv전표.Rows[전표Index].Cells[4].Value.ToString();
                전표.기표번호 = dgv전표.Rows[전표Index].Cells[5].Value.ToString();
                전표.승인상태 = dgv전표.Rows[전표Index].Cells[6].Value.ToString();
                전표.승인자 = dgv전표.Rows[전표Index].Cells[7].Value.ToString();
                if (dgv전표.Rows[전표Index].Cells[8].Value != null)
                    전표.대차차액 = int.Parse(dgv전표.Rows[전표Index].Cells[8].Value.ToString());
                전표.작업자 = dgv전표.Rows[전표Index].Cells[9].Value.ToString();

                for (int j = 0; j < rowCnt; j++)
                {
                    전표리스트s.Add(new 전표리스트()
                    {
                        전표리스트ID = int.Parse(dgv전표리스트.Rows[j].Cells[0].Value.ToString()),
                        구분 = dgv전표리스트.Rows[j].Cells[1].Value.ToString(),
                        계정과목코드번호 = int.Parse(dgv전표리스트.Rows[j].Cells[2].Value.ToString()),
                        거래처코드번호 = dgv전표리스트.Rows[j].Cells[4].Value.ToString(),
                        금액 = int.Parse(dgv전표리스트.Rows[j].Cells[7].Value.ToString()),
                        적요명 = dgv전표리스트.Rows[j].Cells[8].Value.ToString(),
                        입력날짜 = input.Date,
                        전표번호 = 전표.전표번호
                    });
                }

                //전표리스트 전표리스트 = new 전표리스트();
                //전표리스트.전표리스트ID = int.Parse(dgv전표리스트.CurrentRow.Cells[0].Value.ToString());

                //전표리스트.구분 = dgv전표리스트.CurrentRow.Cells[1].Value.ToString();
                //전표리스트.계정과목코드번호 = int.Parse(dgv전표리스트.CurrentRow.Cells[2].Value.ToString());

                //if (dgv전표리스트.CurrentRow.Cells[4].Value != null)
                //    전표리스트.거래처코드번호 = dgv전표리스트.CurrentRow.Cells[4].Value.ToString();
                //전표리스트.금액 = int.Parse(dgv전표리스트.CurrentRow.Cells[7].Value.ToString());
                //전표리스트.적요명 = dgv전표리스트.CurrentRow.Cells[8].Value.ToString();

                dgv전표.Focus();
                dgv전표.CurrentCell = dgv전표.Rows[전표Index].Cells[2];
                // DB.전표.Insert(전표);
                // DB.전표리스트.Insert(전표리스트);
            }
        }

        // 행 추가시 자동으로 일자 입력됨
        private void Dgv전표_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv전표.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv전표.Rows[e.RowIndex].Cells[1].Value = txb일.Text;
        }
    }
}
