using System;

namespace task2._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 dene eded verilib.Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir. 5 reqemli ededlerin 5 % tap ,neticeleri vur bir birine.
            //Sonra 3 reqemli ededlerin 3 % tap ,neticeleri topla. Sonra yekunda alinan iki cavalarin her birinin 10 % -ni tapib topla.
            int a = 12345;
            int b = 23456;
            int c = 34567;
            int d = 123;
            int e = 234;
            if (a>=10000 && a<100000 && b>=10000 && b<100000 && c>=10000 && c<100000 && d>=100 && d<1000 && e >= 100 && e < 1000)
            {
                a = a * 5 / 100;    //5 reqemli ededlerin 5 % tap
                b = b * 5 / 100;
                c = c * 5 / 100;
                int hasil;
                hasil = a * b * c;   //neticeleri vur bir birine

                d = d * 3 / 100;     //Sonra 3 reqemli ededlerin 3 % tap
                e = e * 3 / 100;
                int cem;
                cem = d + e;        //neticeleri topla

                hasil = hasil * 10 / 100;
                cem = cem * 10 / 100;
                int cem1;
                cem1 = hasil + cem;


                Console.WriteLine(cem1);
            }







        }
    }
}
