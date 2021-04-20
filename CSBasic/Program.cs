using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        //var 키워드는 지역변수로만 사용 가능
        //var name="신수민"  <== 에러난다. var의 사용범위
        static void Main(string[] args)
        {
            //keyword
            //int as
            //context keyword 지역변수로 사용할 수 있다. (메소드 내에서)
            var name = "신수민";

            //식별자 Identifier
            int alpha;
            int Alpha;
            //int break;
            //int 263alpha;
            //int has space;
            //int 🤗😍;
            int 한글숫자;
            //inline commit
            /*
             * comment
             */
            Console.WriteLine("Hello");

            //출력
            Console.Write("이건 안개행");
            Console.Write(" 입니당 \n");
            Console.WriteLine("");
            Console.WriteLine("이건 개행입니다.");
        }
    }
}
