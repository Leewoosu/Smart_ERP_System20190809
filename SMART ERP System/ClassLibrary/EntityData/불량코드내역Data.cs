using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary.EntityData
{
    public class 불량코드내역Data : EntityData<불량상세정보>
    {
        public int Is불량코드내역(string 불량코드)
        {
            using(ERPEntities context = new ERPEntities())
            {
                var query = from x in context.불량코드내역
                            where x.불량코드번호 == 불량코드 || x.불량명 == 불량코드
                            select x;

                if (query.ToList().Count == 0)
                {
                    MessageBox.Show("잘못된 코드정보입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else return 1;
            }
        }
    }
}
