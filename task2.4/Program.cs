﻿using System;

namespace task2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 reqemli eded verilib.Bu ededin axirina 7 artir.Sonra cavabin 7 % tap;

            int a = 123;
            if (a >= 100 && a < 1000)
            {
                a = a * 10 + 7;
                a = a * 7 / 100;

                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("3 reqemli deyil");
            }
        }
    }
}
