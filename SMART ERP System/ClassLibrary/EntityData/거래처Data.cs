using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 거래처Data : EntityData<거래처>
    {
        public void Search(string customerCode, out string name, out string number)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                string code = entities.거래처.Where(x => x.거래처코드번호 == customerCode).Select(x => x.거래처코드번호).ToList().ToString();

                DB.금융거래처.Search(code, out bool isEqual1, out string name1, out string number1);
                DB.일반거래처.Search(code, out bool isEqual2, out string name2, out string number2);

                name = null;
                number = null;

                if(isEqual1 == true)
                {
                    name = name1;
                    number = number1;
                }

                if(isEqual2 == true)
                {
                    name = name2;
                    number = number2;
                }
            }
        }
    }
}
