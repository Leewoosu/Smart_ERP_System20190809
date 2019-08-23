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

        public List<발주리스트> Search발주리스트(string 발주번호, string 자재이름)
        {
            using (ERPEntities context = new ERPEntities())
            {
                string 자재번호 = 0.ToString();

                if (DB.자재.Get자재번호(자재이름).Count != 0)
                    자재번호 = DB.자재.Get자재번호(자재이름).Select(x => x.자재번호).First();

                var query = from x in context.발주리스트
                            where x.발주번호 == 발주번호 && x.자재번호 == 자재번호
                            select x;

                return query.ToList();

            }
        }
    }
}

