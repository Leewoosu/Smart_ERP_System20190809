using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 자재Data : EntityData<자재>
    {
        public string Get자재이름(string 자재번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재
                            where x.자재번호 == 자재번호
                            select x;
                if (query.ToList().Count == 0) return "0";
                else
                    return query.Select(x => x.자재명).FirstOrDefault().ToString();
            }
        }

        public List<자재> GetAll(string 제품번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재명세서
                            where x.제품번호 == 제품번호
                            select x;

                var list = query.Select(x => x.자재번호).ToList();
                var list1 = new List<자재>();
                for (int i = 0; i < list.Count; i++)
                    list1.Add(Get자재(list[i]).FirstOrDefault());

                return list1;
            }
        }

        public List<자재> Get자재번호(string 자재이름)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재
                            where x.자재명 == 자재이름
                            select x;

                return query.ToList();
            }
        }

        public List<자재> Search자재(string 품목군, string 공급업체)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재
                            select x;

                if (string.IsNullOrEmpty(품목군) == false)
                {
                    var query1 = from x in query
                                 where x.품목군 == 품목군
                                 select x;

                    return query1.ToList();
                }
                return query.ToList();
            }
        }

        public List<자재> Get자재(string 자재번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재
                            where x.자재번호 == 자재번호
                            select x;

                return query.ToList();
            }
        }

        public bool IsSearch자재명(string 자재이름)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재
                            where x.자재명 == 자재이름
                            select x;

                var list = query.ToList();

                if (list.Count == 0) return false;
                else return true;
            }
        }
        #region 자재정보찾기

        public string Search품목군(string 자재번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재
                            where x.자재번호 == 자재번호
                            select x;

                return query.Select(x => x.품목군).First().ToString();
            }
        }

        public string Search안전재고량(string 자재번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재
                            where x.자재번호 == 자재번호
                            select x;

                return query.Select(x => x.안전재고량).First().ToString();
            }
        }

        public string Search재고량(string 자재번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재
                            where x.자재번호 == 자재번호
                            select x;

                return query.Select(x => x.재고량).First().ToString();
            }
        }

        public string Search리드타임(string 자재번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재
                            where x.자재번호 == 자재번호
                            select x;

                return query.Select(x => x.리드타임).First().ToString();
            }
        }

        public bool Search검사여부(string 자재번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재
                            where x.자재번호 == 자재번호
                            select x;

                return query.Select(x => x.검사여부).FirstOrDefault();
            }
        }

        public string Search무게(string 자재번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재
                            where x.자재번호 == 자재번호
                            select x;

                //return query.Select(x => x.무게).First().ToString();
                return query.Select(x => x.자재명).First().ToString();
            }
        }

        public string Search상도(string 자재번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재
                            where x.자재번호 == 자재번호
                            select x;

                //return query.Select(x => x.상도).First().ToString();
                return query.Select(x => x.자재명).First().ToString();
            }
        }
        public string Search하도(string 자재번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재
                            where x.자재번호 == 자재번호
                            select x;

                //return query.Select(x => x.하도).First().ToString();
                return query.Select(x => x.자재명).First().ToString();
            }
        }

        public string Search공급업체(string 자재번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query1 = from x in context.공급자재리스트
                             where x.자재번호 == 자재번호
                             select x;

                var 공급업체번호 = query1.Select(x => x.공급업체번호).First();

                var query = from x in context.일반거래처등록
                            where x.거래처코드번호 == 공급업체번호
                            select x;

                return query.Select(x => x.거래처명).First().ToString();
            }
        }

        #endregion
    }
}
