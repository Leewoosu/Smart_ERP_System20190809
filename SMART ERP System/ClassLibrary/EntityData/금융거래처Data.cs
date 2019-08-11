using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 금융거래처Data : EntityData<금융거래처등록>
    {
        public void Search(string customerCode, out string name, out string number)
        {
            using (ERPEntities entities = new ERPEntities())
            {
               // name = entities.금융거래처등록.Where(x=> x.거래처코드번호 == customerCode).ToList//().Select(x => x.금융거래처명);

                //var query = from x in entities.금융거래처등록
                //            where x.거래처코드번호 == customerCode
                //            select new
                //            {
                //                x.금융거래처코드,
                //                x.거래처코드번호,
                //                x.금융거래처명,
                //                x.사업자등록번호
                //            };

                //query.ToList();

                //foreach (var item in query)
                //{
                //    name = item.금융거래처명;
                //    number = item.사업자등록번호;
                //}
            }
        }
    }
}
