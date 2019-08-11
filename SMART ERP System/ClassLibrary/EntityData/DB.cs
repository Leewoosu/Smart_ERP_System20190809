using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class DB
    {
        public static 사원등록Data 사원등록 { get; } = new 사원등록Data();
        public static 수주Data 수주 { get; } = new 수주Data();
        public static 제품Data 제품 { get; } = new 제품Data();
        public static 계정과목Data 계정과목 { get; } = new 계정과목Data();
        public static 계정과목등록Data 계정과목등록 { get; } = new 계정과목등록Data();
        public static 전표Data 전표 { get; } = new 전표Data();
        public static 전표리스트Data 전표리스트 { get; } = new 전표리스트Data();
        public static 거래처Data 거래처 { get; } = new 거래처Data();
        public static 일반거래처Data 일반거래처 { get; } = new 일반거래처Data();
        public static 금융거래처Data 금융거래처 { get; } = new 금융거래처Data();
    }
}
