using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 입고검사Data : EntityData<입고검사>
    {
        public void Register입고검사(object 입고검사정보)
        {
            입고검사 입고검사 = 입고검사정보 as 입고검사;
            Update(입고검사);
        }
    }
}
