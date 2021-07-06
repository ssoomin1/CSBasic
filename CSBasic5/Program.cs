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
                if(value>0) { width = value; }
                else { Console.WriteLine("너비는 자연수를 입력해주세요"); }
            }
        }
        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) { height = value; }
                else { Console.WriteLine("높이는 자연수를 입력해주세요"); }
            }
        }

        //생성자
        public Box(int width,int height)
        {
            Width = width;
            Height = height;
        }

        //인스턴스 메서드
        public int Area() { return this.width * this.height; }

    }

    class MyMath
    {
        public static int Abs(int input)
        {
            if (input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }
        }

        public static double Abs(double input)
        {
            if (input < 0) { return -input; }
            else { return input; }
        }

        public static long Abs(long input)
        {
            if (input < 0) { return -input; }
            else { return input; }
        }
    }

    class Product
    {
        public static int counter = 0;
        public int id;
        public string name;
        public int price;

        public Product(string name,int price)
        {
            Product.counter = counter + 1;
            this.id = counter;
            this.name = name;
            this.price = price;
        }
    }
    
    class TestWorld
    {
/*        public int Test(int input) { }
        public double Test(int input) { }
        public long Test(int input) {  }*/

    }

    class Sample
    {
        public static int value;

        static Sample()
        {
            value = 10;
            Console.WriteLine("정적 생성자 호출");
        }
    }

        class Program
    {
        class Hidden
        {
            private Hidden() { } //private이라서 Main에서 받으면 오류발생
        }


        public static int instanceVariable = 10;
        class Test
        {
            public void TestMethod()
            {
                Program.Main(new string[] { "" }); // 내부 클래스의 메소드에서 private접근
            }
            public int value = 10;
        }

        public void TestMethod()
        {
            Program.Main(new string[] { "" }); //자신의 클래스가 가진 메서드에서  private접근
        }
         static void Change(Test input)
        {
            input.value = 20;
        }
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

        public static void Main(string[] args)
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

            Box box = new Box(10, 10);

            Test test = new Test();
            test.value = 10;
            Change(test);

            Console.WriteLine(test.value);
            /* MethodExample me = new MethodExample();
             Console.WriteLine(me.Power(10));
             Console.WriteLine(me.Power(20));
             Console.WriteLine(me.Multi(52, 273));
             Console.WriteLine(me.Multi(103, 32));*/

            //Test test = new Test();
            //Console.WriteLine(test.Sum(1, 100)); //1부터 100까지 합

            //Console.WriteLine(MyMath.Abs(52));
            //Console.WriteLine(MyMath.Abs(-273));

            //클래스 메서드에서는 인스턴스 변수/메서드 접근 불가
            //객체를 만들어 접근해야한다.
            Console.WriteLine(instanceVariable);
            //instanceMethod();
            //Program p = new Program();
            //Console.WriteLine(p.instanceVariable);
            //p.instanceMethod();

            //int
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));

            //double
            Console.WriteLine(MyMath.Abs(52.273));
            Console.WriteLine(MyMath.Abs(-32.103));

            //long
            Console.WriteLine(MyMath.Abs(214712340385872)); //마우스 오버해서 타입 확인하기
            Console.WriteLine(MyMath.Abs(-214712340385872));

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
            /*
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
            Console.WriteLine(Fibonacci.Get(10));*/

            Fibonacci fibo = new Fibonacci();
            Console.WriteLine(fibo.Get(1));
            Console.WriteLine(fibo.Get(2));
            Console.WriteLine(fibo.Get(3));
            Console.WriteLine(fibo.Get(4));
            Console.WriteLine(fibo.Get(5));

            Console.WriteLine(fibo.Get(40));
            Console.WriteLine(fibo.Get(100));

        }

        class Fibonacci
        {
            private static Dictionary<int, long> memo = new Dictionary<int, long>();
            public long Get(int i)
            {
                if(i<0) { return 0; }
                if (i == 1) { return 1; }
                //이미 계산했던 값인지 확인
                if (memo.ContainsKey(i))
                {
                    return memo[i];
                }
                else
                {
                    //계산하지 않았다면
                    long value = Get(i - 2) + Get(i - 1);
                    memo[i] = value;
                    return value;
                }
            }

           

            /*public static int count = 0;
            public static long Get(int i)
            {
                count++;
                Console.WriteLine(count);
                if (i < 0) { return 0; }
                if (i == 1) { return 1; }
                if (memo.containsKey(i))
                {
                    return InsufficientMemoryException[i];
                }
                else
                {
                    InsufficientMemoryException[i] = Get(i - 2) + Get(i - 1);
                    return InsufficientMemoryException[i];
                }
            }*/
        }
    }
}
