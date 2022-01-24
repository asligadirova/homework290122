using System;

namespace task2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7) 2 dene 5 reqemli eded verilib.
            //Bu ededleri toplayib. Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap

            int a = 12345;
            int b = 23456;
            if (a>=10000 && a<100000 && b >= 10000 && b < 100000)
            {
                int c;
                c = a + b; //alinan cavabin evveline ve axirina 5 artir
                Console.WriteLine(c);
                c = c + 500000;
                c = c * 10 + 5;
                c = c * 5 / 100;
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(" edeler bir ve ya her ikisi 5 reqemli deyil");
            }
            

        }
    }
}
