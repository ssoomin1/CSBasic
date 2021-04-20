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

            //자료형(Data Type)
            //Integer ''이 없으면 기본적으로 int취급
            Console.WriteLine(53 + 227 - 123);
            Console.WriteLine(53 * 3 - 3);
            Console.WriteLine(14 / 2);  //7
            Console.WriteLine(14 / 3);  //4
            Console.WriteLine(14 % 3); //2

            //Real Number
            Console.WriteLine(0);
            Console.WriteLine(0.0); //0과 0.0은 다르다. 
            Console.WriteLine(13.123); //double
            Console.WriteLine(14.0 / 2.0); //7.0
            Console.WriteLine(14.0 / 3.0); //4.66667
            Console.WriteLine(14.0 % 3.0); //실수에서는 이러면 안된다.

            Console.WriteLine(14 / 3);
            Console.WriteLine(14.0 / 3);
            Console.WriteLine(14 / 3.0);
            Console.WriteLine(14.0 / 3.0);

            //Character
            Console.WriteLine('A'); //문자
            //String
            Console.WriteLine("B"); //문자열
            //Escape Character
            Console.WriteLine("\t 탭 \\ 역슬래시 \n 개행 \" ");
            Console.WriteLine("미\t림여자정보과학고"); //탭은 한글기준 4글자, 영문 기준 8글자 띄워준다 
            Console.WriteLine("미림\t여자정보과학고");
            Console.WriteLine("미림여\t자정보과학고");
            Console.WriteLine("미림여자정\t보과학고");
            Console.WriteLine("미림여자정보과\t학고");
            Console.WriteLine("미림여자정보과학고\t");

        }
    }
}
