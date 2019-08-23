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
    public partial class 입고등록 : UserControl
    {
        public 입고등록()
        {
            InitializeComponent();
        }

        private void Btn조회_Click(object sender, EventArgs e)
        {
            dgv입고등록.Rows.Clear();
            dgv입고등록.Rows.Add();
            var list = DB.입고등록.입고등록정보(txb거래처이름.Text, txb발주번호.Text,
               FirstDate.Value, LastDate.Value);

            for (int i = 0; i < list.Count; i++)
            {
                dgv입고등록.Rows[i].Cells[0].Value = list[i].입고등록번호;
                dgv입고등록.Rows[i].Cells[1].Value = list[i].발주번호;
                dgv입고등록.Rows[i].Cells[2].Value = list[i].공급업체번호;
                dgv입고등록.Rows[i].Cells[3].Value = list[i].검사일자.ToShortDateString();
                dgv입고등록.Rows.Add();
            }
        }

        private void Dgv입고등록_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.CurrentRow.Cells[0].Value == null) return;
            else if (DB.입고등록.Is입고등록(dgv.CurrentRow.Cells[0].Value.ToString()).Count == 0) return;
            else if (DB.입고등록.Is입고등록(dgv.CurrentRow.Cells[0].Value.ToString()).Count > 0)
            {
                dgv입고등록리스트.Rows.Clear();
                var list = DB.입고등록리스트.Search입고등록리스트(dgv.CurrentRow.Cells[0].Value.ToString());
                dgv입고등록리스트.Rows.Add();
                for (int i = 0; i < list.Count; i++)
                {
                    dgv입고등록리스트.Rows[i].Cells[0].Value = DB.자재.Get자재이름(list[i].자재번호);
                    dgv입고등록리스트.Rows[i].Cells[1].Value = list[i].양품수량;
                    dgv입고등록리스트.Rows[i].Cells[2].Value = list[i].불량수량;
                    if (i != list.Count - 1)
                        dgv입고등록리스트.Rows.Add();
                }
            }
            else return;
        }

        private void Dgv입고등록리스트_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int nowColum = dgv.CurrentCell.ColumnIndex;
            int nowRow = dgv.CurrentCell.RowIndex;
            int maxRow = dgv.RowCount;
            int maxColum = dgv.ColumnCount;

            if (nowColum == 0)
            {
                if (dgv.Rows[nowRow].Cells[nowColum].Value == null)
                {
                    MessageBox.Show("데이터를 입력하세요");
                    return;
                }
                else
                {
                    if (DB.자재.Get자재번호(dgv.CurrentRow.Cells[0].Value.ToString()).Count == 0)
                        MessageBox.Show("등록되지 않은 자재입니다");

                    else
                    {
                        if (DB.발주리스트.Search발주리스트(dgv입고등록.CurrentRow.Cells[1].Value.ToString(), dgv.CurrentRow.Cells[0].Value.ToString()).Count == 0)
                        {
                            MessageBox.Show("발주한 자재가 아닙니다");
                            return;
                        }
                    }
                }
            }

            if (nowColum == 1)
            {
                if (dgv.Rows[nowRow].Cells[nowColum].Value == null)
                {
                    MessageBox.Show("데이터를 입력하세요");
                    return;
                }
            }
            //입고등록리스트 2번째 칸이 되었을 때
            if (nowColum == 2)
            {
                if (dgv.Rows[nowRow].Cells[nowColum].Value == null)
                {
                    MessageBox.Show("데이터를 입력하세요");
                    return;
                }
                else //값이 다 들어갔을 때
                {
                    string 자재번호 = DB.자재.Get자재번호(dgv.CurrentRow.Cells[0].Value.ToString()).Select(x => x.자재번호).FirstOrDefault();
                    반품처리서 반품처리서 = new 반품처리서();
                    if (DB.입고등록리스트.Search입고등록리스트(dgv입고등록.CurrentRow.Cells[0].Value.ToString(), 자재번호).Count == 0)
                    {
                        입고등록리스트 입고등록리스트 = new 입고등록리스트();
                        입고등록리스트.입고등록번호 = dgv입고등록.CurrentRow.Cells[0].Value.ToString();
                        입고등록리스트.자재번호 = DB.자재.Get자재번호(dgv.CurrentRow.Cells[0].Value.ToString()).Select(x => x.자재번호).FirstOrDefault();
                        입고등록리스트.양품수량 = int.Parse(dgv.CurrentRow.Cells[1].Value.ToString());
                        입고등록리스트.불량수량 = int.Parse(dgv.CurrentRow.Cells[2].Value.ToString());
                        DB.입고등록리스트.Insert(입고등록리스트);

                        자재 자재 = DB.자재.Get자재(입고등록리스트.자재번호).FirstOrDefault();
                        자재.재고량 += (int)입고등록리스트.양품수량;
                        DB.자재.Update(자재);
                        //발주리스트에 양품수량인 갯수를 뺴줌으로 인해 발주량이 몇개가 와야하는지 알 수 있음
                        MessageBox.Show("입고등록리스트");

                        if (입고등록리스트.불량수량 > 0)
                        {
                            if (DB.반품처리서.Search반품처리서From입고등록번호(입고등록리스트.입고등록번호).Count == 0)
                            {
                                반품처리서.반품처리서번호 = (DB.반품처리서.GetCount() + 1).ToString();
                                반품처리서.입고검사서번호 = 입고등록리스트.입고등록번호;
                                반품처리서.공급업체번호 = DB.입고등록.Is입고등록(입고등록리스트.입고등록번호).Select(x => x.공급업체번호).FirstOrDefault();
                                반품처리서.반품처리날짜 = DateTime.Today.Date;
                                DB.반품처리서.Insert(반품처리서);
                            }

                            반품처리리스트 반품처리리스트 = new 반품처리리스트();
                            반품처리리스트.반품처리번호 = DB.반품처리서.Search반품처리서From입고등록번호(입고등록리스트.입고등록번호).Select(x => x.반품처리서번호).FirstOrDefault();
                            반품처리리스트.자재번호 = 입고등록리스트.자재번호;
                            반품처리리스트.수량 = (int)입고등록리스트.불량수량;

                            DB.반품처리리스트.Insert(반품처리리스트);
                        }
                    }
                    else //수량 수정시
                    {
                        var list = DB.입고등록리스트.Search입고등록리스트(dgv입고등록.CurrentRow.Cells[0].Value.ToString(), DB.자재.Get자재번호(dgv.CurrentRow.Cells[0].Value.ToString()).Select(x => x.자재번호).FirstOrDefault()).FirstOrDefault();


                        입고등록리스트 입고등록리스트 = new 입고등록리스트();
                        입고등록리스트.입고등록번호 = dgv입고등록.CurrentRow.Cells[0].Value.ToString();
                        입고등록리스트.자재번호 = DB.자재.Get자재번호(dgv.CurrentRow.Cells[0].Value.ToString()).Select(x => x.자재번호).FirstOrDefault();

                        //양품수량 수정
                        if (list.양품수량 !=
                            int.Parse(dgv입고등록리스트.CurrentRow.Cells[1].Value.ToString()))
                        {
                            //수량이 변하면 기존의 양품수량을 빼준다음 변경된 수량을 다시 더해주면서 업데이트
                            var 자재 = DB.자재.Get자재번호(dgv.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault();
                            자재.재고량 -= (int)list.양품수량;
                            자재.재고량 += int.Parse(dgv입고등록리스트.CurrentRow.Cells[1].Value.ToString());
                            DB.자재.Update(자재);

                            //기존의 입고등록리스트 업데이트
                            입고등록리스트.양품수량 =
                                int.Parse(dgv입고등록리스트.CurrentRow.Cells[1].Value.ToString());
                            입고등록리스트.불량수량 =
                                int.Parse(dgv입고등록리스트.CurrentRow.Cells[2].Value.ToString());
                            DB.입고등록리스트.Update(입고등록리스트);
                        }

                        //불량수량 수정
                        if (list.불량수량 !=
                            int.Parse(dgv입고등록리스트.CurrentRow.Cells[2].Value.ToString()))
                        {
                            입고등록리스트.불량수량 =
                                int.Parse(dgv입고등록리스트.CurrentRow.Cells[2].Value.ToString());
                            입고등록리스트.양품수량 =
                                int.Parse(dgv입고등록리스트.CurrentRow.Cells[1].Value.ToString());

                            //불량수량에 대한 불량상세정보 지우기
                            if (DB.불량상세정보.Search불량상세정보(dgv입고등록.CurrentRow.Cells[0].Value.ToString(), DB.자재.Get자재번호(dgv.CurrentRow.Cells[0].Value.ToString()).Select(x => x.자재번호).FirstOrDefault()).Count > 0)
                            {
                                불량상세정보 불량상세정보 = new 불량상세정보();

                                var list1 =
                                    DB.불량상세정보.Search불량상세정보(dgv입고등록.CurrentRow.Cells[0].Value.ToString(), DB.자재.Get자재번호(dgv.CurrentRow.Cells[0].Value.ToString()).Select(x => x.자재번호).FirstOrDefault());

                                불량상세정보.입고등록번호 = dgv입고등록.CurrentRow.Cells[0].Value.ToString();
                                불량상세정보.자재번호 = DB.자재.Get자재번호(dgv.CurrentRow.Cells[0].Value.ToString()).Select(x => x.자재번호).FirstOrDefault();

                                for (int j = 0; j < list1.Count; j++)
                                {
                                    불량상세정보.불량코드번호 = list1[j].불량코드번호;
                                    불량상세정보.불량수량 = list1[j].불량수량;

                                    DB.불량상세정보.Delete(불량상세정보);
                                }
                            }

                            //불량수량이 0으로 변경된 경우
                            if (int.Parse(dgv입고등록리스트.CurrentRow.Cells[2].Value.ToString()) == 0)
                            {
                                var Delete반품처리리스트 = DB.반품처리리스트.Search반품처리리스트(dgv입고등록.CurrentRow.Cells[0].Value.ToString(), dgv입고등록리스트.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault();
                                DB.반품처리리스트.Delete(Delete반품처리리스트);
                                //반품서에 반품자재가 하나였는데 불량이 없어지면 반품서도 삭제, 그게 아니면 살려두기
                                if (DB.반품처리리스트.Search반품처리리스트(Delete반품처리리스트.반품처리번호).Count == 0)
                                {
                                    반품처리서 Delete반품처리서 = DB.반품처리서.Search반품처리서(Delete반품처리리스트.반품처리번호).FirstOrDefault();
                                    DB.반품처리서.Delete(Delete반품처리서);
                                }
                            }

                            else
                            {
                                if (DB.반품처리서.Search반품처리서From입고등록번호(dgv입고등록.CurrentRow.Cells[0].Value.ToString()).Count ==0)
                                {
                                    반품처리서.공급업체번호 = dgv입고등록.CurrentRow.Cells[2].Value.ToString();
                                    반품처리서.반품처리서번호 = (DB.반품처리서.GetCount() + 1).ToString();
                                    반품처리서.입고검사서번호 = dgv입고등록.CurrentRow.Cells[0].Value.ToString();
                                    반품처리서.반품처리날짜 = DateTime.Today.Date;

                                    DB.반품처리서.Insert(반품처리서);
                                }

                                if (DB.반품처리리스트.Search반품처리리스트(dgv입고등록.CurrentRow.Cells[0].Value.ToString(), dgv입고등록리스트.CurrentRow.Cells[0].Value.ToString()).Count != 0)
                                {
                                    string 반품처리번호 = DB.반품처리리스트.Search반품처리리스트(dgv입고등록.CurrentRow.Cells[0].Value.ToString(), dgv입고등록리스트.CurrentRow.Cells[0].Value.ToString()).Select(x => x.반품처리번호).FirstOrDefault();

                                    var Updata반품처리서 = DB.반품처리서.Search반품처리서(반품처리번호).FirstOrDefault();

                                    Updata반품처리서.반품처리날짜 = DateTime.Today.Date;
                                    DB.반품처리서.Update(Updata반품처리서);

                                    var Updata반품처리리스트 = DB.반품처리리스트.Search반품처리리스트(dgv입고등록.CurrentRow.Cells[0].Value.ToString(), dgv입고등록리스트.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault();
                                    Updata반품처리리스트.수량 = (int)입고등록리스트.불량수량;
                                    DB.반품처리리스트.Update(Updata반품처리리스트);
                                }
                                if (DB.반품처리리스트.Search반품처리리스트(dgv입고등록.CurrentRow.Cells[0].Value.ToString(), dgv입고등록리스트.CurrentRow.Cells[0].Value.ToString()).Count == 0)
                                {                                   
                                    반품처리리스트 반품처리리스트 = new 반품처리리스트();
                                    반품처리리스트.반품처리번호 = DB.반품처리서.Search반품처리서From입고등록번호(dgv입고등록.CurrentRow.Cells[0].Value.ToString()).Select(x=>x.반품처리서번호).FirstOrDefault();
                                    반품처리리스트.자재번호 = DB.자재.Get자재번호(dgv.CurrentRow.Cells[0].Value.ToString()).Select(x => x.자재번호).FirstOrDefault();
                                    반품처리리스트.수량 = int.Parse(dgv입고등록리스트.CurrentRow.Cells[2].Value.ToString());

                                    DB.반품처리리스트.Insert(반품처리리스트);
                                }
                            }
                            DB.입고등록리스트.Update(입고등록리스트);
                        }
                        dgv불량상세정보.Rows.Clear();
                        dgv불량상세정보.Rows.Add();
                    }
                }
            }
        }

        private void Dgv입고등록리스트_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            dgv불량상세정보.Rows.Clear();
            if (dgv.CurrentRow.Cells[0].Value == null) return;

            if (DB.불량상세정보.Search불량상세정보(dgv입고등록.CurrentRow.Cells[0].Value.ToString(),
                DB.자재.Get자재번호(dgv.CurrentRow.Cells[0].Value.ToString()).Select(x => x.자재번호).FirstOrDefault()).Count > 0)
            {
                dgv불량상세정보.Rows.Clear();

                var list = DB.불량상세정보.Search불량상세정보(dgv입고등록.CurrentRow.Cells[0].Value.ToString(),
                DB.자재.Get자재번호(dgv.CurrentRow.Cells[0].Value.ToString()).Select(x => x.자재번호).FirstOrDefault());

                for (int i = 0; i < list.Count; i++)
                {
                    if (i != list.Count)
                        dgv불량상세정보.Rows.Add();
                    dgv불량상세정보.Rows[i].Cells[0].Value = list[i].불량코드번호;
                    dgv불량상세정보.Rows[i].Cells[1].Value = list[i].불량수량;

                }
            }
        }

        private void 입고등록_Load(object sender, EventArgs e)
        {
            dgv입고등록.Rows.Add();
        }

        private void Dgv입고등록_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int nowColum = dgv.CurrentCell.ColumnIndex;
            int nowRow = dgv.CurrentCell.RowIndex;
            int maxRow = dgv.RowCount;
            int maxColum = dgv.ColumnCount;

            if (nowColum == maxColum - 3)
            {
                if (dgv.Rows[nowRow].Cells[nowColum].Value == null)
                {
                    MessageBox.Show("데이터를 입력하세요");
                    return;
                }
                else
                {
                    if (DB.발주서.Is발주번호(dgv.Rows[nowRow].Cells[nowColum].Value.ToString()).Count == 0)
                    {
                        MessageBox.Show("발주되지 않은 발주서입니다");
                        dgv.CurrentCell = dgv[1, 0];
                        return;
                    }
                    else
                    {
                        dgv입고등록리스트.Rows.Clear();
                        dgv.CurrentRow.Cells[0].Value = (DB.입고등록.GetCount() + 1).ToString();
                        //dgv.CurrentRow.Cells[2].Value = DB.공급업체.Get공급업체번호From발주서(dgv.Rows[nowRow].Cells[nowColum].Value.ToString());
                        dgv.CurrentRow.Cells[3].Value = DateTime.Today.ToShortDateString();
                        if (DB.입고등록.Is입고등록(dgv.CurrentRow.Cells[0].Value.ToString()).Count == 0)
                        {
                            ClassLibrary.입고등록 입고등록정보 = new ClassLibrary.입고등록();
                            입고등록정보.입고등록번호 = dgv.CurrentRow.Cells[0].Value.ToString();
                            입고등록정보.공급업체번호 = dgv.CurrentRow.Cells[2].Value.ToString();
                            입고등록정보.발주번호 = dgv.CurrentRow.Cells[1].Value.ToString();
                            입고등록정보.검사일자 = DateTime.Today;
                            DB.입고등록.Insert(입고등록정보);

                            MessageBox.Show("입고등록정보");
                            dgv.CurrentCell = dgv[nowColum, nowRow];
                            dgv.Rows.Add();
                            dgv입고등록리스트.Rows.Add();
                            dgv입고등록리스트.Focus();
                            dgv입고등록리스트.CurrentCell = dgv입고등록리스트[0, 0];
                        }
                    }
                }
            }
        }

        private void Dgv불량상세정보_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int nowColum = dgv.CurrentCell.ColumnIndex;
            int nowRow = dgv.CurrentCell.RowIndex;
            int maxRow = dgv.RowCount;
            int maxColum = dgv.ColumnCount;
            int 입고등록리스트nowRow = dgv입고등록리스트.CurrentCell.RowIndex;
            int result = 0;

            if (nowColum == 0)
            {
                if (dgv.Rows[nowRow].Cells[nowColum].Value == null)
                {
                    MessageBox.Show("데이터를 입력하세요");
                    return;
                }
                else
                {
                    DB.불량코드내역.Is불량코드내역(dgv.CurrentRow.Cells[0].Value.ToString());
                    return;
                }
            }

            if (nowColum == 1)
            {
                for (int i = 0; i < maxRow; i++)
                    result += int.Parse(dgv.Rows[i].Cells[1].Value.ToString());

                if (result < int.Parse(dgv입고등록리스트.Rows[입고등록리스트nowRow].Cells[2].Value.ToString()))
                {
                    dgv.Rows.Add();
                    dgv.CurrentCell = dgv[0, nowRow + 1];
                }

                else
                {
                    불량상세정보 불량상세정보 = new 불량상세정보();
                    불량상세정보.입고등록번호 = dgv입고등록.CurrentRow.Cells[0].Value.ToString();
                    불량상세정보.자재번호 =
                        DB.자재.Get자재번호(dgv입고등록리스트.Rows[입고등록리스트nowRow].Cells[0].Value.ToString()).Select(x => x.자재번호).FirstOrDefault();
                    for (int i = 0; i < maxRow; i++)
                    {
                        불량상세정보.불량코드번호 = dgv.Rows[i].Cells[0].Value.ToString();
                        불량상세정보.불량수량 = int.Parse(dgv.Rows[i].Cells[1].Value.ToString());
                        DB.불량상세정보.Insert(불량상세정보);
                    }
                    MessageBox.Show("불량상세정보");
                    dgv.Rows.Clear();

                    dgv입고등록리스트.Focus();
                    dgv입고등록리스트.CurrentCell = dgv입고등록리스트[0, maxRow];
                }

            }
        }

        private void Dgv입고등록_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            dgv.CurrentRow.Cells[0].ReadOnly = true;
            dgv.CurrentRow.Cells[2].ReadOnly = true;
            dgv.CurrentRow.Cells[3].ReadOnly = true;

            if (dgv.CurrentRow.Cells[0].Value == null)
            {
                dgv입고등록리스트.Rows.Clear();
                dgv불량상세정보.Rows.Clear();
            }
        }

        private void Dgv입고등록리스트_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int nowRow = dgv.CurrentCell.RowIndex;
            int nowColum = dgv.CurrentCell.ColumnIndex;
            int maxColum = dgv.ColumnCount;
            int maxRow = dgv.RowCount;
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (dgv.CurrentCell == dgv[maxColum - 1, nowRow])
                {
                    if (dgv.CurrentRow.Cells[2].Value == null) return;

                    if (int.Parse(dgv.CurrentRow.Cells[2].Value.ToString()) > 0)
                    {
                        dgv.Rows.Add();
                        dgv불량상세정보.Rows.Add();
                        dgv불량상세정보.Focus();
                        dgv불량상세정보.CurrentCell = dgv불량상세정보[0, 0];
                    }

                    else
                    {
                        dgv.Rows.Add();
                        dgv.Focus();
                        dgv.CurrentCell = dgv[0, maxRow];
                    }
                }
                else
                    dgv.CurrentCell = dgv[nowColum + 1, nowRow];
            }

            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
                if (DB.입고등록리스트.Search입고등록리스트(dgv입고등록.CurrentRow.Cells[0].Value.ToString()).Count > 0)
                {
                    var list =
                        DB.입고등록리스트.Search입고등록리스트(dgv입고등록.CurrentRow.Cells[0].Value.ToString());

                    입고등록리스트 입고등록리스트 = new 입고등록리스트();

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (DB.불량상세정보.Search불량상세정보(dgv입고등록.CurrentRow.Cells[0].Value.ToString(),
                            list[i].자재번호).Count > 0)
                        {
                            불량상세정보 불량상세정보 = new 불량상세정보();

                            var list1 = DB.불량상세정보.Search불량상세정보(dgv입고등록.CurrentRow.Cells[0].Value.ToString(),
                                list[i].자재번호);

                            불량상세정보.입고등록번호 = dgv입고등록.CurrentRow.Cells[0].Value.ToString();
                            불량상세정보.자재번호 = list[i].자재번호;

                            for (int j = 0; j < list1.Count; j++)
                            {
                                불량상세정보.불량코드번호 = list1[i].불량코드번호;
                                불량상세정보.불량수량 = list1[i].불량수량;
                                DB.불량상세정보.Delete(불량상세정보);
                            }
                        }

                        입고등록리스트.입고등록번호 = list[i].입고등록번호;
                        입고등록리스트.자재번호 = list[i].자재번호;
                        var list3 = DB.자재.Get자재(입고등록리스트.자재번호).FirstOrDefault();
                        list3.재고량 -= (int)list[i].양품수량;
                        DB.자재.Update(list3);
                        입고등록리스트.양품수량 = list[i].양품수량;
                        입고등록리스트.불량수량 = list[i].불량수량;
                        DB.입고등록리스트.Delete(입고등록리스트);
                    }
                    dgv불량상세정보.Rows.Clear();
                    dgv.Rows.Clear();
                    dgv.Rows.Add();
                    var list2 = DB.입고등록리스트.Search입고등록리스트(dgv입고등록.CurrentRow.Cells[0].Value.ToString());
                    for (int i = 0; i < list2.Count; i++)
                    {
                        dgv입고등록리스트.Rows[i].Cells[0].Value = list2[i].자재번호;
                        dgv입고등록리스트.Rows[i].Cells[1].Value = list2[i].양품수량;
                        dgv입고등록리스트.Rows[i].Cells[2].Value = list2[i].불량수량;
                        if (i != list2.Count)
                            dgv입고등록리스트.Rows.Add();
                    }

                }
            }
        }

        private void Dgv입고등록_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
                if (DB.입고등록.Is입고등록(dgv.CurrentRow.Cells[0].Value.ToString()).Count > 0)
                {
                    ClassLibrary.입고등록 입고등록 = new ClassLibrary.입고등록();
                    입고등록.입고등록번호 = dgv.CurrentRow.Cells[0].Value.ToString();
                    입고등록.발주번호 = dgv.CurrentRow.Cells[1].Value.ToString();
                    입고등록.공급업체번호 = dgv.CurrentRow.Cells[2].Value.ToString();
                    입고등록.검사일자 = DateTime.Parse(dgv.CurrentRow.Cells[3].Value.ToString());

                    if (DB.입고등록리스트.Search입고등록리스트(dgv.CurrentRow.Cells[0].Value.ToString()).Count > 0)
                    {
                        var list =
                            DB.입고등록리스트.Search입고등록리스트(dgv.CurrentRow.Cells[0].Value.ToString());

                        입고등록리스트 입고등록리스트 = new 입고등록리스트();
                        for (int i = 0; i < list.Count; i++)
                        {

                            if (DB.불량상세정보.Search불량상세정보(dgv.CurrentRow.Cells[0].Value.ToString(),
                                list[i].자재번호).Count > 0)
                            {
                                불량상세정보 불량상세정보 = new 불량상세정보();

                                var list1 = DB.불량상세정보.Search불량상세정보(dgv.CurrentRow.Cells[0].Value.ToString(),
                                    list[i].자재번호);

                                불량상세정보.입고등록번호 = dgv.CurrentRow.Cells[0].Value.ToString();
                                불량상세정보.자재번호 = list[i].자재번호;

                                for (int j = 0; j < list1.Count; j++)
                                {
                                    불량상세정보.불량코드번호 = list1[j].불량코드번호;
                                    불량상세정보.불량수량 = list1[j].불량수량;
                                    DB.불량상세정보.Delete(불량상세정보);
                                }
                            }

                            입고등록리스트.입고등록번호 = list[i].입고등록번호;
                            입고등록리스트.자재번호 = list[i].자재번호;
                            입고등록리스트.양품수량 = list[i].양품수량;


                            입고등록리스트.불량수량 = list[i].불량수량;
                            DB.입고등록리스트.Delete(입고등록리스트);
                        }
                    }
                    DB.입고등록.Delete(입고등록);

                    dgv입고등록.Rows.Clear();
                    dgv입고등록.Rows.Add();

                    var list2 = DB.입고등록.입고등록정보(txb거래처이름.Text, txb발주번호.Text,
                       FirstDate.Value, LastDate.Value);

                    for (int i = 0; i < list2.Count; i++)
                    {
                        dgv입고등록.Rows[i].Cells[0].Value = list2[i].입고등록번호;
                        dgv입고등록.Rows[i].Cells[1].Value = list2[i].발주번호;
                        dgv입고등록.Rows[i].Cells[2].Value = list2[i].공급업체번호;
                        dgv입고등록.Rows[i].Cells[3].Value = list2[i].검사일자;
                        dgv입고등록.Rows.Add();
                    }
                }
            }
        }

        private void Dgv불량상세정보_KeyDown(object sender, KeyEventArgs e)
        {
            int nowRow = dgv불량상세정보.CurrentCell.RowIndex;
            int nowColum = dgv불량상세정보.CurrentCell.ColumnIndex;
            int maxColum = dgv불량상세정보.ColumnCount;
            int maxRow = dgv불량상세정보.RowCount;

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (dgv불량상세정보.CurrentCell == dgv불량상세정보[maxColum - 1, maxRow - 1])
                    return;

                else
                    dgv불량상세정보.CurrentCell = dgv불량상세정보[nowColum + 1, nowRow];
            }

            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
                if (DB.불량상세정보.Search불량상세정보(dgv입고등록.CurrentRow.Cells[0].Value.ToString(),
                                dgv입고등록리스트.CurrentRow.Cells[0].Value.ToString()).Count > 0)
                {
                    불량상세정보 불량상세정보 = new 불량상세정보();

                    var list1 =
                        DB.불량상세정보.Search불량상세정보(dgv입고등록.CurrentRow.Cells[0].Value.ToString(),
                                dgv입고등록리스트.CurrentRow.Cells[0].Value.ToString());

                    불량상세정보.입고등록번호 = dgv입고등록리스트.CurrentRow.Cells[0].Value.ToString();
                    불량상세정보.자재번호 = dgv입고등록리스트.CurrentRow.Cells[0].Value.ToString();

                    for (int j = 0; j < list1.Count; j++)
                    {
                        불량상세정보.불량코드번호 = list1[j].불량코드번호;
                        불량상세정보.불량수량 = list1[j].불량수량;
                        DB.불량상세정보.Delete(불량상세정보);
                    }

                    dgv불량상세정보.Rows.Clear();
                    dgv불량상세정보.Rows.Add();
                }
            }
        }
    }
}

