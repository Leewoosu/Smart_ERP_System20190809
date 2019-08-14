using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 공급업체Data : EntityData<공급업체>
    {
        public string Get공급업체번호(string 자재번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.공급업체
                            where x.자재번호 == 자재번호
                            select x;

                return query.Select(x => x.공급업체번호).First().ToString();
            }
        }
    }
}
