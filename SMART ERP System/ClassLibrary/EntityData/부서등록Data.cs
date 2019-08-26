using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 부서등록Data : EntityData<부서등록>
    {
        public List<부서등록> FillIn(string workPlaceCode)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                var list = entities.부서등록.ToList();

                foreach (var item in list)
                {
                    item.사업장명 = DB.사업장.Search(workPlaceCode);

                    item.부문명 = DB.부문.Search(item.부문코드);
                }

                return list;
            }
        }

        public string SearchChangedValue(string value)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.부서등록.Where(x => x.부서코드 == value).ToList().Select(x => x.부서명).FirstOrDefault();
            }
        }
    }
}
