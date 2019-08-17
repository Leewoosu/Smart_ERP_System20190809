using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 자재명세서Data : EntityData<자재명세서>
    {
        public List<string> Get자재List()
        {
            using(ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재명세서
                            select x;

                return query.Select(x => x.자재번호).Distinct().ToList();
            }
        }

        public List<자재명세서> Get자재명세서(string 제품번호)
        {
            using(ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재명세서
                            where x.제품번호 == 제품번호
                            select x;

                return query.ToList();
            }
        }
    }
}
