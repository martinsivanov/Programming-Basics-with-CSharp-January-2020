using System;

namespace _08____Circle_Area_and_Perimeter_
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * r * r;
            double circlePerimeter = 2 * Math.PI * r;

            Console.WriteLine($"{circleArea:f2}");
            Console.WriteLine($"{circlePerimeter:f2}");
        }
    }
}
