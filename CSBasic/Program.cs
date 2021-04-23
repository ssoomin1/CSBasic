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

            //문자열 연결 연산자
            //concat concatenate operator
            //concatenation operator
            Console.WriteLine("ABC" + "EFG");
            Console.WriteLine('A' + 'E'); //134 문자열만 계산해줄 수 있음 (정수+정수) 덧셈연산자 사용
            Console.WriteLine("ABC" + 'E');
            Console.WriteLine("ABC"[2]);
          //  Console.WriteLine("ABC"[3]); //IndexOutOfRangeException 발생

            //bool
            bool isPlay = true;
            bool isDeath = false;

            //comparison operator
            Console.WriteLine(52 == 163);
            Console.WriteLine(52 != 163);
            Console.WriteLine(52 > 163); //gt
            Console.WriteLine(52 < 163); //lt
            Console.WriteLine(52 >= 163);
            Console.WriteLine(52 <= 163);
            //Console.WriteLine(52 =! 163); 
            //Console.WriteLine(52 =< 163); 
            //Console.WriteLine(52 => 163); 


            //Logic Operator
            Console.WriteLine(!(true));
            Console.WriteLine(true || false);
            Console.WriteLine(true && false);

            //단항연산자 - unary operator
            Console.WriteLine(!(true)); //연산자가 대응하는게 1개
            int i = 0;
            i++;

            //이항연산자 - binary operator
            i = 1 + 2;

            //삼항연산자 - tenary operator
            int j;
            //[1] ? [2] : [3] =>대상이 3개
            j = (1 > 3) ? 0 : 1;

            //Console.WriteLine(3 < i < 8);
            Console.WriteLine(3 < i && i < 8);
            Console.WriteLine(3 < i || i> 8);
            Console.WriteLine(i<3 || 8<i);

            //21억은 기억해두기
            int a = 213738640;
            int b = 10000000;
            Console.WriteLine((long)a + b);

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine(-int.MaxValue);
            //Console.WriteLine(-int.MinValue);

            Console.WriteLine(3L);
            //Console.WriteLine(3l); //1과 헷갈리니까 대문자로 쓰는 것이 좋다. 

            Console.WriteLine(3);
            Console.WriteLine(3.0);
            char c = 'a';
            Console.WriteLine(c);

            //sizeof(자료형)
            Console.WriteLine("int: "+sizeof(int));
            Console.WriteLine("long: " + sizeof(long));
            Console.WriteLine("float: " + sizeof(float));
            Console.WriteLine("double: " + sizeof(double));
            Console.WriteLine("char: " + sizeof(char)); //c#에서는 2바이트

            bool IsLive = true;

            //증감연산자 - 섞어서 쓸 경우
            // 전위, 후위에 따라서 출력 값이 변함
            int num = 10;
            Console.WriteLine(num++);
            Console.WriteLine(++num);
            Console.WriteLine(num--);
            Console.WriteLine(--num);


            //복합대입연산자
            int output = 0;
            output += 52;
            output = output + 52;
            output *= 10;
            output = output * 10;
            Console.WriteLine(output);

            //문자열 연결 연산자를 사용한 복합 연산자
            string output3 = "Hello";
            output3 += " World";
            output3 = output3 + "?!";
            Console.WriteLine(output3);

            int _int = 273;
            long _long = 522731033265;
            float _float = 52.273F;
            double _double = 52.373;
            char _char = '귤';
            string _string = " 문자열";

            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType()) ;
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());
        }
    }
}
