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
    
    public partial class 사원등록
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 사원등록()
        {
            this.고정자산 = new HashSet<고정자산>();
            this.급여계산 = new HashSet<급여계산>();
            this.부서등록 = new HashSet<부서등록>();
            this.사용자권한설정 = new HashSet<사용자권한설정>();
        }
    
        public string 사원코드 { get; set; }
        public string 사원명 { get; set; }
        public string 사원명_영문_ { get; set; }
        public string 부서코드 { get; set; }
        public System.DateTime 입사일 { get; set; }
        public Nullable<System.DateTime> 퇴사일 { get; set; }
        public string 사용자여부 { get; set; }
        public string 조회권한 { get; set; }
        public string 비상연락망 { get; set; }
        public string 암호 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<고정자산> 고정자산 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<급여계산> 급여계산 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<부서등록> 부서등록 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<사용자권한설정> 사용자권한설정 { get; set; }
        public virtual 사원상세정보 사원상세정보 { get; set; }
    }
}
