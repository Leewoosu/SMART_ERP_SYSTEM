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
    
    public partial class 수주
    {
        public string 수주번호 { get; set; }
        public string 수주번호2 { get; set; }
        public int 제품번호 { get; set; }
        public int 주문수량 { get; set; }
        public int 납품업체번호 { get; set; }
        public Nullable<int> 주문일 { get; set; }
        public Nullable<int> 납기일 { get; set; }
    
        public virtual 납품업체 납품업체 { get; set; }
        public virtual 제품 제품 { get; set; }
    }
}
