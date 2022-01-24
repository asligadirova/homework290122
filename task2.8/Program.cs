using System;

namespace task2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 dene eded verilib.I eded 4 reqemli II eded 7 reqemlidir.
            // I ededin 4 % -ni tap.
            // Sonra II ededin 9 % ni tap.
            // Sonra Cavalari toplayib 10 % ni tap.
            int a = 1234;
            int b = 1234567;
            if (a>=1000 && a<10000 && b>=1000000 && b<10000000)
            {
                a = a * 4 / 100;
                b = b * 9 / 100;
                int c;
                c = (a + b) * 10 / 100;
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("verilen sertler odenilmir");    
            }


        }
    }
}
