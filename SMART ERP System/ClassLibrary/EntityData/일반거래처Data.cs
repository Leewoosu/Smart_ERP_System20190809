using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 일반거래처Data : EntityData<일반거래처등록>
    {
        public List<일반거래처등록> Search(string customerCode)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                List<일반거래처등록> list = entities.일반거래처등록.Where(x => x.거래처코드번호 == customerCode).Select(x => x).ToList();

                return list;
            }
        }
    }
}
