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

        public void Search(string EmployeeCode, out string code, out string name)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                code = entities.사원등록.Where(x => x.사원코드 == EmployeeCode).ToList().Select(x => x.사원코드).FirstOrDefault();

                name = entities.사원등록.Where(x => x.사원코드 == EmployeeCode).ToList().Select(x => x.사원명).FirstOrDefault();
            }
        }

        public string SearchChangedValue(string value)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.사원등록.Where(x => x.사원코드 == value).ToList().Select(x => x.사원명).FirstOrDefault();
            }
        }
    }
}
