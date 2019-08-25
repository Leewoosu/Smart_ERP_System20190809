using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 사업장Data : EntityData<사업장등록>
    {
        public string SearchChangedValue(string code)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.사업장등록.Where(x => x.사업장코드 == code)
                    .ToList()
                    .Select(x => x.사업장명)
                    .FirstOrDefault();
            }
        }

        public string Search(string workPlaceCode)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.사업장등록.Where(x => x.사업장코드 == workPlaceCode)
                    .Select(x => x.사업장명).FirstOrDefault();
            }
        }

        public 사업장등록 GetDetails(string code)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.사업장등록.Where(x => x.사업장코드 == code).FirstOrDefault();
            }
        }

        public string SearchCode(string name)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.관할세무서.Where(x => x.관할세무서명.StartsWith(name)).Select(x=>x.관할세무서코드).FirstOrDefault();
            }
        }
    }
}
