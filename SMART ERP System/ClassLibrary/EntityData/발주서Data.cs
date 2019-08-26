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

        public List<발주서> Search발주서(DateTime 주문일)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.발주서
                            where x.주문날짜 == 주문일
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
                                 context.일반거래처등록.Where(y => y.거래처명 == 거래처이름).
                                 Select(y => y.거래처코드번호).FirstOrDefault().ToString()
                                 select x;

                    return query1.ToList();
                }

                else
                    return query.ToList();
            }
        }
    }
}
