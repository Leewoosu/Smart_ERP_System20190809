using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 입고검사Data : EntityData<입고등록>
    {
        public void Register입고검사(object 입고검사정보)
        {
            입고등록 입고등록 = 입고검사정보 as 입고등록;
            Update(입고등록);
        }
    }
}
