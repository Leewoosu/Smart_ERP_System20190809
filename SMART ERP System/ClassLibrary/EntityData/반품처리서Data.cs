using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 반품처리서Data : EntityData<반품처리서>
    {
        public List<반품처리서> Search반품처리서(string 반품처리서번호)
        {
            using(ERPEntities context = new ERPEntities())
            {
                var query = from x in context.반품처리서
                            where x.반품처리서번호 == 반품처리서번호
                            select x;
                
                return query.ToList();
            }
        }
        public List<반품처리서> Search반품처리서From입고등록번호(string 입고등록번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.반품처리서
                            where x.입고검사서번호 == 입고등록번호
                            select x;

                return query.ToList();
            }
        }
        public List<반품처리서> Search입고등록(string 공급업체, string 입고등록번호, DateTime OrderStart, DateTime OrderLast)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.반품처리서
                            where x.반품처리날짜 > OrderStart && x.반품처리날짜 < OrderLast
                            select x;

                if (string.IsNullOrEmpty(입고등록번호) == false)
                {
                    var query1 = from x in query
                                 where x.공급업체번호 == 입고등록번호
                                 select x;
                    if (string.IsNullOrEmpty(공급업체) == false)
                    {
                        var query2 = from x in query1
                                    // where x.공급업체.공급업체명 == 공급업체
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
                                     //where x.공급업체.공급업체명 == 공급업체
                                     select x;

                        return query2.ToList();
                    }
                    return query.ToList();
                }
            }
        }
    }
}
