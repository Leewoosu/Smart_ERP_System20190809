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
using ClassLibrary.FormHelper;
using SMART_ERP_System.MainForm_Control;

namespace SMART_ERP_System.MenuUserControl
{
    public partial class 전표등록 : UserControl
    {
        InputDate input;

        public 전표등록()
        {
            InitializeComponent();

            lbl회계년도.Text = DateTime.Now.Year.ToString();
            SetControlMenus();

            회사등록BindingSource.DataSource = DB.회사.GetAll();
        }

        // 콤보박스에 월의 데이터를 넣음
        private void SetControlMenus()
        {
            MenuLists.Set();
            cbb월.DataSource = MenuLists.month;
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

                if (전표단위.ColumnIndex == (전표단위.ColumnCnt - 1))
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

            if (e.KeyData == Keys.Delete)
            {
                Fill_InAll_LinkedTo전표(out 전표 전표, out List<전표리스트> list);

                if (DialogResult.Yes == MessageBox.Show("선택한 전표을 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo))
                {
                    foreach (전표리스트 전표리스트 in list)
                    {
                        DB.전표리스트.Delete(전표리스트);
                    }

                    DB.전표.Delete(전표);                    
                }
            }
        }

        private void Fill_InAll_LinkedTo전표(out 전표 전표, out List<전표리스트> list)
        {
            전표 = new 전표();

            전표.입력날짜 = input.Date;
            전표.전표번호 = dgv전표.CurrentRow.Cells[2].Value.ToString();
            전표.품의내역 = dgv전표.CurrentRow.Cells[3].Value.ToString();
            전표.유형 = dgv전표.CurrentRow.Cells[4].Value.ToString();
            전표.기표번호 = dgv전표.CurrentRow.Cells[5].Value.ToString();
            전표.승인상태 = dgv전표.CurrentRow.Cells[6].Value.ToString();
            전표.승인자 = dgv전표.CurrentRow.Cells[7].Value.ToString();
            if (dgv전표.CurrentRow.Cells[8].Value != null)
                전표.대차차액 = int.Parse(dgv전표.CurrentRow.Cells[8].Value.ToString());
            전표.작업자 = dgv전표.CurrentRow.Cells[9].Value.ToString();

            list = DB.전표리스트.SearchList(전표.입력날짜, 전표.전표번호);
        }

        // Dgv전표 - 현재 행의 4번째 셀에 아래 메뉴에서 아이템 클릭
        // Enter키 입력 이벤트 발생
        [DllImport("User32.dll")]
        public static extern void keybd_event(uint vk, uint scan, uint flags, uint extraInfo);
        private void Dgv전표_TypeMenuClick(object obj, EventArgs e)
        {
            전표단위.Index = dgv전표.CurrentRow.Index;

            if (dgv전표.CurrentCell != dgv전표.CurrentRow.Cells[4])
                return;

            MenuItem menuItem = (MenuItem)obj;
            string str = menuItem.Text;

            foreach (string item in MenuLists.menuItems)
            {
                if (item == str)
                {
                    dgv전표.Rows[전표단위.Index].Cells[4].Value = str;
                    dgv전표리스트.Rows.Add();
                    dgv전표리스트.CurrentCell = dgv전표리스트.Rows[0].Cells[1];
                    dgv전표리스트.Focus();
                }
            }
        }

        // Dgv전표 - 현재 행의 4번째 셀에 들어가면 Context메뉴 팝업
        private void Dgv전표_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            전표단위.Index = dgv전표.CurrentRow.Index;
            전표단위.ColumnIndex = dgv전표.CurrentCell.ColumnIndex;
            전표단위.RowIndex = dgv전표.CurrentCell.RowIndex;

            if ((dgv전표.Rows[전표단위.RowIndex].Cells[2].Value != null))
            {
                List<전표리스트> list = DB.전표리스트.SearchList(input.Date, dgv전표.Rows[전표단위.RowIndex].Cells[2].Value.ToString());
                전표리스트단위.LoadCnt = list.Count - 1;

                if (list.Count > 0)
                {
                    dgv전표리스트.Rows.Clear();
                    dgv전표리스트.Rows.Add(list.Count);
                }
                else
                {
                    dgv전표리스트.Rows.Clear();
                    return;
                }

                전표리스트단위.ColumnCnt = dgv전표리스트.Columns.Count;
                전표리스트단위.RowCnt = dgv전표리스트.Rows.Count;

                for (int i = 0; i < list.Count; i++)
                {
                    dgv전표리스트.Rows[i].Cells[0].Value = list[i].순번;
                    dgv전표리스트.Rows[i].Cells[1].Value = list[i].구분;

                    dgv전표리스트.Rows[i].Cells[2].Value = list[i].계정과목코드번호;
                    dgv전표리스트.Rows[i].Cells[3].Value = DB.계정과목.SearchAccountName(list[i].계정과목코드번호);

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
                txb차변합계.Clear();
                txb대변합계.Clear();
            }

            if (e.ColumnIndex == 4)
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
            for (int i = 1; i <= 2; i++)
            {
                dgv전표.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                if (i == 1)
                {
                    dgv전표.Columns[i].ReadOnly = true;
                    dgv전표.Columns[i].DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }

            for (int i = 4; i <= 9; i++)
            {
                dgv전표.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (i > 4)
                {
                    dgv전표.Columns[i].ReadOnly = true;
                    dgv전표.Columns[i].DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
            dgv전표.Rows[e.RowIndex].Cells[1].Value = txb일.Text;
        }
        private void Dgv전표_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9)
            {
                DataGridView view = (DataGridView)sender;
                view.CurrentCell.Selected = false;
            }
        }
        #endregion

        #region Dgv전표리스트 Events
        // 자동 행번호 매기기
        private void Dgv전표리스트_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv전표리스트.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgv전표리스트.Rows[e.RowIndex].Cells[0].Value == null)
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
                전표리스트단위.RowCnt = dgv전표리스트.Rows.Count;

                // 마지막 열 체크
                if (전표리스트단위.ColumnIndex == (전표리스트단위.ColumnCnt - 1))
                {
                    // 마지막 행 체크 및 그 행의 마지막 열에 데이터가 있을 경우 행 추가
                    if ((전표리스트단위.RowCnt - 1 == 전표리스트단위.RowIndex) && (dgv전표리스트.Rows[전표리스트단위.Index].Cells[전표리스트단위.ColumnCnt - 1].Value != null))
                    {
                        dgv전표리스트.Rows.Add();
                    }
                    // 그 행의 마지막 열에 데이터가 있을 경우 행 추가
                    else if (dgv전표리스트.Rows[전표리스트단위.Index].Cells[전표리스트단위.ColumnCnt - 1].Value != null)
                    {
                        dgv전표리스트.CurrentCell = dgv전표리스트[0, 전표리스트단위.RowIndex + 1];
                    }
                }
                // 마지막 열이 아닐 경우 다음 열로 이동
                else
                {
                    dgv전표리스트.CurrentCell = dgv전표리스트[전표리스트단위.ColumnIndex + 1, 전표리스트단위.RowIndex];
                }
            }

            // 전표로 돌아감, Insert, Update
            if (e.KeyData == Keys.Escape)
            {
                e.SuppressKeyPress = true;

                전표단위.RowCnt = dgv전표.RowCount;
                전표리스트단위.RowCnt = dgv전표리스트.RowCount;
                전표리스트단위.Index = dgv전표리스트.CurrentRow.Index;

                List<전표리스트> 전표리스트s = new List<전표리스트>();
                List<전표> 전표s = new List<전표>();
                string number = null;

                List<int> resultIndex1 = new List<int>();
                List<int> resultIndex2 = new List<int>();

                // 불러온 데이터 수가 현재 Dgv전표리스트의 행보다 적으면 기존데이터에 해당
                if (전표리스트단위.LoadCnt > 0)
                {
                    if (dgv전표.Rows[전표단위.Index].Cells[2].Value != null)
                        number = dgv전표.Rows[전표단위.Index].Cells[2].Value.ToString();
                    DB.전표리스트.FillIn전표리스트List(input.Date, dgv전표리스트, 전표리스트s, number, 전표리스트단위.LoadCnt);
                    var listForCheck2 = DB.전표리스트.GetAllMatchedNumber(number);

                    if (listForCheck2.Count == 전표리스트s.Count)
                    {
                        DB.전표리스트.UpdateNonOverlapList(전표리스트s, listForCheck2, 전표리스트단위.LoadCnt, out resultIndex2);
                    }
                }

                // 불러온 데이터 수가 현재 Dgv전표의 행보다 적으면 기존데이터에 해당
                if (전표단위.LoadCnt > 0)
                {
                    DB.전표.FillIn전표List(input.Date, dgv전표, 전표s, 전표단위.LoadCnt);
                    var listForCheck = DB.전표.GetAllMatchedDay(input.Date);

                    if (listForCheck.Count == 전표s.Count)
                    {
                        DB.전표.UpdateNonOverlapList(전표s, listForCheck, 전표단위.LoadCnt, out resultIndex1);
                    }
                }

                // 불러온 데이터 개수보다 현재 행 개수가 더 많으면 추가할 데이터
                if (전표단위.LoadCnt < 전표단위.RowCnt)
                {
                    if (dgv전표.Rows[전표단위.Index].Cells[2].Value == null)
                    {
                        SetDefaultBy전표();

                        for (int i = 전표단위.LoadCnt + 1; i < 전표단위.RowCnt; i++)
                        {
                            Insert전표(i);
                        }

                        for (int i = 전표리스트단위.LoadCnt; i < 전표리스트단위.RowCnt; i++)
                        {
                            if (dgv전표리스트.Rows[전표리스트단위.Index].Cells[0].Value != null)
                            {
                                전표리스트 전표리스트 = new 전표리스트();

                                전표리스트.순번 = int.Parse(dgv전표리스트.Rows[i].Cells[0].Value.ToString());

                                if (dgv전표리스트.Rows[i].Cells[1].Value != null)
                                    전표리스트.구분 = dgv전표리스트.Rows[i].Cells[1].Value.ToString();

                                if (dgv전표리스트.Rows[i].Cells[2].Value != null)
                                    전표리스트.계정과목코드번호 = dgv전표리스트.Rows[i].Cells[2].Value.ToString();

                                if (dgv전표리스트.Rows[i].Cells[4].Value != null)
                                    전표리스트.거래처코드번호 = dgv전표리스트.Rows[i].Cells[4].Value.ToString();

                                if (dgv전표리스트.Rows[i].Cells[7].Value != null)
                                    전표리스트.금액 = int.Parse(dgv전표리스트.Rows[i].Cells[7].Value.ToString());

                                if (dgv전표리스트.Rows[i].Cells[8].Value != null)
                                    전표리스트.적요명 = dgv전표리스트.Rows[i].Cells[8].Value.ToString();

                                전표리스트.입력날짜 = input.Date;
                                전표리스트.전표번호 = dgv전표.Rows[전표단위.Index].Cells[2].Value.ToString(); ;

                                DB.전표리스트.Insert(전표리스트);
                            }
                        }
                    }
                }

                // 일치하지 않은 데이터가 있을 경우 메시지 경고박스를 띄움
                if (resultIndex1.Count > 0 || resultIndex2.Count > 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("수정된 내용이 있습니다.\n변경사항을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo))
                    {
                        if (resultIndex1.Count > 0)
                            foreach (int i in resultIndex1)
                                DB.전표.Update(전표s[i]);

                        if (resultIndex2.Count > 0)
                            foreach (int i in resultIndex2)
                                DB.전표리스트.Update(전표리스트s[i]);
                    }
                }

                dgv전표.CurrentCell = dgv전표.Rows[전표단위.Index].Cells[2];
                dgv전표.Focus();

                if ((dgv전표.Rows.Count - 1 == 전표단위.RowIndex) && (dgv전표.Rows[전표단위.Index].Cells[전표단위.ColumnCnt - 1].Value != null))
                {
                    dgv전표.Rows.Add();
                }
            }

            // F2 코드 도움창 열기
            if (e.KeyData == Keys.F2)
            {
                if (dgv전표리스트.CurrentCell.ColumnIndex == 2)
                {
                    계정코드구분Control control = new 계정코드구분Control();
                    MenuForm menuForm = new MenuForm(control);
                    menuForm.SetFormLocation();
                    menuForm.ShowDialog();

                    dgv전표리스트.Rows[전표리스트단위.Index].Cells[2].Value = 전표리스트단위.AccountCode;
                    dgv전표리스트.Rows[전표리스트단위.Index].Cells[3].Value = 전표리스트단위.AccountName;
                }

                if (dgv전표리스트.CurrentCell.ColumnIndex == 4)
                {
                    string comparer = dgv전표리스트.Rows[전표리스트단위.Index].Cells[1].Value.ToString();

                    if (comparer == "출금" || comparer == "입금")
                    {
                        금융거래처구분Control control = new 금융거래처구분Control();
                        MenuForm menuForm = new MenuForm(control);
                        menuForm.SetFormLocation();
                        menuForm.ShowDialog();

                        dgv전표리스트.Rows[전표리스트단위.Index].Cells[4].Value = 전표리스트단위.FinanceCustomerCode;
                        dgv전표리스트.Rows[전표리스트단위.Index].Cells[5].Value = 전표리스트단위.FinanceCustomerName;
                        dgv전표리스트.Rows[전표리스트단위.Index].Cells[6].Value = 전표리스트단위.FinanceCorporateRegistrationNumber;
                    }

                    if (comparer == "차변" || comparer == "대변")
                    {
                        일반거래처구분Control control = new 일반거래처구분Control();
                        MenuForm menuForm = new MenuForm(control);
                        menuForm.SetFormLocation();
                        menuForm.ShowDialog();

                        dgv전표리스트.Rows[전표리스트단위.Index].Cells[4].Value = 전표리스트단위.GeneralCustomerCode;
                        dgv전표리스트.Rows[전표리스트단위.Index].Cells[5].Value = 전표리스트단위.GeneralCustomerName;
                        dgv전표리스트.Rows[전표리스트단위.Index].Cells[6].Value = 전표리스트단위.GeneralCorporateRegistrationNumber;
                    }
                }
            }

            // 한 줄 삭제
            if (e.KeyData == Keys.Delete)
            {
                Fill전표리스트ForDelete(out 전표리스트 전표리스트);

                if (DialogResult.Yes == MessageBox.Show("현재 행을 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo))
                {
                    DB.전표리스트.Delete(전표리스트);
                }
            }
        }

        private void Insert전표(int i)
        {
            전표 전표 = new 전표();

            전표.입력날짜 = input.Date;
            전표.전표번호 = dgv전표.Rows[i].Cells[2].Value.ToString();
            if (dgv전표.Rows[i].Cells[3].Value != null)
                전표.품의내역 = dgv전표.Rows[i].Cells[3].Value.ToString();
            전표.유형 = dgv전표.Rows[i].Cells[4].Value.ToString();
            전표.기표번호 = dgv전표.Rows[i].Cells[5].Value.ToString();
            전표.승인상태 = dgv전표.Rows[i].Cells[6].Value.ToString();
            전표.승인자 = dgv전표.Rows[i].Cells[7].Value.ToString();
            if (dgv전표.Rows[i].Cells[8].Value != null)
                전표.대차차액 = int.Parse(dgv전표.Rows[i].Cells[8].Value.ToString());
            전표.작업자 = dgv전표.Rows[i].Cells[9].Value.ToString();

            DB.전표.Insert(전표);
        }

        private void Fill전표리스트ForDelete(out 전표리스트 전표리스트)
        {
            전표리스트 = new 전표리스트();

            전표리스트.순번 = int.Parse(dgv전표리스트.CurrentRow.Cells[0].Value.ToString());
            전표리스트.구분 = dgv전표리스트.CurrentRow.Cells[1].Value.ToString();
            전표리스트.계정과목코드번호 = dgv전표리스트.CurrentRow.Cells[2].Value.ToString();
            if (dgv전표리스트.CurrentRow.Cells[4].Value != null)
                전표리스트.거래처코드번호 = dgv전표리스트.CurrentRow.Cells[4].Value.ToString();
            전표리스트.금액 = int.Parse(dgv전표리스트.CurrentRow.Cells[7].Value.ToString());
            전표리스트.적요명 = dgv전표리스트.CurrentRow.Cells[8].Value.ToString();
            전표리스트.입력날짜 = input.Date;
            전표리스트.전표번호 = dgv전표.Rows[전표단위.Index].Cells[2].Value.ToString();
        }

        /// <summary>
        /// 전표 기본값 세팅
        /// </summary>
        public void SetDefaultBy전표()
        {
            dgv전표.Rows[전표단위.Index].Cells[2].Value = $"0000{전표단위.Index + 1}";
            dgv전표.Rows[전표단위.Index].Cells[5].Value
                = $"{input.Date.ToString("yyyyMMdd")}" + "-" + $"0000{전표단위.Index + 1}";

            dgv전표.Rows[전표단위.Index].Cells[6].Value = "미결";
            dgv전표.Rows[전표단위.Index].Cells[7].Value = loginMember.EmployeeName;
            dgv전표.Rows[전표단위.Index].Cells[9].Value = loginMember.EmployeeName;
        }

        private void Dgv전표리스트_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                dgv전표리스트.CurrentCell.Tag = "1.출금";

                int? value = int.Parse(dgv전표리스트.CurrentRow.Cells[1].Value.ToString());

                if (value == null)
                    return;

                if (dgv전표리스트.CurrentCell.ColumnIndex == 1)
                {
                    switch (value)
                    {
                        case 1:
                            dgv전표리스트.CurrentRow.Cells[1].Value = "출금";
                            break;
                        case 2:
                            dgv전표리스트.CurrentRow.Cells[1].Value = "입금";
                            break;
                        case 3:
                            dgv전표리스트.CurrentRow.Cells[1].Value = "차변";
                            break;
                        case 4:
                            dgv전표리스트.CurrentRow.Cells[1].Value = "대변";
                            break;
                    }
                }
                keybd_event((byte)Keys.Enter, 0x0D, 0x01, 0);
            }

            if (e.ColumnIndex == 2)
            {
                dgv전표리스트.CurrentCell = dgv전표리스트.Rows[전표리스트단위.Index].Cells[4];
            }

            if (e.ColumnIndex == 4)
            {
                dgv전표리스트.CurrentCell = dgv전표리스트.Rows[전표리스트단위.Index].Cells[7];
            }

            if (e.ColumnIndex == 7)
            {
                dgv전표리스트.CurrentCell = dgv전표리스트.Rows[전표리스트단위.Index].Cells[8];
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
                int.TryParse(txb일.Text, out int result);
                if (result == 0)
                {
                    MessageBox.Show("잘못된 입력입니다. 다시 입력하시오.");
                    return;
                }
                else
                    input.Day = result;
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
                        FillDataGridViewWithList(list);
                    }

                    dgv전표.Focus();
                    dgv전표.Rows.Add();
                    전표단위.LoadCnt = list.Count - 1;
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

        private void FillDataGridViewWithList(List<전표> list)
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

        // 일자가 변경되면 모든 Dgv리스트 행 초기화
        private void Txb일_TextChanged(object sender, EventArgs e)
        {
            dgv전표.Rows.Clear();
            dgv전표리스트.Rows.Clear();
        }
        #endregion

        private void 전표등록_Load(object sender, EventArgs e)
        {
            txb회사명.Text = DB.회사.Search(cbb회사코드.Text);

            DB.부서.Search(loginMember.EmployeeCode, out string code1, out string name1);
            cbb부서코드.Text = code1;
            txb부서명.Text = name1;

            DB.사원등록.Search(loginMember.EmployeeCode, out string code2, out string name2);
            cbb사원코드.Text = code2;
            txb사원명.Text = name2;
        }

        private void Cbb부서코드_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbb부서코드.SelectedValue != null)
                txb부서명.Text = DB.부서.SearchChangedValue(cbb부서코드.SelectedValue.ToString());
        }

        private void Cbb사원코드_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbb사원코드.SelectedValue != null)
                txb사원명.Text = DB.사원등록.SearchChangedValue(cbb사원코드.SelectedValue.ToString());
        }

        private void Btn합계_Click(object sender, EventArgs e)
        {
            int rowCnt = dgv전표리스트.RowCount;
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < rowCnt; i++)
            {
                if (dgv전표리스트.Rows[i].Cells[1].Value.ToString() == "차변")
                {
                    leftSum += int.Parse(dgv전표리스트.Rows[i].Cells[7].Value.ToString());
                }

                if (dgv전표리스트.Rows[i].Cells[1].Value.ToString() == "대변")
                {
                    rightSum += int.Parse(dgv전표리스트.Rows[i].Cells[7].Value.ToString());
                }

                if (dgv전표리스트.Rows[i].Cells[1].Value.ToString() == "출금")
                {
                    rightSum += int.Parse(dgv전표리스트.Rows[i].Cells[7].Value.ToString());
                }

                if (dgv전표리스트.Rows[i].Cells[1].Value.ToString() == "입금")
                {
                    leftSum += int.Parse(dgv전표리스트.Rows[i].Cells[7].Value.ToString());
                }
            }

            txb차변합계.Text = leftSum.ToString();
            txb대변합계.Text = rightSum.ToString();
        }
    }
}