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
    
    public partial class 입고등록
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 입고등록()
        {
            this.반품처리서 = new HashSet<반품처리서>();
            this.입고등록리스트 = new HashSet<입고등록리스트>();
        }
    
        public string 입고등록번호 { get; set; }
        public System.DateTime 검사일자 { get; set; }
        public string 발주번호 { get; set; }
        public string 공급업체번호 { get; set; }
    
        public virtual 공급업체 공급업체 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<반품처리서> 반품처리서 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<입고등록리스트> 입고등록리스트 { get; set; }
    }
}
