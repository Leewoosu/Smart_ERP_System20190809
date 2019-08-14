using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 부서등록Data : EntityData<부서등록>
    {
        public void Search(string Employeecode, out string code, out string name)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                code = entities.부서등록.Where(x => x.사원코드 == Employeecode).ToList().Select(x => x.부서코드).FirstOrDefault();

                name = entities.부서등록.Where(x => x.사원코드 == Employeecode).ToList().Select(x => x.부서명).FirstOrDefault();
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
