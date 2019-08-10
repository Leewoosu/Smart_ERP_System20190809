using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMART_ERP_System.Class
{
    public static class MenuLists
    {
        public static List<string> Month;
        public static List<string> menuItems;

         public static void Set()
        {
            Month = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            menuItems = new List<string> { "일반", "매입", "매출", "수금", "수정", "결산" };
        }
    }
}
