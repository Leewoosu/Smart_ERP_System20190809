using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMART_ERP_System.Class
{
    public class InputDate
    {
        public DateTime Date { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public string DayText { get; set; }

        /// <summary>
        /// 연, 월, 일을 매개변수로 그 해당 일이 맞는지 여부확인
        /// </summary>
        /// <param name="iYear"> 년도</param>
        /// <param name="iMonth"> 월</param>
        /// <param name="iDay"> 일</param>
        /// <returns>연, 월, 일의 해당 날짜가 아닌 경우 입력된 해당 월의 마지막날로 입력됨</returns>
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
                DayText = iLastDay.ToString();
                return false;
            }

            return true;
        }
    }
}
