﻿using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int sum = 0, mul = 1;
            int number;
            for (int i = 1; i <= 10; i++)
            {
                number = int.Parse(Console.ReadLine());
                sum += number;
                mul *= number;
            }
            Console.WriteLine("Summa: {0}", sum);
            Console.WriteLine("Mul: {0}", mul);
        }
    }
}
