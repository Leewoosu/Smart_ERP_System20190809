using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 입고등록Data : EntityData<입고등록>
    {       
        public List<입고등록> Is입고등록(string 입고등록정보)
        {
            using(ERPEntities context = new ERPEntities())
            {
                var query = from x in context.입고등록
                            where x.입고등록번호 == 입고등록정보
                            select x;

                return query.ToList();
            }
        }

        public List<입고등록> 입고등록정보(string 공급처이름, string 발주번호,
            DateTime FirstDate, DateTime LastDate)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.입고등록
                            where x.검사일자 <= LastDate && x.검사일자 >= FirstDate
                            select x;

                if (string.IsNullOrEmpty(공급처이름) == false)
                {
                    var query1 = from x in query
                                 where  x.공급업체번호 == 공급처이름
                                 select x;

                    if (string.IsNullOrEmpty(발주번호) == false)
                    {
                        var query2 = from x in query1
                                     where x.발주번호 == 발주번호
                                     select x;

                        return query2.ToList();
                    }

                    return query1.ToList();
                }
                else
                {
                    if (string.IsNullOrEmpty(발주번호) == false)
                    {
                        var query1 = from x in query
                                     where x.발주번호 == 발주번호
                                     select x;

                        return query1.ToList();
                    }

                    return query.ToList();
                }
            }
        }

        public List<입고등록> Search입고등록(string 공급업체, string 입고등록번호, DateTime OrderStart, DateTime OrderLast)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.입고등록
                            where x.검사일자 > OrderStart && x.검사일자 < OrderLast
                            select x;

                if (string.IsNullOrEmpty(입고등록번호) == false)
                {
                    var query1 = from x in query
                                 where x.공급업체번호 == 입고등록번호
                                 select x;
                    if (string.IsNullOrEmpty(공급업체) == false)
                    {
                        var query2 = from x in query1
                                     where x.공급업체번호 == context.일반거래처등록.Where(y => y.거래처명 == 공급업체).Select(y => y.거래처코드번호).FirstOrDefault()
                                     select x;

                        return query2.ToList();
                    }
                    return query1.ToList();
                }
                else
                {
                    if (string.IsNullOrEmpty(공급업체) == false)
                    {
                        var query2 = from x in query
                                     where x.공급업체번호 == context.일반거래처등록.Where(y => y.거래처명 == 공급업체).Select(y => y.거래처코드번호).FirstOrDefault()
                                     select x;

                        return query2.ToList();
                    }
                    return query.ToList();
                }
            }
        }

        public List<입고등록> Get입고등록번호(string 발주번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.입고등록
                            where x.발주번호 == 발주번호
                            select x;

                return query.ToList();
            }
        }
    }
}
