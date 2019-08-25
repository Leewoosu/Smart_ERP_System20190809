using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 불량상세정보Data : EntityData<불량상세정보>
    {      
        public List<불량상세정보> Search불량상세정보(string 입고등록번호, string 자재번호)
        {
            using(ERPEntities context = new ERPEntities())
            {
                var query = from x in context.불량상세정보
                            where x.입고등록번호 == 입고등록번호 && x.자재번호 == 자재번호
                            select x;

                return query.ToList();
            }
        }
    }
}
