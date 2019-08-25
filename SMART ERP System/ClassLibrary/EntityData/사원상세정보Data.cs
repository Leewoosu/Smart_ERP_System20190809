using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 사원상세정보Data : EntityData<사원상세정보>
    {
        public List<사원등록> Get사원등록(string id)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.사원등록
                            where x.사원코드 == id
                            select x;

                return query.ToList();
            }
        }

        public List<사원상세정보> Get사원상세정보(string id)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.사원상세정보
                            where x.사원코드 == id
                            select x;

                return query.ToList();
            }
        }



    }
}
