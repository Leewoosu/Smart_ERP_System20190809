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
                                     //where x.납품업체.납품업체명 == 납품업체이름
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
                                    // where x.납품업체.납품업체명 == 납품업체이름
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
                            where x.주문일 <= LastDate && x.주문일 >= FirstDate
                            select x;

                if (string.IsNullOrEmpty(제품이름) == false)
                {
                    var query1 = from x in query
                                 where x.제품.제품명 == 제품이름
                                 select x;

                    return query1.ToList();
                }

                return query.ToList();
            }
        }
        public List<int> Get주문수량()
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.수주
                            select x;

                return query.Select(x => x.주문수량).ToList();
            }
        }
    }
}
