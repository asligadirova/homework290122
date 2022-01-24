using System;

namespace task2.on._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10) 3 dene 4 reqemli eded verilib.I ededin 1 % -ni, II ededin 2 % , III ededin 3 % tap.
            //Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7 % faizini gel

            int a = 4567;
            int b = 3456;
            int c = 2345;
            if (a>=1000 && a<10000 && b >= 1000 && b < 10000 && c >= 1000 &&  c< 10000)
            {
                a = a * 1 / 100;
                b = b * 2 / 100;
                c = c * 3 / 100;
                int d;
                d = (a - b - c) ;
                Console.WriteLine(d);

            }
            else
            {
                Console.WriteLine("sert odenilmir");
            }

        }
    }
}
