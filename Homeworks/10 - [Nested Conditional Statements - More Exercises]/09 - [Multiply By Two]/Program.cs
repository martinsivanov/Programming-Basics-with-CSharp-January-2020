﻿using System;

namespace _09____Multiply_By_Two_
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbers = double.Parse(Console.ReadLine());

            while (numbers >= 0)
            {
                Console.WriteLine($"Result: {(numbers * 2):f2}");
                numbers = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Negative number!");
        }
    }
}
