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
    
    public partial class MES현장실적현황
    {
        public string 관리번호 { get; set; }
        public string 제품번호 { get; set; }
        public int 실적수량 { get; set; }
        public int 불량수량 { get; set; }
        public string 설비명 { get; set; }
        public string 공정명 { get; set; }
        public string 작업자 { get; set; }
        public System.DateTime 작업시작 { get; set; }
        public Nullable<System.DateTime> 작업종료 { get; set; }
        public Nullable<bool> 완료유무 { get; set; }
    
        public virtual MES투입현황 MES투입현황 { get; set; }
        public virtual 작업지시현황 작업지시현황 { get; set; }
    }
}
