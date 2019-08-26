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
        [DllImport("User32.dll")]
        public static extern void keybd_event(uint vk, uint scan, uint flags, uint extraInfo);
        private Label label;
        InputDate input;

        public 전표등록()
        {
            InitializeComponent();

            lbl회계년도.Text = DateTime.Now.Year.ToString();
            SetData();
            SetLabelForCodeHelper();

            
            txb일.Focus();
        }

        // Dgv전표리스트 구분 코드도움을 위한 라벨 생성
        private void SetLabelForCodeHelper()
        {
            label = new Label();

            label.Name = "코드도움";
            label.BackColor = Color.LightBlue;
            label.AutoSize = false;
            label.Text = "1. 출금  2. 입금  3. 차변  4. 대변";
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Size = new Size(188, 23);
        }

        // cbb월 콤보박스에 월의 데이터를 넣음
        private void SetData()
        {
            사업장등록BindingSource.DataSource = DB.사업장.GetAll();
            사원등록BindingSource.DataSource = DB.사원등록.GetAll();
            부서등록BindingSource.DataSource = DB.부서.GetAll();

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

        // Enter, Delete 키
        private void Dgv전표_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                전표단위.ColumnIndex = dgv전표.CurrentCell.ColumnIndex;
                전표단위.RowIndex = dgv전표.CurrentCell.RowIndex;
                전표단위.Index = dgv전표.CurrentRow.Index;
                전표단위.ColumnCnt = dgv전표.Columns.Count;

                // 현재 행의 마지막 열일 경우
                if (전표단위.ColumnIndex == (전표단위.ColumnCnt - 1))
                {
                    // 마지막행의 마지막 열까지 입력이 끝나면 다음 행을 추가하고 다음 행의 세번째 열로 이동
                    if ((dgv전표.Rows.Count - 1 == 전표단위.RowIndex) && (dgv전표.Rows[전표단위.Index].Cells[전표단위.ColumnCnt - 1].Value != null))
                    {
                        dgv전표.Rows.Add();
                        전표단위.RowCnt = dgv전표.RowCount;
                        dgv전표.CurrentCell = dgv전표[2, 전표단위.RowIndex + 1];
                    }
                    // 현재 행의 마지막 열에 데이터가 있으면 다음 행의 세번째 열로 이동
                    else if (dgv전표.Rows[전표단위.Index].Cells[전표단위.ColumnCnt - 1].Value != null)
                    {
                        dgv전표.CurrentCell = dgv전표[2, 전표단위.RowIndex + 1];
                    }
                }
                // 엔터키 입력시 다음 셀로 이동
                else
                {
                    dgv전표.CurrentCell = dgv전표[전표단위.ColumnIndex + 1, 전표단위.RowIndex];
                }
            }

            if (e.KeyData == Keys.Delete)
            {
                // 선택된 전표와 연관된 전표리스트를 담고 전표를 담음
                Fill_InAll_LinkedTo전표(out 전표 전표, out List<전표리스트> list);

                // 경고문구 출력
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

        /// <summary>
        /// 전표와 연결된 모든 전표리스트를 담음
        /// </summary>
        /// <param name="전표">담을 전표</param>
        /// <param name="list">담을 전표리스트</param>
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

        // Dgv전표 - 현재 행의 5번째 열 아래에서 메뉴클릭시 이벤트 발생
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
                    bool check = IsPossibleToAddByStatementList();

                    if (check == true)
                        dgv전표리스트.Rows.Add();
                    dgv전표리스트.CurrentCell = dgv전표리스트.Rows[0].Cells[1];
                    dgv전표리스트.Focus();
                }
            }
        }

        private void Dgv전표_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            전표단위.Index = dgv전표.CurrentRow.Index;
            전표단위.ColumnIndex = dgv전표.CurrentCell.ColumnIndex;
            전표단위.RowIndex = dgv전표.CurrentCell.RowIndex;

            // 현재 행의 세번째 열에 데이터가 있을 경우 전표와 연관된 전표리스트를 불러옴
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

            // 현재 행의 5번째 열에서 ContextMenu 팝업
            if (e.ColumnIndex == 4)
            {
                if (dgv전표.Rows[전표단위.RowIndex].Cells[3].Value == null)
                {
                    MessageBox.Show("품의내역을 입력하세요");
                    keybd_event((byte)Keys.Left, 0x25, 0x01, 0);
                    return;
                }

                // 컨텍스트 메뉴 첫번째 아이템에 위치
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

        private void Dgv전표_Scroll(object sender, ScrollEventArgs e)
        {
            Rectangle rtHeader = dgv전표.DisplayRectangle;
            rtHeader.Height = dgv전표.ColumnHeadersHeight / 2;
            dgv전표.Invalidate(rtHeader);
        }

        // 행 추가시 자동으로 일자 입력됨
        // 컬럼 세팅
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
            if (dgv전표.Rows[e.RowIndex].Cells[1].Value == null)
                dgv전표.Rows[e.RowIndex].Cells[1].Value = txb일.Text;
            dgv전표.Columns[8].DefaultCellStyle.Format = "##,##";
        }

        private void Dgv전표_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.ColumnIndex == 1 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9)
            if (e.ColumnIndex.IsOneOf(1, 5, 6, 7, 8, 9))
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

            dgv전표리스트.Columns[7].DefaultCellStyle.Format = "##,##";
        }

        private void Dgv전표리스트_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter 입력시 다음 셀로 이동, 마지막 셀에서 데이터가 없으면 개행추가 금지
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
                        bool check = IsPossibleToAddByStatementList();

                        if (check == true)
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
                    e.SuppressKeyPress = true;
                    계정코드구분Control control = new 계정코드구분Control();

                    CodeHelperForm menuForm = new CodeHelperForm(control);
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
                        CodeHelperForm form = new CodeHelperForm(control);
                        form.ShowDialog();

                        dgv전표리스트.Rows[전표리스트단위.Index].Cells[4].Value = 전표리스트단위.FinanceCustomerCode;
                        dgv전표리스트.Rows[전표리스트단위.Index].Cells[5].Value = 전표리스트단위.FinanceCustomerName;
                        dgv전표리스트.Rows[전표리스트단위.Index].Cells[6].Value = 전표리스트단위.FinanceCorporateRegistrationNumber;
                    }

                    if (comparer == "차변" || comparer == "대변")
                    {
                        일반거래처구분Control control = new 일반거래처구분Control();
                        CodeHelperForm form = new CodeHelperForm(control);
                        form.ShowDialog();

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

        /// <summary>
        /// 전표리스트에서 행을 추가할 지 여부를 판단
        /// </summary>
        /// <returns></returns>
        private bool IsPossibleToAddByStatementList()
        {
            for (int i = 0; i < dgv전표리스트.RowCount; i++)
            {
                if (dgv전표리스트.Rows[i].Cells[8].Value != null)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// 기존 데이터외의 추가 데이터 Insert
        /// </summary>
        /// <param name="i">Row 인덱스</param>
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

        /// <summary>
        /// 삭제할 전표리스트 담음
        /// </summary>
        /// <param name="전표리스트">삭제할 전표리스트</param>
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
        /// 전표의 기본값 세팅
        /// </summary>
        public void SetDefaultBy전표()
        {

            dgv전표.Rows[전표단위.Index].Cells[2].Value = string.Format("{0:D5}", (전표단위.Index + 1));

            dgv전표.Rows[전표단위.Index].Cells[5].Value
                = $"{input.Date.ToString("yyyyMMdd")}" + "-" + string.Format("{0:D5}", (전표단위.Index + 1));

            dgv전표.Rows[전표단위.Index].Cells[6].Value = "미결";
            dgv전표.Rows[전표단위.Index].Cells[7].Value = loginMember.EmployeeName;
            dgv전표.Rows[전표단위.Index].Cells[9].Value = loginMember.EmployeeName;
        }

        private void Dgv전표리스트_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // 두번째 열에서 1 : 출금, 2 : 입금, 3 : 차변, 4 : 대변 -> 매칭되는 수 입력시 치환
            if (e.ColumnIndex == 1)
            {
                if (dgv전표리스트.CurrentRow.Cells[1].Value == null)
                    return;

                int.TryParse(dgv전표리스트.CurrentRow.Cells[1].Value.ToString(), out int value);

                if (value == 0)
                    return;

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

                if (dgv전표리스트.Controls.Contains(label))
                {
                    label.Hide();
                }

                SendKeys.Send("{UP}");
                SendKeys.Send("{Right}");
            }

            // 3번째 열 입력 후 5번째 열로 이동
            if (e.ColumnIndex == 2)
            {
                dgv전표리스트.CurrentCell = dgv전표리스트.Rows[전표리스트단위.Index].Cells[4];
                SendKeys.Send("{UP}");
                SendKeys.Send("{Right}");
            }

            // 5번째 열 입력 후 8번째 열로 이동
            if (e.ColumnIndex == 4)
            {
                dgv전표리스트.CurrentCell = dgv전표리스트.Rows[전표리스트단위.Index].Cells[7];
                SendKeys.Send("{UP}");
                SendKeys.Send("{Right}");
            }

            // 8번째 열 입력 후 9번째 열로 이동
            if (e.ColumnIndex == 7)
            {
                dgv전표리스트.CurrentCell = dgv전표리스트.Rows[전표리스트단위.Index].Cells[8];
                SendKeys.Send("{UP}");
                SendKeys.Send("{Right}");
            }
        }
        private void Dgv전표리스트_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            전표리스트단위.Index = dgv전표리스트.CurrentRow.Index;
            전표리스트단위.RowIndex = dgv전표리스트.CurrentCell.RowIndex;

            if (dgv전표리스트.Rows[전표리스트단위.RowIndex].Cells[1].ColumnIndex == e.ColumnIndex)
            {
                var cellRectangle = dgv전표리스트.GetCellDisplayRectangle(1, 전표리스트단위.Index, true);

                label.Location = new Point(cellRectangle.Left, cellRectangle.Bottom);
                dgv전표리스트.Controls.Add(label);
                label.Show();
            }
            else
            {
                label.Hide();
            }
        }
        #endregion

        #region Txb일 Events
        // 날짜 입력 후엔터키를 누르면 일자 확인 후 dgv전표의 "일" 컬럼에 일자가 들어감
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

                if (txb일.Text.IsNullOrEmpty())
                {
                    if (input.IsDate(input.Year, input.Month, 50) == false)
                    {
                        input.Date = new DateTime(input.Year, input.Month, int.Parse(input.DayText));

                        DateTime firstDate = new DateTime(input.Year, input.Month, 1);

                        List<전표> list = DB.전표.GetAllMatchedMonth(firstDate, input.Date);

                        if (list != null)
                        {
                            FillDataGridViewInList(list);

                            dgv전표.Focus();
                            bool check = IsPossibleToAddByStatement();

                            if (dgv전표.RowCount == 0)
                                dgv전표.Rows.Add();

                            if (check == true)
                                dgv전표.Rows.Add();

                            전표단위.LoadCnt = list.Count - 1;
                            전표단위.Index = dgv전표.CurrentRow.Index;
                            전표단위.RowCnt = dgv전표.RowCount;
                            dgv전표.CurrentCell = dgv전표.Rows[전표단위.Index].Cells[2];
                        }
                        else
                            return;
                    }
                }
                else
                {
                    int.TryParse(txb일.Text, out int result);
                    if (result == 0)
                    {
                        MessageBox.Show("잘못된 입력입니다. 다시 입력하시오.");
                        return;
                    }
                    else
                        input.Day = result;

                    if (input.IsDate(input.Year, input.Month, input.Day) == false)
                    {
                        txb일.Text = input.DayText;

                        Load전표();
                    }
                    else
                    {
                        txb일.Text = input.Day.ToString();

                        Load전표();
                    }
                }
            }
        }

        /// <summary>
        /// 입력날짜에 맞는 전표를 불러옴
        /// </summary>
        private void Load전표()
        {
            input.Date = new DateTime(input.Year, input.Month, int.Parse(txb일.Text));

            List<전표> list = DB.전표.GetAllMatchedDay(input.Date);
            if (list != null)
            {
                FillDataGridViewInList(list);
            }

            dgv전표.Focus();
            bool check = IsPossibleToAddByStatement();

            if (dgv전표.RowCount == 0)
                dgv전표.Rows.Add();

            if (check == true)
                dgv전표.Rows.Add();

            전표단위.LoadCnt = list.Count - 1;
            전표단위.RowCnt = dgv전표.RowCount;
            dgv전표.CurrentCell = dgv전표.Rows[0].Cells[2];
            전표단위.Index = dgv전표.CurrentRow.Index;
        }

        /// <summary>
        /// 전표에서 행을 추가할 지 여부를 판단
        /// </summary>
        /// <returns></returns>
        private bool IsPossibleToAddByStatement()
        {
            for (int i = 0; i < dgv전표.RowCount; i++)
            {
                if (dgv전표.Rows[i].Cells[5].Value != null)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// 입력날짜와 일치하는 전표들을 리스트에 담음
        /// </summary>
        /// <param name="list"> 전표의 List<></param>
        private void FillDataGridViewInList(List<전표> list)
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
                if (list[i].대차차액 != null && list[i].대차차액 != 0)
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

        // 로드 시 로그인 정보를 가져옴
        private void 전표등록_Load(object sender, EventArgs e)
        {
            txb사업장명.Text = DB.사업장.Search(cbb사업장코드.Text);

            DB.사원등록.SearchDepartment(loginMember.EmployeeCode, out string code1, out string name1);
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

            txb차변합계.Text = leftSum.ToString("##,##");
            txb대변합계.Text = rightSum.ToString("##,##");
        }

        public void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Dgv전표_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                return;
                //MessageBox.Show("error.");
            }
        }

        private void Dgv전표리스트_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                return;
                //MessageBox.Show("error.");
            }
        }
    }
}