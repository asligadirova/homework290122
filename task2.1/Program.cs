using System;

namespace task2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) 4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir. Example1: 333= 73338

            int a = 2345; //712348
            if (a>=1000 && a<10000)
            {
                a = a + 70000;
                a = a * 10 + 8;
                Console.WriteLine(a);
            }
               
            else
            {
                Console.WriteLine("4 reqemli deyil");
            }




        }
    }
}
