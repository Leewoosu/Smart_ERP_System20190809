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
    
    public partial class 전표리스트
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 전표리스트()
        {
            this.거래처 = new HashSet<거래처>();
        }
    
        public int 전표리스트ID { get; set; }
        public int 순번 { get; set; }
        public string 구분 { get; set; }
        public string 계정과목코드번호 { get; set; }
        public string 거래처코드번호 { get; set; }
        public int 금액 { get; set; }
        public string 적요명 { get; set; }
        public System.DateTime 입력날짜 { get; set; }
        public string 전표번호 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<거래처> 거래처 { get; set; }
        public virtual 계정과목 계정과목 { get; set; }
        public virtual 전표 전표 { get; set; }
    }
}
