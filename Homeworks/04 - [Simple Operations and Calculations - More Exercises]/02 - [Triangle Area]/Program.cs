using System;

namespace _02____Triangle_Area_
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double triangleArea = side * height / 2;

            Console.WriteLine($"{triangleArea:f2}");
        }
    }
}
