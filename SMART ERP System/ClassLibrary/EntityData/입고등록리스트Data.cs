using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 입고등록리스트Data : EntityData<입고등록리스트>
    {        
        public List<입고등록리스트> Search입고등록리스트(string 입고등록번호)
        {
            using(ERPEntities context = new ERPEntities())
            {
                var query = from x in context.입고등록리스트
                            where x.입고등록번호 == 입고등록번호
                            select x;

                return query.ToList();
            }
        }
        public List<입고등록리스트> Search입고등록리스트(string 입고등록번호, string 자재번호)
        {
            using(ERPEntities context = new ERPEntities())
            {
                var query = from x in context.입고등록리스트
                            where x.입고등록번호 == 입고등록번호 && x.자재번호 == 자재번호
                            select x;

                return query.ToList();
            }
        }
        
    }
}
