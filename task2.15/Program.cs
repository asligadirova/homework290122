using System;

namespace task2._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //15)*7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
            //3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
            // Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
            //Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
            //  Sonra alinan cavabin ustune gel 6 reqemli ededi.
            //  Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
            // Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.
            // Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.

            int a1 = 123;
            int a2 = 234;
            int a3 = 1234;
            int a4 = 2345;
            int a5 = 12345;
            int a6 = 23456;
            int a7 = 123456;
            if (a1 >= 100 && a1 < 1000 && a2 >= 100 && a2 < 1000 && a3 >= 1000 && a3 < 10000 && a4 >= 1000 && a4 < 10000 && a5 >= 10000 && a5 < 100000 && a6 >= 10000 && a6 < 100000 && a7 >= 100000 && a6 < 1000000)
            {
                int b1 = (a1 + a2 + a3) + (a3 * a4); ////3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi

                b1 = (b1 * 10 + 7) + (a5 + a6);// Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.


                int b2 = a6 * a2 * 10 + 1;   ///3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini
                int b3 = b1 - b2; //Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini
                b3 = b3 + a7;//Sonra alinan cavabin ustune gel 6 reqemli ededi.
                b3 = b3 - (a1 + a2 + a3 + a4); //Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
                b3 = b3 * 18 / 100; //Sonra alinan cavabin 18 % -ni
                b3 = b3 * 3 / 100;  // Sonra alinan cavabin 3 % -ni
                b3 = b3 * 1 / 100;  //sonra 1 % tap
                b3 = b3 + (a5 + a6); // // Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.


                Console.WriteLine(b3);




            }
            else
            {
                Console.WriteLine("sert odenmir");
            }














        }
    }
}
