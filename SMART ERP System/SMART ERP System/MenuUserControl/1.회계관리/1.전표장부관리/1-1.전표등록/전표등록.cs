using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using SMART_ERP_System.Class;
using System.Runtime.InteropServices;
using ClassLibrary.EntityData;

namespace SMART_ERP_System.MenuUserControl
{
    public partial class 전표등록 : UserControl
    {
        InputDate input;
        bool toggle = false;

        public 전표등록()
        {
            InitializeComponent();

            lbl회계년도.Text = DateTime.Now.Year.ToString();
            SetControlMenus();
        }

        // 콤보박스에 월의 데이터를 넣음
        private void SetControlMenus()
        {
            MenuLists.Set();
            cbb월.DataSource = MenuLists.Month;
        }

        #region Dgv전표 Events
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
                cbx.CheckedChanged += new EventHandler(Dgv전표_CheckedChanged);

                ((DataGridView)sender).Controls.Add(cbx);

                e.Handled = true;
            }
        }

        // Dgv전표 첫번째 컬럼 체크박스 체크변동 함수
        private void Dgv전표_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv전표.Rows)
            {
                row.Cells["CheckColumn"].Value = ((CheckBox)sender).Checked;
            }
        }

        // Enter 입력시 다음 셀로 이동, 4번째 셀에서 Dgv전표리스트로 이동
        // 마지막 셀에서 다음행 추가 -> 데이터가 모두 입력되면 행 추가로 변경해야함
        private void Dgv전표_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                전표단위.ColumnIndex = dgv전표.CurrentCell.ColumnIndex;
                전표단위.RowIndex = dgv전표.CurrentCell.RowIndex;
                전표단위.Index = dgv전표.CurrentRow.Index;
                전표단위.ColumnCnt = dgv전표.Columns.Count;

                if (전표단위.ColumnIndex == 4)
                {
                    dgv전표리스트.Focus();
                    dgv전표리스트.Rows.Add();
                    dgv전표리스트.CurrentCell = dgv전표리스트.Rows[0].Cells[1];
                }
                else if (전표단위.ColumnIndex == (전표단위.ColumnCnt - 1))
                {
                    if ((dgv전표.Rows.Count - 1 == 전표단위.RowIndex) && (dgv전표.Rows[전표단위.Index].Cells[전표단위.ColumnCnt - 1].Value != null))
                    {
                        dgv전표.Rows.Add();
                        전표단위.RowCnt = dgv전표.RowCount;
                        dgv전표.CurrentCell = dgv전표[0, 전표단위.RowIndex + 1];
                    }
                    else if (dgv전표.Rows[전표단위.Index].Cells[전표단위.ColumnCnt - 1].Value != null)
                    {
                        dgv전표.CurrentCell = dgv전표[2, 전표단위.RowIndex + 1];
                    }
                }
                else
                {
                    dgv전표.CurrentCell = dgv전표[전표단위.ColumnIndex + 1, 전표단위.RowIndex];
                }
            }
        }

        // Dgv전표 - 현재 행의 4번째 셀에 아래 메뉴에서 아이템 클릭
        // Enter키 입력 이벤트 발생
        [DllImport("User32.dll")]
        public static extern void keybd_event(uint vk, uint scan, uint flags, uint extraInfo);
        private void Dgv전표_TypeMenuClick(object obj, EventArgs e)
        {
            전표단위.Index = dgv전표.CurrentRow.Index;

            if (dgv전표.CurrentCell != dgv전표.Rows[전표단위.Index].Cells[4])
                return;

            MenuItem menuItem = (MenuItem)obj;
            string str = menuItem.Text;

            foreach (string item in MenuLists.menuItems)
            {
                if (item == str)
                {
                    dgv전표.Rows[전표단위.Index].Cells[4].Value = str;

                    // VK_RETURN 0x0D : EnterKey
                    keybd_event((byte)Keys.Enter, 0x0D, 0x01, 0);
                }
            }
        }

        // Dgv전표 - 현재 행의 4번째 셀에 들어가면 Context메뉴 팝업
        private void Dgv전표_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            전표단위.Index = dgv전표.CurrentRow.Index;
            전표단위.ColumnIndex = dgv전표.CurrentCell.ColumnIndex;

            if (전표단위.ColumnIndex == 2 || 전표단위.ColumnIndex == 3)
            {
                if ((dgv전표.Rows[전표단위.Index].Cells[2].Value != null) || (dgv전표.Rows[전표단위.Index].Cells[3].Value != null))
                {
                    List<전표리스트> list = DB.전표리스트.SearchList(dgv전표.Rows[전표단위.Index].Cells[2].Value);

                    if (list != null)
                    {

                        if (toggle == false)
                        {
                            dgv전표리스트.Rows.Add(list.Count);
                            toggle = true;
                        }
                    }
                    else
                        return;

                    전표리스트단위.ColumnCnt = dgv전표리스트.Columns.Count;
                    전표리스트단위.RowCnt = dgv전표리스트.Rows.Count;

                    for (int i = 0; i < list.Count; i++)
                    {
                        dgv전표리스트.Rows[i].Cells[0].Value = list[i].순번;
                        dgv전표리스트.Rows[i].Cells[1].Value = list[i].구분;

                        dgv전표리스트.Rows[i].Cells[2].Value = list[i].계정과목코드번호;
                        string accountName = DB.계정과목.SearchAccountCode(list[i].계정과목코드번호);
                        dgv전표리스트.Rows[i].Cells[3].Value = accountName;

                        if (list[i].거래처코드번호 != null)
                        {
                            dgv전표리스트.Rows[i].Cells[4].Value = list[i].거래처코드번호;

                            DB.거래처.Search(list[i].거래처코드번호, out string name, out string number);
                            dgv전표리스트.Rows[i].Cells[5].Value = name;
                            dgv전표리스트.Rows[i].Cells[6].Value = number;
                        }
                        dgv전표리스트.Rows[i].Cells[7].Value = list[i].금액;
                        dgv전표리스트.Rows[i].Cells[8].Value = list[i].적요명;
                    }
                }
                else
                {
                    dgv전표리스트.Rows.Clear();
                }
            }

            if (dgv전표.CurrentCell.ColumnIndex == 4)
            {
                // 첫번째 컨텍스트 메뉴에 위치
                keybd_event((byte)Keys.Down, 0x28, 0x01, 0); // DownUp

                var cellRectangle = dgv전표.GetCellDisplayRectangle(4, 전표단위.Index, true);

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
            else
            {
                if (ContextMenu != null)
                    ContextMenu.Dispose();
            }
        }

        // 행 추가시 자동으로 일자 입력됨
        private void Dgv전표_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv전표.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv전표.Rows[e.RowIndex].Cells[1].Value = txb일.Text;
        }
        #endregion

        #region Dgv전표리스트 Events
        // 자동 행번호 매기기
        private void Dgv전표리스트_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv전표리스트.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv전표리스트.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        // Enter 입력시 다음 셀로 이동, 마지막 셀에서 데이터가 없으면 개행추가 금지
        // ESC 입력시 Dgv전표의 2번 셀로 이동 후 입력된 데이터를 DB에 Insert
        private void Dgv전표리스트_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                전표리스트단위.ColumnIndex = dgv전표리스트.CurrentCell.ColumnIndex;
                전표리스트단위.RowIndex = dgv전표리스트.CurrentCell.RowIndex;
                전표리스트단위.Index = dgv전표리스트.CurrentRow.Index;
                전표리스트단위.ColumnCnt = dgv전표리스트.Columns.Count;

                if (전표리스트단위.ColumnIndex == (전표리스트단위.ColumnCnt - 1))
                {
                    if ((dgv전표리스트.Rows.Count - 1 == 전표리스트단위.RowIndex) && (dgv전표리스트.Rows[전표리스트단위.Index].Cells[전표리스트단위.ColumnCnt - 1].Value != null))
                    {
                        dgv전표리스트.Rows.Add();
                    }
                    else if (dgv전표리스트.Rows[전표리스트단위.Index].Cells[전표리스트단위.ColumnCnt - 1].Value != null)
                    {
                        dgv전표리스트.CurrentCell = dgv전표리스트[0, 전표리스트단위.RowIndex + 1];
                    }
                }
                else
                {
                    dgv전표리스트.CurrentCell = dgv전표리스트[전표리스트단위.ColumnIndex + 1, 전표리스트단위.RowIndex];
                }
            }

            if (e.KeyData == Keys.Escape)
            {
                전표리스트단위.RowCnt = dgv전표리스트.Rows.Count;
                전표리스트단위.ColumnCnt = dgv전표리스트.Columns.Count;
                List<전표리스트> 전표리스트s = new List<전표리스트>();
                전표 전표 = new 전표();

                if (dgv전표리스트.Rows[전표리스트단위.RowIndex].Cells[1].Value == null)
                {
                    dgv전표.Rows[전표단위.Index].Cells[2].Value = $"0000{전표단위.Index + 1}";
                    dgv전표.Rows[전표단위.Index].Cells[5].Value
                        = $"{input.Date.ToString("yyyyMMdd")}" + "-" + $"0000{전표단위.Index + 1}";

                    dgv전표.Rows[전표단위.Index].Cells[6].Value = "승인대기";
                    dgv전표.Rows[전표단위.Index].Cells[7].Value = loginMember.EmployeeName;
                    dgv전표.Rows[전표단위.Index].Cells[9].Value = loginMember.EmployeeName;
                }


                for (int j = 0; j < 전표리스트단위.RowCnt - 1; j++)
                {
                    if (dgv전표리스트.Rows[j].Cells[전표리스트단위.ColumnCnt - 1].Value != null)
                    {
                        전표리스트 list = new 전표리스트();

                        if (dgv전표리스트.Rows[j].Cells[0].Value != null)
                            list.순번 = int.Parse(dgv전표리스트.Rows[j].Cells[0].Value.ToString());

                        if (dgv전표리스트.Rows[j].Cells[1].Value != null)
                            list.구분 = dgv전표리스트.Rows[j].Cells[1].Value.ToString();

                        if (dgv전표리스트.Rows[j].Cells[2].Value != null)
                            list.계정과목코드번호 = dgv전표리스트.Rows[j].Cells[2].Value.ToString();

                        if (dgv전표리스트.Rows[j].Cells[4].Value != null)
                            list.거래처코드번호 = dgv전표리스트.Rows[j].Cells[4].Value.ToString();

                        if (dgv전표리스트.Rows[j].Cells[7].Value != null)
                            list.금액 = int.Parse(dgv전표리스트.Rows[j].Cells[7].Value.ToString());

                        if (dgv전표리스트.Rows[j].Cells[8].Value != null)
                            list.적요명 = dgv전표리스트.Rows[j].Cells[8].Value.ToString();
                        list.입력날짜 = input.Date;
                        list.전표번호 = 전표.전표번호;

                        전표리스트s.Add(list);
                    }
                }

                전표.입력날짜 = input.Date;
                전표.전표번호 = dgv전표.Rows[전표단위.Index].Cells[2].Value.ToString();
                전표.품의내역 = dgv전표.Rows[전표단위.Index].Cells[3].Value.ToString();
                전표.유형 = dgv전표.Rows[전표단위.Index].Cells[4].Value.ToString();
                전표.기표번호 = dgv전표.Rows[전표단위.Index].Cells[5].Value.ToString();
                전표.승인상태 = dgv전표.Rows[전표단위.Index].Cells[6].Value.ToString();
                전표.승인자 = dgv전표.Rows[전표단위.Index].Cells[7].Value.ToString();
                if (dgv전표.Rows[전표단위.Index].Cells[8].Value != null)
                    전표.대차차액 = int.Parse(dgv전표.Rows[전표단위.Index].Cells[8].Value.ToString());
                전표.작업자 = dgv전표.Rows[전표단위.Index].Cells[9].Value.ToString();

                dgv전표.CurrentCell = dgv전표.Rows[전표단위.Index].Cells[2];
                dgv전표.Focus();

                if ((dgv전표.Rows.Count - 1 == 전표단위.RowIndex) && (dgv전표.Rows[전표단위.Index].Cells[전표단위.ColumnCnt - 1].Value != null))
                {
                    dgv전표.Rows.Add();
                }
            }
        }    
    #endregion

    #region Txb일 Events
    // 엔터키를 누르면 일자 확인 후 "일"의 열에 일자가 들어감
    private void Txb일_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            input = new InputDate();

            if (cbb월.SelectedItem != null)
            {
                input.Month = int.Parse(cbb월.SelectedItem.ToString());
            }
            else if (cbb월.Text != null)
            {
                input.Month = int.Parse(cbb월.Text);
            }
            else
            {
                return;
            }

            input.Year = int.Parse(lbl회계년도.Text);
            input.Day = int.Parse(txb일.Text);
            input.Date = new DateTime(input.Year, input.Month, input.Day);

            if (input.IsDate(input.Year, input.Month, input.Day) == true)
            {
                if (input.DayText == null)
                    txb일.Text = input.Day.ToString();
                else
                    txb일.Text = input.DayText;

                List<전표> list = DB.전표.GetAllMatchedDay(input.Date);
                if (list != null)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        dgv전표.Rows.Add();
                        dgv전표.Rows[i].Cells[1].Value = list[i].입력날짜.Day;
                        dgv전표.Rows[i].Cells[2].Value = list[i].전표번호;
                        dgv전표.Rows[i].Cells[3].Value = list[i].품의내역;
                        dgv전표.Rows[i].Cells[4].Value = list[i].유형;
                        dgv전표.Rows[i].Cells[5].Value = list[i].기표번호;
                        dgv전표.Rows[i].Cells[6].Value = list[i].승인상태;
                        dgv전표.Rows[i].Cells[7].Value = list[i].승인자;
                        if (list[i].대차차액 != null)
                            dgv전표.Rows[i].Cells[8].Value = list[i].대차차액;
                        dgv전표.Rows[i].Cells[9].Value = list[i].작업자;
                    }
                }

                dgv전표.Focus();
                dgv전표.Rows.Add();
                전표단위.Index = dgv전표.CurrentRow.Index;
                전표단위.RowCnt = dgv전표.RowCount;
                dgv전표.CurrentCell = dgv전표.Rows[전표단위.Index].Cells[2];
            }
            else
            {
                return;
            }
        }
    }

    // 일자가 변경되면 모든 Dgv리스트 행 초기화
    private void Txb일_TextChanged(object sender, EventArgs e)
    {
        dgv전표.Rows.Clear();
        dgv전표리스트.Rows.Clear();
    }
    #endregion
}
}
