using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 발주확인리스트Data : EntityData<발주확인리스트>
    {
        public void Register발주확인리스트(string 발주서번호, string 자재번호, int 수량)
        {
            발주확인리스트 발주확인리스트 = new 발주확인리스트();

            발주확인리스트.발주확인서번호 = 발주서번호;
            발주확인리스트.자재번호 = 자재번호;
            발주확인리스트.수량 = 수량;

            Insert(발주확인리스트);
        }
    }
}
