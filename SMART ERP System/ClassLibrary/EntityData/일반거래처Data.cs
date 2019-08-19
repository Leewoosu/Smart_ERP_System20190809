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

                name = list.Select(x => x.거래처명).FirstOrDefault();
                number = list.Select(x => x.사업자등록번호).FirstOrDefault();
            }
        }

        public string Search(string customerCode, out bool isEqual)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                var list = entities.일반거래처등록.Where(x => x.거래처코드번호 == customerCode).ToList();

                if (list == null)
                    isEqual = false;
                else
                    isEqual = true;

                return list.Select(x => x.거래처명).FirstOrDefault();
            }
        }

        public List<일반거래처등록> SearchCustomerCode(string text)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                var list = entities.일반거래처등록 .ToList();

                int.TryParse(text, out int result);

                if (result == 0)
                {
                    return entities.일반거래처등록.Where(x => x.거래처명.Replace(" ", "").StartsWith(text)).ToList();
                }

                return entities.일반거래처등록.Where(x => x.거래처코드번호.StartsWith(text)).ToList();
            }
        }

        public string NormalSearch(string Code)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.일반거래처등록.Where(x => x.일반거래처코드 == Code).ToList().Select(x => x.거래처명).FirstOrDefault();
            }

        }

        public List<일반거래처등록> 검색(string code)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.일반거래처등록.Where(x => x.거래처명 == code).ToList();
            }
        }

        public string SearchChangedValue(string value)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.일반거래처등록.Where(x => x.일반거래처코드 == value).ToList().Select(x => x.거래처명).FirstOrDefault();
            }
        }

        public 일반거래처등록 SearchCode(string code)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.일반거래처등록.Where(x => x.일반거래처코드 == code).ToList().FirstOrDefault();
            }
        }
    }
}
