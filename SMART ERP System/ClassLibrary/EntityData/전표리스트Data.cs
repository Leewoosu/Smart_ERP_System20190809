using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary.EntityData
{
    public class 전표리스트Data : EntityData<전표리스트>
    {
        /// <summary>
        /// 전표번호와 일치하는 전표리스트를 가져옴
        /// </summary>
        /// <param name="number"> 전표번호</param>
        /// <returns> 전표리스트 반환</returns>
        public List<전표리스트> SearchList(DateTime date, string number)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                var query = from x in entities.전표리스트
                            where x.전표.전표번호 == number
                            select x;

                List<전표리스트> list = query.ToList();

                list = list.Where(x => x.입력날짜.ToShortDateString() == date.ToShortDateString()).ToList();

                return list;
            }
        }

        public List<전표리스트> SearchPeriod(DateTime dtpFrom, DateTime dtpTo)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                var query = from x in entities.전표리스트
                            //where dtpFrom <= x.입력날짜 && x.입력날짜 <= dtpTo
                            select new
                            {
                                x,
                                x.계정과목.계정과목명,
                                차변 = 0,
                                대변 = 0,
                                차변합계 = 0,
                                대변합계 = 0,
                                건수 = 0,
                                전표상태 = x.전표.승인상태,
                                전표유형 = x.전표.유형
                            };

                var list = query.ToList();

                list = list.Where(x => dtpFrom <= x.x.입력날짜 && x.x.입력날짜 <= dtpTo).ToList();
                MessageBox.Show(list.Count.ToString());
                foreach (var item in list)
                {
                    item.x.계정과목명 = item.계정과목명;
                    item.x.전표상태 = item.전표상태;
                    item.x.전표유형 = item.전표유형;
                    item.x.거래처명 = DB.거래처.Search(item.x.거래처코드번호);

                    if (item.x.구분 == "차변" || item.x.구분 == "입금")
                    {
                        item.x.차변 = list.Select(x => x.x.금액).FirstOrDefault();
                    }
                    else
                    {
                        item.x.차변 = null;
                    }

                    if (item.x.구분 == "대변" || item.x.구분 == "출금")
                    {
                        item.x.대변 = list.Select(x => x.x.금액).FirstOrDefault();
                    }
                    else
                    {
                        item.x.대변 = null;
                    }
                }

                return list.ConvertAll(x => x.x);
            }
        }

        public List<전표리스트> SearchPeriod(DateTime dtpTo)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                var query = from x in entities.전표리스트
                            where x.입력날짜 <= dtpTo.Date
                            select new
                            {
                                x,
                                x.계정과목.계정과목명,
                                차변 = 0,
                                대변 = 0,
                                차변합계 = 0,
                                대변합계 = 0,
                                건수 = 0,
                                전표상태 = x.전표.승인상태,
                                전표유형 = x.전표.유형
                            };

                var list = query.ToList();
                
                foreach (var item in list)
                {
                    item.x.계정과목명 = item.계정과목명;
                    item.x.전표상태 = item.전표상태;
                    item.x.전표유형 = item.전표유형;
                    item.x.거래처명 = DB.거래처.Search(item.x.거래처코드번호);

                    if (item.x.구분 == "차변" || item.x.구분 == "입금")
                    {
                        item.x.차변 = list.Select(x => x.x.금액).FirstOrDefault();
                    }
                    else
                    {
                        item.x.차변 = null;
                    }

                    if (item.x.구분 == "대변" || item.x.구분 == "출금")
                    {
                        item.x.대변 = list.Select(x => x.x.금액).FirstOrDefault();
                    }
                    else
                    {
                        item.x.대변 = null;
                    }
                }

                return list.ConvertAll(x => x.x);
            }
        }

        /// <summary>
        /// 기존 데이터의 변경여부 확인을 위해 리스트에 채움
        /// </summary>
        /// <param name="dateTime">입력일자</param>
        /// <param name="gridView">해당 DataGridView</param>
        /// <param name="전표리스트s">List 전표리스트</param>
        /// <param name="number">전표번호</param>
        /// <param name="i">해당 개수</param>
        public void FillIn전표리스트List(DateTime dateTime, DataGridView gridView, List<전표리스트> 전표리스트s, string number, int cnt)
        {
            for (int i = 0; i < cnt+1; i++)
            {
                if (gridView.Rows[i].Cells[gridView.Columns.Count - 1].Value != null)
                {
                    전표리스트 list = new 전표리스트();

                    if (gridView.Rows[i].Cells[0].Value != null)
                        list.순번 = int.Parse(gridView.Rows[i].Cells[0].Value.ToString());

                    if (gridView.Rows[i].Cells[1].Value != null)
                        list.구분 = gridView.Rows[i].Cells[1].Value.ToString();

                    if (gridView.Rows[i].Cells[2].Value != null)
                        list.계정과목코드번호 = gridView.Rows[i].Cells[2].Value.ToString();

                    if (gridView.Rows[i].Cells[4].Value != null)
                        list.거래처코드번호 = gridView.Rows[i].Cells[4].Value.ToString();

                    if (gridView.Rows[i].Cells[7].Value != null)
                        list.금액 = int.Parse(gridView.Rows[i].Cells[7].Value.ToString());

                    if (gridView.Rows[i].Cells[8].Value != null)
                        list.적요명 = gridView.Rows[i].Cells[8].Value.ToString();

                    list.입력날짜 = dateTime;
                    list.전표번호 = number;

                    전표리스트s.Add(list);
                }
            }
        }

        public List<전표리스트> GetAllMatchedNumber(string number)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                List<전표리스트> list = entities.전표리스트.Where(x => x.전표번호 == number).ToList();

                if (list == null)
                    return null;

                return list;
            }
        }

        /// <summary>
        /// 기존 데이터 중 변경된 데이터가 있을 경우 인덱스를 담은 리스트 반환
        /// </summary>
        /// <param name="전표리스트s">List 전표리스트1</param>
        /// <param name="listForCheck2">List 전표리스트2</param>
        /// <param name="cnt">개수</param>
        /// <param name="result">변경된 데이터가 있는 Index를 담은 리스트</param>
        public void UpdateNonOverlapList(List<전표리스트> 전표리스트s, List<전표리스트> listForCheck2, int cnt, out List<int> result)
        {
            result = new List<int>();

            for (int i = 0; i < cnt+1; i++)
            {
                if (
                    (listForCheck2[i].전표번호 == 전표리스트s[i].전표번호) &&
                    (listForCheck2[i].입력날짜.ToShortDateString() == 전표리스트s[i].입력날짜.ToShortDateString()) &&
                    (listForCheck2[i].순번 == 전표리스트s[i].순번) &&
                    (listForCheck2[i].구분 == 전표리스트s[i].구분) &&
                    (listForCheck2[i].계정과목코드번호 == 전표리스트s[i].계정과목코드번호) &&
                    (listForCheck2[i].거래처코드번호 == 전표리스트s[i].거래처코드번호) &&
                    (listForCheck2[i].금액 == 전표리스트s[i].금액) &&
                    (listForCheck2[i].적요명 == 전표리스트s[i].적요명)
                   )
                    continue;
                else
                    result.Add(i);
            }
        }
    }
}
