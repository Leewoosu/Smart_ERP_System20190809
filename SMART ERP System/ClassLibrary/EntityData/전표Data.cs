using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 전표Data : EntityData<전표>
    {
        public List<전표> GetAllMatchedDay(DateTime date)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                List<전표> list = entities.전표.Where(x => x.입력날짜 == date).ToList();

                if (list == null)
                    return null;

                return list;
            }
        }
    }
}
