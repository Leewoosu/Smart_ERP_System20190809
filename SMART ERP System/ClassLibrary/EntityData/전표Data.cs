using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary.EntityData
{
    public class 전표Data : EntityData<전표>
    {
        /// <summary>
        /// 입력일자가 일치하는 모든 데이터를 가져옴
        /// </summary>
        /// <param name="date"> 입력일자</param>
        /// <returns> 일치하는 모든 데이터의 리스트 </returns>
        public List<전표> GetAllMatchedDay(DateTime date)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                List<전표> list = entities.전표.Where(x => x.입력날짜 == date).ToList();

                if (list == null)
                    return null;

                list = list.OrderBy(x => int.Parse(x.전표번호)).ToList();

                return list;
            }
        }

        /// <summary>
        /// 기존 데이터의 변경여부 확인을 위해 리스트에 채움
        /// </summary>
        /// <param name="dateTime">입력일자</param>
        /// <param name="gridView">해당 DataGridView</param>
        /// <param name="전표s">List 전표</param>
        /// <param name="i">개수</param>
        public void FillIn전표List(DateTime dateTime, DataGridView gridView, List<전표> 전표s, int cnt)
        {
            for (int i = 0; i < cnt+1; i++)
            {
                전표 전표 = new 전표();

                전표.입력날짜 = dateTime;
                전표.전표번호 = gridView.Rows[i].Cells[2].Value.ToString();
                전표.품의내역 = gridView.Rows[i].Cells[3].Value.ToString();
                전표.유형 = gridView.Rows[i].Cells[4].Value.ToString();
                전표.기표번호 = gridView.Rows[i].Cells[5].Value.ToString();
                전표.승인상태 = gridView.Rows[i].Cells[6].Value.ToString();
                전표.승인자 = gridView.Rows[i].Cells[7].Value.ToString();
                if (gridView.Rows[i].Cells[8].Value != null)
                    전표.대차차액 = int.Parse(gridView.Rows[i].Cells[8].Value.ToString());
                전표.작업자 = gridView.Rows[i].Cells[9].Value.ToString();

                전표s.Add(전표);
            }
        }

        /// <summary>
        /// 기존 데이터 중 변경된 데이터가 있을 경우 인덱스를 담은 리스트 반환
        /// </summary>
        /// <param name="전표s">List 전표1</param>
        /// <param name="listforCheck">LIst 전표2</param>
        /// <param name="cnt">개수</param>
        /// <param name="resultIndex">변경된 데이터가 있는 Index를 담은 리스트</param>
        public void UpdateNonOverlapList(List<전표> 전표s, List<전표> listforCheck, int cnt, out List<int> resultIndex)
        {
            resultIndex = new List<int>();

            for (int i = 0; i < cnt+1; i++)
            {
                // 모두 일치하면 변경사항 없음
                if (
                    (listforCheck[i].입력날짜.ToShortDateString() ==
                    전표s[i].입력날짜.ToShortDateString()) &&
                    (listforCheck[i].전표번호 == 전표s[i].전표번호) &&
                    (listforCheck[i].품의내역 == 전표s[i].품의내역) &&
                    (listforCheck[i].유형 == 전표s[i].유형) &&
                    (listforCheck[i].기표번호 == 전표s[i].기표번호) &&
                    (listforCheck[i].승인상태 == 전표s[i].승인상태) &&
                    (listforCheck[i].승인자 == 전표s[i].승인자) &&
                    (listforCheck[i].대차차액 == 전표s[i].대차차액) &&
                    (listforCheck[i].작업자 == 전표s[i].작업자)
                   )
                    continue;
                else
                    resultIndex.Add(i);
            }
        }

        public List<전표> GetAllMatchedMonth(DateTime firstDay,DateTime lastDay)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.전표.Where(x => firstDay.Date <= x.입력날짜 && x.입력날짜 <= lastDay).ToList();
            }
        }
    }
}
