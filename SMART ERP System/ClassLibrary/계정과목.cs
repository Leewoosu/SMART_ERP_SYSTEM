//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class 계정과목
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 계정과목()
        {
            this.전표리스트 = new HashSet<전표리스트>();
        }
    
        public int 계정과목코드번호 { get; set; }
        public string 계정과목명 { get; set; }
        public string 출력계정명 { get; set; }
        public string 계정구분 { get; set; }
        public Nullable<bool> 차대구분 { get; set; }
        public string 입력구분 { get; set; }
        public string 필수입력여부 { get; set; }
        public int 그룹코드번호 { get; set; }
    
        public virtual 계정과목그룹 계정과목그룹 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<전표리스트> 전표리스트 { get; set; }
    }
}
