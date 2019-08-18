using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 계정과목Data : EntityData<계정과목>
    {
        public string SearchAccountName(string accountCode)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.계정과목.Where(x => x.계정과목코드번호 == accountCode).ToList().Select(x => x.계정과목명).FirstOrDefault();
            }
        }

        public List<계정과목> SearchCode(string code)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                var list = entities.계정과목.ToList();

                int.TryParse(code, out int result);

                if (result == 0)
                {
                   return entities.계정과목.Where(x => x.계정과목명.Replace(" ", "").StartsWith(code)).ToList();
                }

                return entities.계정과목.Where(x => x.계정과목코드번호.StartsWith(code)).ToList();
            }
        }

        public string FindCode(string name)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                var list = entities.계정과목.ToList();

                int.TryParse(name, out int result);

                name = name.Replace(" ", "");

                if (result == 0)
                {
                   return entities.계정과목
                        .Where(x => x.계정과목명.Replace(" ", "") == name)
                        .ToList()
                        .Select(x=>x.계정과목코드번호)
                        .FirstOrDefault();
                }

                return entities.계정과목
                    .Where(x => x.계정과목명.Replace(" ", "") == name)
                    .ToList()
                    .Select(x=>x.계정과목코드번호)
                    .FirstOrDefault();;
            }
        }

        public bool IsUpdateAccountCode(계정과목 계정과목)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                foreach (계정과목 item in entities.계정과목)
                {
                    if (계정과목.계정과목코드번호 == item.계정과목코드번호)
                    {
                        if (계정과목.계정과목명 != item.계정과목명 ||
                            계정과목.출력계정명 != item.출력계정명 ||
                            계정과목.관련계정코드 != item.관련계정코드 ||
                            계정과목.계정구분 != item.계정구분 ||
                            계정과목.차대구분 != item.차대구분 ||
                            계정과목.입력구분 != item.입력구분 ||
                            계정과목.필수입력여부 != item.필수입력여부 ||
                            계정과목.비고 != item.비고)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
        }
    }
}
