using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 계정과목등록Data : EntityData<계정과목등록>
    {
        public 계정과목등록 Search(string key)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.계정과목등록.Where(x => x.CodeNum == key).ToList().FirstOrDefault();
            }
        }
    }
}
