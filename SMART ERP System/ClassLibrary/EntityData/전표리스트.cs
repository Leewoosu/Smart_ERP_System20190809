using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public partial class 전표리스트
    {
        public string 계정과목명 { get; set; }
        public string 거래처명 { get; set; }
        public string 전표유형 { get; set; }
        public string 전표상태 { get; set; }
        public int? 차변 { get; set; }
        public int 차변합계 { get; set; }
        public int? 대변 { get; set; }
        public int 대변합계 { get; set; }
        public int 건수 { get; set; }
    }
}
