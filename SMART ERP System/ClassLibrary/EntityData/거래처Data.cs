using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 거래처Data : EntityData<거래처>
    {
        public object Search(string customerCode)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                string code = entities.거래처.Where(x => x.거래처코드번호 == customerCode).Select(x => x.거래처코드번호).ToList().ToString();

                DB.금융거래처.Search(code, out string name1, out string number1);
                DB.일반거래처.Search(code, out string name1, out string number1);

                
            }
        }
    }
}
