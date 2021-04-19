using System;

namespace _04____Rectangle_Area_
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double rectangleArea = sideA * sideB;
            Console.WriteLine(rectangleArea);
        }
    }
}
