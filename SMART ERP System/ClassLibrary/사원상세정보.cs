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
    
    public partial class 사원상세정보
    {
        public string 사원코드 { get; set; }
        public byte[] 사원사진 { get; set; }
        public string 사원이름_영문_ { get; set; }
        public string 내외국인구분 { get; set; }
        public string 주민등록번호 { get; set; }
        public string 성별 { get; set; }
        public System.DateTime 생년월일 { get; set; }
        public string 전화번호 { get; set; }
        public string 비상연락_HP_ { get; set; }
        public string 최종학력 { get; set; }
        public string 주민등록주소 { get; set; }
        public string 상세주소 { get; set; }
        public string E_MAIL { get; set; }
        public System.DateTime 입사일 { get; set; }
        public Nullable<System.DateTime> 퇴직일 { get; set; }
        public Nullable<System.DateTime> 중도퇴사일 { get; set; }
        public System.DateTime 그룹입사일 { get; set; }
        public Nullable<System.DateTime> 휴직기간시작일 { get; set; }
        public Nullable<System.DateTime> 휴직기간종료일 { get; set; }
        public string 재직구분 { get; set; }
        public string 부서 { get; set; }
        public string 직종 { get; set; }
        public string 급여형태 { get; set; }
        public string 프로젝트 { get; set; }
        public string 근무조 { get; set; }
        public string 직급 { get; set; }
        public string 직책 { get; set; }
        public string 퇴직사유 { get; set; }
        public string 호봉 { get; set; }
        public string 계정유형 { get; set; }
        public string 급여이체은행 { get; set; }
        public string 계좌번호 { get; set; }
        public string 예금주 { get; set; }
    
        public virtual 사원등록 사원등록 { get; set; }
    }
}
