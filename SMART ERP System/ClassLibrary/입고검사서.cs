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
    
    public partial class 입고검사서
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 입고검사서()
        {
            this.반품처리서 = new HashSet<반품처리서>();
            this.불량상세정보 = new HashSet<불량상세정보>();
        }
    
        public int 입고검사서번호 { get; set; }
        public int 발주확인서번호 { get; set; }
        public int 자재번호 { get; set; }
        public int 양품수량 { get; set; }
        public int 불량수량 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<반품처리서> 반품처리서 { get; set; }
        public virtual 발주확인리스트 발주확인리스트 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<불량상세정보> 불량상세정보 { get; set; }
    }
}
