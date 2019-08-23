using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 자재상세전표Data : EntityData<자재상세전표>
    {
        public List<자재상세전표> Search자재상세전표(string 자재전표번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재상세전표
                            where x.자재전표번호 == 자재전표번호
                            select x;

                return query.ToList();
            }
        }
    }
}
