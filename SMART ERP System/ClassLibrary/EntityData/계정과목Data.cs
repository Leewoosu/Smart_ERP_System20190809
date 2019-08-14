using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 계정과목Data : EntityData<계정과목>
    {
        public string SearchAccountName(string accountCode)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.계정과목.Where(x => x.계정과목코드번호 == accountCode).ToList().Select(x => x.계정과목명).FirstOrDefault();
            }
        }

        public List<계정과목> SearchCode(string code)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                var list = entities.계정과목.ToList();

                int.TryParse(code, out int result);

                if (result == 0)
                {
                   return entities.계정과목.Where(x => x.계정과목명.Replace(" ", "").StartsWith(code)).ToList();
                }

                return entities.계정과목.Where(x => x.계정과목코드번호.StartsWith(code)).ToList();
            }
        }
    }
}
