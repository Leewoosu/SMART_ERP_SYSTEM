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
    
    public partial class 생산계획현황
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 생산계획현황()
        {
            this.작업지시현황 = new HashSet<작업지시현황>();
        }
    
        public int 생산계획현황번호 { get; set; }
        public string 작업예정일 { get; set; }
        public string 작업확정일 { get; set; }
        public string 수량 { get; set; }
        public int 제품번호 { get; set; }
    
        public virtual 제품 제품 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<작업지시현황> 작업지시현황 { get; set; }
    }
}
