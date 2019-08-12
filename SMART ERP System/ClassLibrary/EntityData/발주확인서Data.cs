using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 발주확인서Data : EntityData<발주확인서>
    {
        public void Register발주확인서(string 발주서번호, string 자재번호)
        {
            발주확인서 발주확인서 = new 발주확인서();

            발주확인서.발주확인서번호 = 발주서번호;
            발주확인서.공급업체번호 = DB.공급업체.Get공급업체번호(자재번호);
            발주확인서.배송날짜 = DateTime.Today;

            Insert(발주확인서);
        }

    }
}
