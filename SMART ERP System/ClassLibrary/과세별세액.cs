//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class 과세별세액
    {
        public int 일반과세ID { get; set; }
        public string 구분 { get; set; }
        public int 금액 { get; set; }
        public int 세액 { get; set; }
        public int 역추적ID { get; set; }
        public System.DateTime 회계기간 { get; set; }
    
        public virtual 부가세신고서 부가세신고서 { get; set; }
    }
}
