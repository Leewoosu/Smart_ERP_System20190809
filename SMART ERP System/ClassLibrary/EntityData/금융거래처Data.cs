using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 금융거래처Data : EntityData<금융거래처등록>
    {
        public void Search(string customerCode, out bool isEqual, out string name, out string number)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                var list = entities.금융거래처등록.Where(x => x.거래처코드번호 == customerCode).ToList();

                if (list == null)
                    isEqual = false;
                else
                    isEqual = true;

                name = list.Select(x => x.금융거래처명).FirstOrDefault();
                number = list.Select(x => x.사업자등록번호).FirstOrDefault();
            }
        }

        public string Search(string customerCode, out bool isEqual)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                var list = entities.금융거래처등록.Where(x => x.거래처코드번호 == customerCode).ToList();

                if (list == null)
                    isEqual = false;
                else
                    isEqual = true;

                return list.Select(x => x.금융거래처명).FirstOrDefault();
            }
        }

        public List<금융거래처등록> SearchCustomerCode(string text)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                var list = entities.금융거래처등록.ToList();

                int.TryParse(text, out int result);

                if (result == 0)
                {
                    return entities.금융거래처등록.Where(x => x.금융거래처명.Replace(" ", "").StartsWith(text)).ToList();
                }

                return entities.금융거래처등록.Where(x => x.금융거래처코드.StartsWith(text)).ToList();
            }
        }

        public 금융거래처등록 SearchCode(string code)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.금융거래처등록.Where(x => x.금융거래처코드 == code).ToList().FirstOrDefault();
            }
        }
    }
}
