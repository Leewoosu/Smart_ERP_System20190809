﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 계정과목Data : EntityData<계정과목>
    {
        public string SearchAccountCode(int accountCode)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.계정과목.Where(x => x.계정과목코드번호 == accountCode).ToList().Select(x => x.계정과목명).ToString();
            }
        }
    }
}
