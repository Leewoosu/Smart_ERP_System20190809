using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 자재전표Data : EntityData<자재전표>
    {
        public List<자재전표> Search자재전표(string 입고등록번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재전표
                            where x.입고등록번호 == 입고등록번호
                            select x;

                return query.ToList();
            }
        }

        public List<자재전표> 자재전표조회(string 공급업체이름)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재전표
                            select x;

                if (string.IsNullOrEmpty(공급업체이름) == false)
                {
                    string 공급업체번호 = DB.일반거래처.Get공급업체번호From이름(공급업체이름).Select(x => x.거래처코드번호).FirstOrDefault();
                    var query1 = from x in query
                                 where x.거래처번호 == 공급업체번호
                                 select x;
                    return query1.ToList();
                }

                return query.ToList();
            }
        }
    }
}
