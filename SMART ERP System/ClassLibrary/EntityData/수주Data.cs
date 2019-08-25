using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary.EntityData
{
    public class 수주Data : EntityData<수주>
    {
        public List<수주> 조회(string 제품이름, string 납품업체이름, DateTime FirstDate, DateTime LastDate)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.수주
                            where x.주문일 <= LastDate && x.주문일 >= FirstDate
                            select x;

                if (string.IsNullOrEmpty(제품이름) == false)
                {
                    var query1 = from x in query
                                 where x.제품.제품명 == 제품이름
                                 select x;
                    if (string.IsNullOrEmpty(납품업체이름) == false)
                    {
                        var query2 = from x in query1
                                     where x.납품업체번호 == context.일반거래처등록.Where(y => y.거래처명 == 납품업체이름).Select(y => y.거래처코드번호).FirstOrDefault()
                                     select x;

                        return query2.ToList();
                    }
                    return query1.ToList();
                }
                else
                {
                    if (string.IsNullOrEmpty(납품업체이름) == false)
                    {
                        var query2 = from x in query
                                     where x.납품업체번호 == context.일반거래처등록.Where(y => y.거래처명 == 납품업체이름).Select(y => y.거래처코드번호).FirstOrDefault()
                                     select x;

                        return query2.ToList();
                    }
                }
                return query.ToList();
            }
        }

        public List<수주> GetAll(string 제품이름, DateTime FirstDate, DateTime LastDate)
        {
            using (ERPEntities context = new ERPEntities())
            {

                var query = from x in context.수주
                            where x.주문일 <= LastDate && x.주문일 >= FirstDate && x.잔량 > 0
                            select x;

                if (string.IsNullOrEmpty(제품이름) == false)
                {
                    var query1 = from x in query
                                 where x.제품.제품번호 == 제품이름
                                 select x;

                    return query1.ToList();
                }

                return query.ToList();
            }
        }

        public List<수주> Search수주(string 수주번호, string 수주번호2)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.수주
                            where x.수주번호 == 수주번호 && x.수주번호2 == 수주번호2
                            select x;

                return query.ToList();
            }
        }
    }
}
