using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 소요량전개Data : EntityData<소요량전개>
    {
        public void Register소요량()
        {
            //var 발주List = DB.발주리스트.GetAll();           

            //소요량전개 soyo = new 소요량전개();

            //var 소요량전개List = GetAll();

            //for (int i = 0; i < 소요량전개List.Count; i++)
            //    Delete(소요량전개List[i]);

            //for (int i = 0; i < 발주List.Count; i++)
            //{               
            //    soyo.자재번호 = 발주List[i].자재번호;
            //    soyo.소요량전개번호 = i + 1;
            //    soyo.전개수량 = 0;

            //    Insert(soyo);
            //}

            //소요량전개List = GetAll();

            //for (int i = 0; i < 소요량전개List.Count; i++)
            //{
            //    for (int j = 0; j < 발주List.Count; j++)
            //    {
            //        if(소요량전개List[i].자재번호 == 발주List[j].자재번호) 
            //            소요량전개List[i].전개수량 += 발주List[j].수량;                                          
            //    }
            //    Update(소요량전개List[i]);
            //}

            var 자재명세자재번호List = DB.자재명세서.Get자재List();
            var 수주List = DB.수주.GetAll();
            소요량전개 soyo = new 소요량전개();
            var 자재명세서List = DB.자재명세서.GetAll();
            var Input자재명세서List = DB.자재명세서.GetAll();

            foreach (var item in Input자재명세서List)
                item.수량 = 0;

            var 소요량전개list = GetAll();

            for (int i = 0; i < 소요량전개list.Count; i++)
                Delete(소요량전개list[i]);

            for (int i = 0; i < 자재명세자재번호List.Count; i++)
            {
                soyo.소요량전개번호 = (i + 1).ToString();
                soyo.자재번호 = 자재명세자재번호List[i];
                soyo.전개수량 = 0;
                Insert(soyo);
            }

            소요량전개list = GetAll();

            for (int i = 0; i < 수주List.Count; i++)
            {
                for (int j = 0; j < 자재명세서List.Count; j++)
                {
                    if (수주List[i].제품번호 == 자재명세서List[j].제품번호)
                        Input자재명세서List[j].수량 += 수주List[i].주문수량 * 자재명세서List[j].수량;                
                }
            }

            for (int i = 0; i < 소요량전개list.Count; i++)
            {
                for (int j = 0; j < Input자재명세서List.Count; j++)
                {
                    if (소요량전개list[i].자재번호 == Input자재명세서List[j].자재번호)
                            소요량전개list[i].전개수량 += Input자재명세서List[j].수량;
                }
            }
            
            foreach (var item in 소요량전개list)
                Update(item);
        }
    }
}
