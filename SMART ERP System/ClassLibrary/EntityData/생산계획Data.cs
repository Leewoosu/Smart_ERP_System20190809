using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 생산계획Data : EntityData<생산계획현황>
    {
        //public int 생산계획번호생성(int 제품번호)
        //{
        //    using(ERPEntities context = new ERPEntities())
        //    {
        //        var query = from x in context.생산계획현황
        //                    where x.제품번호 == 제품번호
        //                    select x;

        //        return query.ToList().Count + 1;
        //    }
        //}
    }
}
