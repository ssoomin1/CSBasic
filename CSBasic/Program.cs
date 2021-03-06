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
       // var something = "hehe"; =>지역변수에만 사용가능

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

            Console.WriteLine("==================");
            var somea = "무엇을 쓰는게 좋을까요??";
            var someb = 19;
            var somec = 3.141592;
            Console.WriteLine(somea.GetType());
            Console.WriteLine(someb.GetType());
            Console.WriteLine(somec.GetType());

            bool isLoop = true;
            string input;
            while (isLoop)
            {
                Console.Write("입력> ");
                input = Console.ReadLine();
                if (input.Equals("q"))
                    break;
                else
                    Console.WriteLine(input);
            }
            var a1 = (int)10.0;
            var b1 = (float)10;
            var c1 = (double)10;


            long longNumber = 2147483637L + 2147483637L;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);

            long longNumber2 = 52773;
            int intNumber2 = (int)longNumber2;
            Console.WriteLine(intNumber2);

            Console.WriteLine("int,long,float,double 맥스벨류");
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue); 
            Console.WriteLine(float.MaxValue); //3.4E+38 = 3.4 * 10의 38승
            Console.WriteLine(double.MaxValue);

            Console.WriteLine((52).ToString());
            Console.WriteLine((52.273).ToString());
            Console.WriteLine(('a').ToString());
            Console.WriteLine((true).ToString());
            Console.WriteLine((false).ToString());

            Console.WriteLine((52).ToString().GetType());
            Console.WriteLine((52.273).ToString().GetType());
            Console.WriteLine(('a').ToString().GetType());
            Console.WriteLine((true).ToString().GetType());
            Console.WriteLine((false).ToString().GetType());

            //잘못된 형변환
            try
            {
                Console.WriteLine(int.Parse("52.273"));
                Console.WriteLine(int.Parse("abc"));
                Console.WriteLine(int.Parse("육십삼"));
                Console.WriteLine(int.Parse("Seven"));
            }
            catch(FormatException e)
            {
                Console.WriteLine("숫자를 입력하세요: " + e.Message);
            }catch(Exception e)
            {
                Console.WriteLine("알 수 없는 에러: " + e.Message);
            }

            (10).ToString();
            (52.383).ToString();

            double numberToString = 52.273103;
            Console.WriteLine(numberToString.ToString("0.0")); //시험 문제 내기 딱 좋다. => 52.3으로 나온다. 반올림 가능
            Console.WriteLine(numberToString.ToString("0.00"));
            Console.WriteLine(numberToString.ToString("0.000"));
            Console.WriteLine(numberToString.ToString("0.0000"));

            //숫자와 문자열 덧셈
            Console.WriteLine(52 + 273);
            Console.WriteLine("52" + 273);
            Console.WriteLine(52 + "273");
            Console.WriteLine(52+2+273);
            Console.WriteLine(52 + "2" + 273);
            Console.WriteLine("52" + 2 + 273);
            Console.WriteLine(52 + 2 + "273");

            int number = 52273;
            string ouputA = number + "";

            char character = 'a';
            string ouputB = character + ""; //원래 character는 덧셈이 안됐었는데 업데이트 되면서 덧셈 가능
            Console.WriteLine(ouputB);

            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("TRUE"));
            Console.WriteLine(bool.Parse("truE"));
            Console.WriteLine(bool.Parse("TrUe"));

            int outputInt = int.MinValue;
            Console.WriteLine(outputInt);
            Console.WriteLine(-(long)outputInt); //여기는 (long)으로 형변환해주고 해야지만 에러가 발생하지 않는다.
            //Console.WriteLine(-(-2147483648));
        }
    }
}
