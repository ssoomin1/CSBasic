using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic4
{
    class MyMath
    {
        int scmenumber = 42;
        public static double PI = 3.141592;
        public static void Greeting()
        {
            //클래스변수에서 일반 멤버변수 쓸 수 없다.
            //인스턴스 변수, 메소드-> 만들때 생성됨 ->클래스 변수 내에서 접근이 안됨 시험문제**
            //Console.WriteLine(scmenumber);
            Console.WriteLine("Greeting!");
        }
    }
    class Car
    {
        //기본 접근제어자가 private이다. 
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        //메소드 처음은 대문자로
        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }

        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }

    class Program
    {
        class FirstClass
        {

        }
        class SecondClass
        {

        }
        static void Main(string[] args)
        {
            //재활용을 못하기때문에 

            Car[] cars = new Car[10];

            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(100));
            Console.WriteLine(random.Next(1,19));
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());

            // List<int> list = new List<int>();
            // list.Add(52);
            //list.Add(273);
            // list.Add(32);
            //list.Add(64);
            List<int> list = new List<int>() { 52, 273, 32, 64 };
            foreach(var item in list)
            {
                Console.WriteLine("Count: " + list.Count+"\titem: "+item);
                //처리되지않은 예외 발생
                //list.Remove(item);
            }

            Console.WriteLine(Math.Abs(-1264));
            Console.WriteLine(Math.Ceiling(52.273)); //올림 53출력
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Round(52.263));
            Console.WriteLine(Math.Round(52.563));
            Console.WriteLine(Math.Max(52,273));
            Console.WriteLine(Math.Min(52,263));

            Product product = new Product();
            product.name = "감자";
            product.price = 2000;

            Console.WriteLine(product.name + " : " + product.price + "원");

            Product productA = new Product() { name = "짜장면", price = 5500 }; //생성자 만들어주지 않아도 이렇게 하면 됨
            Product productB = new Product() { name = "짬뽕", price = 8000 };
            Product productC = new Product() { name = "탕수육"};
            Product productD = new Product() { price = 999999999 };
            Product productE = new Product() { price = 3000, name="양장피" };
        }
    }
}
