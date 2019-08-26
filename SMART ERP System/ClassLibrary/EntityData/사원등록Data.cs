using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 사원등록Data : EntityData<사원등록>
    {
        public void SearchDepartment(string Employeecode, out string code, out string name)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                string resCode = entities.사원등록.Where(x => x.사원코드 == Employeecode).Select(x => x.부서코드).FirstOrDefault();

                code = resCode;
                name = entities.부서등록.Where(x => x.부서코드 == resCode).Select(x => x.부서명).FirstOrDefault();    
            }
        }

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
        public bool Is사원코드(string 사원코드)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.사원등록
                            where x.사원코드 == 사원코드
                            select x;

                if (query.ToList().Count > 0) return true;
                else return false;
            }
        }

        public List<사원등록> Get사원정보(string 사원코드)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.사원등록
                            where x.사원코드 == 사원코드
                            select x;

                return query.ToList();
            }
        }
        public List<사원등록> Get사원정보(string 사원코드, string 사원명)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.사원등록
                            select x;

                if (string.IsNullOrEmpty(사원코드) == false)
                {
                    var query1 = from x in context.사원등록
                                 where x.부서코드 == 사원코드
                                 select x;

                    if (string.IsNullOrEmpty(사원명) == false)
                    {
                        var query2 = from x in context.사원등록
                                     where x.사원명 == 사원명
                                     select x;
                        return query2.ToList();
                    }
                    return query1.ToList();
                }
                else
                {
                    if (string.IsNullOrEmpty(사원명) == false)
                    {
                        var query2 = from x in query
                                     where x.사원명 == 사원명
                                     select x;
                        return query2.ToList();
                    }
                    return query.ToList();
                }


            }
        }
    }
}
