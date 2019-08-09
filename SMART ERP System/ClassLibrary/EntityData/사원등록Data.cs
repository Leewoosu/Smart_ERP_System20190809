using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 사원등록Data : EntityData<사원등록>
    {
        public void Check(string id, out int employeeCnt, out string employeeName)
        {
            using (ERPEntities entity = new ERPEntities())
            {
                employeeCnt = entity.사원등록.Where(x => x.사원코드 == id).ToList().Count;

                employeeName = entity.사원등록.Where(x => x.사원코드 == id).Select(x => x.사원명).ToList().FirstOrDefault();
            }
        }

        public void Check(string id, string pwd, out int employeeCnt)
        {
            using (ERPEntities entity = new ERPEntities())
            {
                employeeCnt = entity.사원등록.Where(x => x.사원코드 == id && x.암호 == pwd).ToList().Count;
            }
        }
    }
}
