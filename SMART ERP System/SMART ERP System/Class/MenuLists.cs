using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMART_ERP_System.Class
{
    public static class MenuLists
    {
        public static List<string> month;
        public static List<string> menuItems;
        public static List<string> separations;
        public static List<string> status;
        public static List<string> types;


        /// <summary>
        /// 메뉴에 넣을 아이템을 초기화
        /// </summary>
        public static void Set()
        {
            month = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            menuItems = new List<string> { "일반", "매입", "매출", "수금", "수정", "결산" };

            separations = new List<string> { "전체", "출금", "입금", "대체" };

            status = new List<string> { "전체", "승인", "미결" };

            types = new List<string> { "전체", "일반", "매입", "매출", "수금", "수정", "결산" };
        }
    }
}
