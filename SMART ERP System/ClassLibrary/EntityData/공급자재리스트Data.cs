using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 공급자재리스트Data : EntityData<공급자재리스트>
    {
        public List<공급자재리스트> Search공급자재리스트(string 공급업체, string 자재)
        {
            using(ERPEntities context = new ERPEntities())
            {
                var query = from x in context.공급자재리스트
                            where x.공급업체번호 == 공급업체 && x.자재번호 == 자재
                            select x;

                return query.ToList();
            }
        }
        public string Get공급업체번호(string 자재번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.공급자재리스트
                            where x.자재번호 == 자재번호
                            select x;

                return query.Select(x => x.공급업체번호).First().ToString();
            }
        }
    }
}
