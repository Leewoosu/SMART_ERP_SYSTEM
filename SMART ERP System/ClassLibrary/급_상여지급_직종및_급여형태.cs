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
    
    public partial class 급_상여지급_직종및_급여형태
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 급_상여지급_직종및_급여형태()
        {
            this.급여형태 = new HashSet<급여형태>();
        }
    
        public int 급_상여지급_직종코드 { get; set; }
        public int 지급번호코드 { get; set; }
        public string 사업장명 { get; set; }
        public string 직종 { get; set; }
        public System.DateTime 상여지급대상기간_시작일 { get; set; }
        public System.DateTime 상여지급대상기간_종료일 { get; set; }
        public int 상여지급대상기간_일수 { get; set; }
    
        public virtual 급_상여지급_급여구분 급_상여지급_급여구분 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<급여형태> 급여형태 { get; set; }
    }
}
