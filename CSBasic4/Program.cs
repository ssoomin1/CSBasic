﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic4
{
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
        static void Main(string[] args)
        {
            //재활용을 못하기때문에 클래스안에 클래스 만드는 것은 추천 X
            class FirstClass
        {

        }
        class SecondClass
        {

        }
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
        }
    }
}
