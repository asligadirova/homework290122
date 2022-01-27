using System;

namespace task2._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14) 6 dene 6 reqemli eded verilib.Evvel hamisini topla.Sonra I ve III ededi bir birine yapishdir ve bir eded al.
            //I neticeden II neticeni cix.Alinan cavabin 10 % tap.Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11 % tap.
            long a1 = 123456;
            long a2 = 234567;
            long a3 = 345678;
            long a4 = 456789;
            long a5 = 213456;
            long a6 = 324567;

            if (a1>=100000 && a1<1000000 && a2 >= 100000 && a2 < 1000000 && a3 >= 100000 && a3 < 1000000 && a4 >= 100000 && a4 < 1000000 && a5 >= 100000 && a5 < 1000000 && a6 >= 100000 && a6 < 1000000 && a6 >= 100000)
            {
                long n1; //Evvel hamisini topla
                n1 = a1 + a2 + a3 + a4 + a5 + a6; //netice 1
                Console.WriteLine(n1);                              
                                                   
                long n2= a1 * 1000000 + a3;     //int a1 = 123456ve int a3 = 345678; bir birine yapisdir           
                Console.WriteLine(n2);
                
                long n = (n1 - n2) * 10 / 100;  //I neticeden II neticeni cix.Alinan cavabin 10 % tap.
                 n = (n + a5 + a6) * 11 / 100; ///Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11 % tap
                Console.WriteLine(n);

            }
            else
            {
                Console.WriteLine("6 reqemli deyil"); 
            }







        }
    }
}
