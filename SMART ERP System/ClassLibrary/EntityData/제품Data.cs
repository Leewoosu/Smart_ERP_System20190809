using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary.EntityData
{
    public class 제품Data : EntityData<제품>
    {
        public bool IsSearch제품번호(string 제품번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.제품
                            where x.제품번호 == 제품번호
                            select x;

                int cnt = query.ToList().Count;

                if (cnt == 0) return false;
                else return true;
            }
        }

        public List<string> Get품목군()
        {
            using (ERPEntities entities = new ERPEntities())
            {
                var list = entities.제품.Select(x => x.품목군).ToList();

               return list.Distinct().ToList();
            }
        }

        public bool IsSearch제품명(string 제품명)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.제품
                            where x.제품명 == 제품명
                            select x;

                int cnt = query.ToList().Count;

                if (cnt == 0) return false;
                else return true;
            }
        }

        public List<제품> Search제품(string 품목군, string 검사여부)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query4 = from x in context.제품
                             select x;

                if (string.IsNullOrEmpty(품목군) == false)
                {
                    var query = from x in query4
                                where x.품목군 == 품목군
                                select x;

                    if (string.IsNullOrEmpty(검사여부) == false)
                    {
                        var query1 = from x in query
                                     where x.검사여부 == 검사여부
                                     select x;
                       
                        return query1.ToList();
                    }
                    return query.ToList();

                    
                }
                else
                {
                    if (string.IsNullOrEmpty(검사여부) == false)
                    {
                        var query1 = from x in query4
                                     where x.검사여부 == 검사여부
                                     select x;

                        return query1.ToList();
                    }
                    

                    return query4.ToList();

                }
            }
        }
        public List<int> Get재고량()
        {
            using(ERPEntities context = new ERPEntities())
            {
                var query = from x in context.제품                           
                            select x;

                return query.Select(x => x.재고량).ToList();
            }
        }

        public List<제품> Get제품(string 제품번호)
        {
            using(ERPEntities context = new ERPEntities())
            {
                var query = from x in context.제품
                            where x.제품번호 == 제품번호
                            select x;
                return query.ToList();
            }
        }
        #region 제품정보찾기
        
        public string Search품목군(string 제품번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.제품
                            where x.제품번호 == 제품번호
                            select x;

                return query.Select(x => x.품목군).First().ToString();
            }
        }
        public string SearchLOT수량(string 제품번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.제품
                            where x.제품번호 == 제품번호
                            select x;

                return query.Select(x => x.LOT수량).First().ToString();
            }
        }
        public string Search검사여부(string 제품번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.제품
                            where x.제품번호 == 제품번호
                            select x;

                return query.Select(x => x.검사여부).First().ToString();
            }
        }
        public string Search리드타임(string 제품번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.제품
                            where x.제품번호 == 제품번호
                            select x;

                return query.Select(x => x.리드타임).First().ToString();
            }
        }
        public string Search안전재고량(string 제품번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.제품
                            where x.제품번호 == 제품번호
                            select x;

                return query.Select(x => x.안전재고량).First().ToString();
            }
        }
        public string Search일별생산량(string 제품번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.제품
                            where x.제품번호 == 제품번호
                            select x;

                return query.Select(x => x.일별생산량).First().ToString();
            }
        }
        public string Search표준원가(string 제품번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.제품
                            where x.제품번호 == 제품번호
                            select x;

                return query.Select(x => x.표준원가).First().ToString();
            }
        }
        public string Search실제원가(string 제품번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.제품
                            where x.제품번호 == 제품번호
                            select x;

                return query.Select(x => x.실제원가).First().ToString();
            }
        }
       
        
        public string Search층(string 제품번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.제품
                            where x.제품번호 == 제품번호
                            select x;

                return query.Select(x => x.층).First().ToString();
            }
        }
        public string Search외경(string 제품번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.제품
                            where x.제품번호 == 제품번호
                            select x;

                return query.Select(x => x.외경).First().ToString();
            }
        }
        public string Search재고량(string 제품번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.제품
                            where x.제품번호 == 제품번호
                            select x;

                return query.Select(x => x.재고량).First().ToString();
            }
        }
        #endregion
    }
}
