using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary.EntityData
{
    public class 발주리스트Data : EntityData<발주리스트>
    {


        public List<발주리스트> Search발주리스트(string 발주번호)
        {
            using(ERPEntities context = new ERPEntities())
            {
                var query = from x in context.발주리스트
                            where x.발주번호 == 발주번호
                            select x;

                return query.ToList();
            }
        }
    }
}

