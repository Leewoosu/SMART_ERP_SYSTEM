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
    
    public partial class 근로소득별세부사항
    {
        public int 근로소득별세부사항번호 { get; set; }
        public int 과세표준시작범위 { get; set; }
        public int 과세표준끝범위 { get; set; }
        public float 세율 { get; set; }
        public int 환산급여 { get; set; }
        public int 누진공제 { get; set; }
        public int 조정액 { get; set; }
        public int 한도액 { get; set; }
        public int 근속년수액 { get; set; }
        public int 항목ID { get; set; }
    
        public virtual 근로소득 근로소득 { get; set; }
    }
}
