using System;

namespace _01____USD_to_BGN_
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollars = double.Parse(Console.ReadLine());
            double convertedToLevs = dollars * 1.79549;
            Console.WriteLine($"{convertedToLevs:f2}");
        }
    }
}
