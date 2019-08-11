using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 일반거래처Data : EntityData<일반거래처등록>
    {
        public void Search(string customerCode, out bool isEqual, out string name, out string number)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                var list = entities.일반거래처등록.Where(x => x.거래처코드번호 == customerCode).ToList();

                if (list == null)
                    isEqual = false;
                else
                    isEqual = true;

                name = list.Select(x => x.거래처명).ToString();
                number = list.Select(x => x.사업자등록번호).ToString();
            }
        }
    }
}
