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
        public void 수주등록(object 수주값, string 수주번호, string 수주번호2)
        {
            int cnt = 수주정보(수주번호, 수주번호2).Count;

            if (cnt != 0)
            {
                MessageBox.Show("이미등록되어있는 기본키입니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            수주 Order = 수주값 as 수주;
            if (수주값 == null) return;

            DB.수주.Insert(Order);
            MessageBox.Show("등록되었습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public List<수주> 조회(string 제품이름, string 납품업체이름, int FirstDate, int LastDate)
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
                                     where x.납품업체.납품업체명 == 납품업체이름
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
                                     where x.납품업체.납품업체명 == 납품업체이름
                                     select x;

                        return query2.ToList();
                    }
                }
                return query.ToList();

            }
        }

        public List<수주> Search(string 수주번호, string 수주번호2)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.수주
                            where x.수주번호 == 수주번호 && x.수주번호2 == 수주번호2
                            select x;

                return query.ToList();
            }
        }

        public List<수주> 수주정보(string 수주번호, string 수주번호2)
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
