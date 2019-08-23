using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 발주서Data : EntityData<발주서>
    {
        public List<발주서> Is발주번호(string 발주번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.발주서
                            where x.발주번호 == 발주번호
                            select x;

                return query.ToList();
            }
        }

        public List<발주서> Search발주서(string 거래처이름, DateTime OrderFirstDate,
            DateTime OrderLastDate, DateTime DeliveryFirstDate, DateTime DeliveryLastDate)
        {
            using (ERPEntities context = new ERPEntities())
            {

                var query = from x in context.발주서
                            where x.주문날짜 <= OrderLastDate && x.주문날짜 >= OrderFirstDate
                            && x.납기일 <= DeliveryLastDate && x.납기일 >= DeliveryFirstDate
                            select x;

                if (string.IsNullOrEmpty(거래처이름) == false)
                {
                    var query1 = from x in query
                                 where x.공급업체번호 ==
                                 context.납품업체.Where(y => y.납품업체명 == 거래처이름).
                                 Select(y => y.납품업체번호).FirstOrDefault().ToString()
                                 select x;

                    return query1.ToList();
                }

                else
                    return query.ToList();
            }
        }
        public List<발주서> Search발주번호(string 자재번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.공급자재리스트
                            where x.자재번호 == 자재번호
                            select x;

                string 공급업체번호 = query.Select(x => x.공급업체번호).First().ToString();

                var query1 = from x in context.발주서
                             where x.공급업체번호 == 공급업체번호
                             select x;

                return query1.ToList();
            }
        }
    }
}
