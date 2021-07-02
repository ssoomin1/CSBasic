using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic5
{
    class Box
    {
        private int width;
        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    Console.WriteLine("양수만 입력 가능!");
                }
            }
        }

        class Program
    {
        class MethodExample
        {
            public int Power(int x)
            {
                return x + x;
            }

            public int Multi(int x,int y)
            {
                return x * y;
            }

            public void Print()
            {
                Console.WriteLine("Print() 메소드 호출됨");
            }
        }

        static void Main(string[] args)
        {

            MethodExample me = new MethodExample();
            Console.WriteLine(me.Power(10));
            Console.WriteLine(me.Power(20));
            Console.WriteLine(me.Multi(52,373));
            Console.WriteLine(me.Multi(103,32));



            Car car = new Car();
            car.SetIntime();
            car.SetoutTime();

            Random random = new Random();
            random.Next();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(20));

            Console.WriteLine(random.Next(20)+1);
            Console.WriteLine(random.Next(1,21));

            int[] intArray = new int[10];
            long[] longArray = new long[10];
            string[] stringArray = new string[10];

            List<int> list = new List<int>();

            MethodExample me = new MethodExample();
            Console.WriteLine(me.Power(10));
            Console.WriteLine(me.Power(20));
            Console.WriteLine(me.Multi(52, 273));
            Console.WriteLine(me.Multi(103, 32));

            Test test = new Test();
            Console.WriteLine(test.Sum(1, 100)); //1부터 100까지 합

            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));

            //클래스 메서드에서는 인스턴스 변수/메서드 접근 불가
            //객체를 만들어 접근해야한다.
            //Console.WriteLine(instanceVariable);
            //instanceMethod();
            Program p = new Program();
            Console.WriteLine(p.instanceVariable);
            p.instanceMethod();

            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));
            Console.WriteLine(MyMath.Abs(52.273));
            Console.WriteLine(MyMath.Abs(214712340385872)); //마우스 오버해서 타입 확인하기

            Product productA = new Product("감자", 2000);
            Product productB = new Product("고구마", 3000);
            Product productC = new Product("옥수수", 2000);
            Console.WriteLine(productA);
            Console.WriteLine(productB);
            Console.WriteLine(productC);
            Console.WriteLine(Product.counter + "개 생성되었습니다.");
            //Console.WriteLine(productA.id + ":" + productA.name);//toString으로 하면 이렇게 할 필요 없음

            Console.WriteLine("첫 번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("두 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("세 번째 위치");

            Box box = new Box(10, 200);
            Console.WriteLine(box.Area);
            Box wrongBox = new Box(-10, -5);
            Console.WriteLine(wrongBox.Area);

            int a = 10;
            Change(a);
            Console.WriteLine(a);

            TestSome t = new TestSome();
            t.value = 30;
            TestSome.Change(t);
            Console.WriteLine(t.value);
            Console.WriteLine(Fibonacci.Get(10));


        }

        class Fibonacci
        {
            public static int count = 0;
            public static long Get(int i)
            {
                count++;
                Console.WriteLine(count);
                if (i < 0) { return 0; }
                if(i==1) { return 1; }
                    if (memo.containsKey(i))
                    {
                        return InsufficientMemoryException[i];
                    }
                    else
                    {
                        InsufficientMemoryException[i] = Get(i - 2) + Get(i - 1);
                        return InsufficientMemoryException[i];
                    }
            }
        }
    }
}
