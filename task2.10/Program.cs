using System;

namespace task2._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 dene 6 reqemli eded verilib.Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10 % tap.

            int a = 123456;
            int b = 234567;
            int c = 345678;
            int d;

            if (a >= 100000 && a< 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000)
            {
                a = a * 10 / 100;
                b = b * 10 / 100;
                c = c * 10 / 100;
                d = (a + b + c) * 10 / 100;
                Console.WriteLine(d);


            }
            else
            {
                Console.WriteLine("sert odenilmir");
            }





        }
    }
}
