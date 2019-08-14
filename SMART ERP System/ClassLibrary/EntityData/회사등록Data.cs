using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 회사등록Data : EntityData<회사등록>
    {
        public string Search(string code)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.회사등록.Where(x => x.회사코드 == code).ToList().Select(x => x.회사명).FirstOrDefault();
            }
        }
    }
}
