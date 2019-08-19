using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 계정과목그룹Data : EntityData<계정과목그룹>
    {
        public bool IsExist(string key)
        {
            var list = DB.계정과목그룹.GetAll();

            foreach (계정과목그룹 item in list)
            {
                if (item.그룹코드번호 == key)
                    return true;
            }

            return false;
        }
    }
}
