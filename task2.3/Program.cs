using System;

namespace task2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) 5 reqemli eded verilib.Bu ededin evvel 18 % sonra ise 3 % tap

            int a = 12345;
            if (a>=10000 && a<100000)
            {
                int b;
                a = a * 18 / 100;
                b = a * 3 / 100;
                Console.WriteLine(b);

            }
            else
            {
                Console.WriteLine("5 reqemli deyil");
            }
            
            

        }
    }
}
