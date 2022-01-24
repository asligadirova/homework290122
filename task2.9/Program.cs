using System;

namespace task2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 dene 5 reqemli eded verilib. Her I ededin ustune III ededi gel . II ededin usutune IV eeddi gel.
            //Sonra cavablari vur birbirine. Alinan neticeden III ededin 3 % -ni cix.
            int a = 12345;
            int b = 23456;
            int c = 34567;
            int d = 45678;
            if (a>=10000 && a<100000 && b >= 10000 && b < 100000 && c >= 10000 && c < 100000 && d >= 10000 && d< 100000)
            {
                int e;
                int f;
                int g;
                int h;
                e = a + c;
                f = b + d;
                g = e * f;
                h = g - (c * 3 / 100);

                Console.WriteLine(h);  

            }
            else
            {
                Console.WriteLine( "verilen sert odenilmir");
            }






        }
    }
}
