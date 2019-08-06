using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class DB
    {
        public static 사원등록Data 사원등록 { get; } = new 사원등록Data();
        public static 상각방법Data 상각방법 { get; } = new 상각방법Data();
        public static 수주Data 수주 { get; } = new 수주Data();
        public static 제품Data 제품 { get; } = new 제품Data();
        public static 계정과목등록Data 계정과목등록 { get; } = new 계정과목등록Data();
    }
}
