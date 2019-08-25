using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 일반거래처Data : EntityData<일반거래처등록>
    {
        public string Get공급업체번호From발주서(string 발주번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.일반거래처등록
                            where x.거래처코드번호 ==
                context.발주서.Where(y => y.발주번호 == 발주번호).
                    Select(y => y.공급업체번호).FirstOrDefault()
                            select x;

                return query.Select(x => x.거래처명).FirstOrDefault();
            }
        }

        public List<일반거래처등록> Get공급업체번호From이름(string 공급업체이름)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.일반거래처등록
                            where x.거래처명 == 공급업체이름
                            select x;

                return query.ToList();
            }
        }

        public string Get공급업체이름From번호(string 공급업체번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.일반거래처등록
                            where x.거래처코드번호 == 공급업체번호
                            select x;

                return query.Select(x => x.거래처명).First().ToString();
            }
        }

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
