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
    
    public partial class 자재
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 자재()
        {
            this.발주리스트 = new HashSet<발주리스트>();
            this.발주확인리스트 = new HashSet<발주확인리스트>();
            this.자재명세서 = new HashSet<자재명세서>();
        }
    
        public int 자재번호 { get; set; }
        public string 자재명 { get; set; }
        public int 안전재교량 { get; set; }
        public int 재고량 { get; set; }
        public int 구매단가 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<발주리스트> 발주리스트 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<발주확인리스트> 발주확인리스트 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<자재명세서> 자재명세서 { get; set; }
    }
}
