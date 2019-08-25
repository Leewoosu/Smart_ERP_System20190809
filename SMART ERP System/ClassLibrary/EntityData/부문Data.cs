using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 부문Data : EntityData<부문등록>
    {
        public string Search(string code)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.부문등록.Where(x => x.부문코드 == code).Select(x => x.부문명).FirstOrDefault();
            }
        }
    }
}
