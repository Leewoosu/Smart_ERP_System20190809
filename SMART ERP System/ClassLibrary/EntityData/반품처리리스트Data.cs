using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 반품처리리스트Data : EntityData<반품처리리스트>
    {
        public List<반품처리리스트> Search반품처리리스트(string 입고등록번호, string 자재이름)
        {
            using(ERPEntities context = new ERPEntities())
            {
                var 자재번호 = context.자재.Where(x => x.자재명 == 자재이름).FirstOrDefault().자재번호;

                var query = from x in context.반품처리리스트
                            where x.반품처리서.입고검사서번호 == 입고등록번호 && x.자재번호 == 자재번호
                            select x;

                return query.ToList();
            }
        }

        public List<반품처리리스트> Search반품처리리스트(string 반품처리서번호)
        {
            using (ERPEntities context = new ERPEntities())
            {              
                var query = from x in context.반품처리리스트
                            where x.반품처리서.반품처리서번호 == 반품처리서번호
                            select x;

                
                return query.ToList();
            }
        }
    }
}
