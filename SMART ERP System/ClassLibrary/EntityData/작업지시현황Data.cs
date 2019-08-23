using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary.EntityData
{
    public class 작업지시현황Data : EntityData<작업지시현황>
    {
        public List<작업지시현황> Search(string text)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                var qeury = from x in entities.작업지시현황
                            where x.작업지시번호 == text
                            select x;
                List<작업지시현황> list = qeury.ToList();

                return list;
            }
        }

        public List<작업지시현황> Search_작업지시현황(string 지시번호, string 품번,DateTime dtp작업예정일1, DateTime dtp작업예정일2)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                var query1 = from x in entities.작업지시현황
                            where x.작업지시일 >= dtp작업예정일1 && x.작업지시일 <= dtp작업예정일2
                            select x;

                if (string.IsNullOrEmpty(지시번호) == false)
                {
                    var query2 = from x in query1                       
                                 select x;

                    var list = query2.ToList();

                    list = list.Where(x => x.작업지시번호.StartsWith(지시번호)).ToList();

                    if (string.IsNullOrEmpty(품번) == false)
                    {
                        var query3 = from x in list
                                     select x;

                        var list1 = query3.ToList();
                        list1 = list1.Where(x => x.제품번호.StartsWith(품번)).ToList();

                        return list1;
                    }
                    
                   
                    
                    

                    return list;

                }
                else
                {
                    if (string.IsNullOrEmpty(품번) == false)
                    {
                        var query3 = from x in query1                
                                     select x;

                        var list1 = query3.ToList();
                        list1 = list1.Where(x => x.제품번호.StartsWith(품번)).ToList();

                        return list1;                         
                    }
                    return query1.ToList();
                }
                            
            }
        }

    }
}
