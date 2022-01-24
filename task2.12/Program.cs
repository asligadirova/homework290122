using System;

namespace task2._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla.
            //Sonra hamisinin 15 faizini tap ve topla.
            //Sonra yekunda alinanlar iki cavabi vur biri birine.
            //Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap.

            int a = 123456;
            int b = 234567;
            int c = 345678;
            int d = 456789;
            if (a>=100000 && a<1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000 && d >= 100000 && d < 1000000)
            {
                a = a * 10 / 100;
                b = b * 10 / 100;
                c = c * 10 / 100;
                d = d * 10 / 100;
                int cem1;
                cem1 = a + b + c + d; //Ededlerin hamisinin 10 faizini tap ve topla.

                int a1;int b1; int c1; int d1;
                a1 = a * 15 / 100;
                b1 = b * 15 / 100;
                c1 = c * 15/ 100;
                d1= d * 15 / 100;
                int cem2;
                cem2 = a1 + b1 + c1 + d1; //Sonra hamisinin 15 faizini tap ve topla
                int h;
                h = cem1 * cem2;          //Sonra yekunda alinanlar iki cavabi vur biri birine.

                h = h * 10 / 100;
                h = h * 11 / 100;

                Console.WriteLine(h);

            }
            else
            {
                Console.WriteLine("sert odenilmir");
            }




        }
    }
}
