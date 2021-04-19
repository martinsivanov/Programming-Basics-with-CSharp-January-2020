using System;

namespace _02____Radians_to_Degrees_
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double convertedToDegrees = radians * 180 / Math.PI;
            Console.WriteLine(Math.Round(convertedToDegrees));
        }
    }
}
