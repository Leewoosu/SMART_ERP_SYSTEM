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
    
    public partial class 근태결과
    {
        public int 근태결과순번 { get; set; }
        public string 구분 { get; set; }
        public int 일수 { get; set; }
        public System.TimeSpan 시간 { get; set; }
        public Nullable<decimal> 금액 { get; set; }
        public System.DateTime 귀속연월 { get; set; }
        public System.DateTime 급여지급일 { get; set; }
    
        public virtual 급여계산 급여계산 { get; set; }
    }
}
