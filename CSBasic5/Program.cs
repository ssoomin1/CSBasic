﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic5
{
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

          


        }
    }
}
