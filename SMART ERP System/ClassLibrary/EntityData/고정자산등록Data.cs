using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 고정자산등록Data : EntityData<고정자산>
    {
        public 고정자산 SearchCode(string code)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.고정자산.Where(x => x.고정자산코드 == code).ToList().FirstOrDefault();
            }
        }
    }
}