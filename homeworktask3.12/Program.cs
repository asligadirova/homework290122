using System;

namespace homeworktask3._12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2 dene 5 reqemli eded daxil et.
            //I ededin reqemleri ceminin usutne
            //II ededin reqemleri hasilini gel.
            //Neticenin axirina I ededin en axiinci reqemini artir

            int a = 12345;

            if (a >= 10000 && a < 100000)
            {
                int cem = 0;
                int qaliq;

                while (a > 0)
                {
                    qaliq = a % 10; //5
                    a = (a - qaliq) / 10;

                    cem = cem + qaliq;

                }
                Console.WriteLine(cem);

            }
            else
            {
                Console.WriteLine("5 reqemli deyil");
            }

            int b = 23456;

            if (b >= 10000 && b < 100000)
            {
                int hasil = 1;
                int qaliq2;

                while (b > 0)
                {
                    qaliq2 = b % 10; //5
                    b = (b - qaliq2) / 10;

                    hasil = hasil * qaliq2;

                }
                   Console.WriteLine(hasil);
                   int cem = 15;
                   int c = cem + hasil;
                   Console.WriteLine(c);
                // ineticenin (735) axirina I (15) ededin en axiinci reqemini artir // 735=7355
                int d; 
                int qaliq3;
                qaliq3 = cem % 10; //5
                d = c * 10 + qaliq3;
                Console.WriteLine(d);



            }







        }
    }
}
