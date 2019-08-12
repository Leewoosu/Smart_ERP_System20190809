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
                DayText = iLastDay.ToString();
                return false;
            }

            return true;
        }
    }
}
