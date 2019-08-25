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
    
    public partial class 제품
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 제품()
        {
            this.공정순서 = new HashSet<공정순서>();
            this.생산계획현황 = new HashSet<생산계획현황>();
            this.수주 = new HashSet<수주>();
            this.자재명세서 = new HashSet<자재명세서>();
            this.작업완료지시 = new HashSet<작업완료지시>();
            this.작업완료확인서 = new HashSet<작업완료확인서>();
            this.작업지시 = new HashSet<작업지시>();
            this.작업지시리스트 = new HashSet<작업지시리스트>();
        }
    
        public string 제품번호 { get; set; }
        public string 제품명 { get; set; }
        public int 안전재고량 { get; set; }
        public int 재고량 { get; set; }
        public string 품목군 { get; set; }
        public int 일별생산량 { get; set; }
        public Nullable<int> 표준원가 { get; set; }
        public int 실제원가 { get; set; }
        public int 외경 { get; set; }
        public int 층 { get; set; }
        public int 리드타임 { get; set; }
        public int LOT수량 { get; set; }
        public Nullable<bool> 검사여부 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<공정순서> 공정순서 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<생산계획현황> 생산계획현황 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<수주> 수주 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<자재명세서> 자재명세서 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<작업완료지시> 작업완료지시 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<작업완료확인서> 작업완료확인서 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<작업지시> 작업지시 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<작업지시리스트> 작업지시리스트 { get; set; }
    }
}
