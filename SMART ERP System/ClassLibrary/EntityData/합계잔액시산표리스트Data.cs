using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary.EntityData
{
    public class 합계잔액시산표리스트Data : EntityData<합계잔액시산표리스트>
    {
        public bool IsExist(DateTimePicker dtp입력날짜)
        {
            var list = DB.합계잔액시산표리스트.GetAll();

            foreach (var item in list)
            {
                if (item.기간.ToShortDateString() == dtp입력날짜.Value.ToShortDateString())
                    return true;
            }

            return false;
        }

        public int SearchNum(DateTime value)
        {
            var list = DB.합계잔액시산표리스트.GetAll();

            return list.Where(x => x.기간.ToShortDateString() == value.ToShortDateString()).Select(x => x.합계잔액시산표No).FirstOrDefault();
        }
    }
}
