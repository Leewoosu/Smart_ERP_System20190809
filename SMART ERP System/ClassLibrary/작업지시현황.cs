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
    
    public partial class 작업지시현황
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 작업지시현황()
        {
            this.생산실적현황 = new HashSet<생산실적현황>();
        }
    
        public string 작업지시번호 { get; set; }
        public int 생산계획현황번호 { get; set; }
        public string 제품번호 { get; set; }
        public string 수량 { get; set; }
        public string 작업장번호 { get; set; }
        public string 작업상태번호 { get; set; }
        public string 작업지시일 { get; set; }
        public string 작업완료_예정_일 { get; set; }
        public int 자재명세번호 { get; set; }
        public string 상태 { get; set; }
    
        public virtual 생산계획현황 생산계획현황 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<생산실적현황> 생산실적현황 { get; set; }
    }
}
