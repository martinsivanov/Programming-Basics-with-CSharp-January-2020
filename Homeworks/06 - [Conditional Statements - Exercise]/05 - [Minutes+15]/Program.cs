﻿using System;

namespace _05____Minutes_15_
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputHours = int.Parse(Console.ReadLine());
            int inputMinutes = int.Parse(Console.ReadLine());

            int convertToMinutes = inputHours * 60 + inputMinutes + 15;
            int convertedToHours = convertToMinutes / 60;

            if (convertedToHours >= 24)
            {
                convertedToHours = 0;
            }
            int totalMinutes = convertToMinutes % 60;

            Console.WriteLine($"{convertedToHours}:{totalMinutes:d2}");
        }
    }
}
