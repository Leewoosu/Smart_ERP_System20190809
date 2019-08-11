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
    
    public partial class 자재
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 자재()
        {
            this.공급업체 = new HashSet<공급업체>();
            this.발주리스트 = new HashSet<발주리스트>();
            this.발주확인리스트 = new HashSet<발주확인리스트>();
            this.소요량전개 = new HashSet<소요량전개>();
            this.자재명세서 = new HashSet<자재명세서>();
        }
    
        public string 자재번호 { get; set; }
        public string 자재명 { get; set; }
        public int 안전재교량 { get; set; }
        public int 재고량 { get; set; }
        public int 구매단가 { get; set; }
        public Nullable<int> 리드타임 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<공급업체> 공급업체 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<발주리스트> 발주리스트 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<발주확인리스트> 발주확인리스트 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<소요량전개> 소요량전개 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<자재명세서> 자재명세서 { get; set; }
    }
}
