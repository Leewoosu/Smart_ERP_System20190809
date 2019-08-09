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
        public static 계정과목등록Data 계정과목등록 { get; } = new 계정과목등록Data();
        public static 전표Data 전표 { get; } = new 전표Data();
        public static 전표리스트Data 전표리스트 { get; } = new 전표리스트Data();
    }
}
