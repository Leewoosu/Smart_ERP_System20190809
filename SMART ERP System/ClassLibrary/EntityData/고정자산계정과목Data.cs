using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 고정자산계정과목Data : EntityData<고정자산계정과목>
    {
        public string Search(string code)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.고정자산계정과목.Where(x => x.고정자산과목코드 == code).ToList().Select(x => x.고정자산과목명).FirstOrDefault();
            }
        }

        public string SearchangedValue(string value)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.고정자산계정과목.Where(x => x.고정자산과목코드 == value).ToList().Select(x => x.고정자산과목명).FirstOrDefault();
            }
        }
    }
}
