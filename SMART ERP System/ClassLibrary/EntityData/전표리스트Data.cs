using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 전표리스트Data : EntityData<전표리스트>
    {
        public List<전표리스트> SearchList(object value)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                string number = value.ToString();

                var query = from x in entities.전표리스트
                            where x.전표번호 == number
                            select x;

                List<전표리스트> list = query.ToList();

                return list;
            }
        }
    }
}
