﻿using System;

namespace _03____2D_RectangleArea_And_Perimeter_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double length = Math.Abs(x1 - x2);
            double width = Math.Abs(y1 - y2);

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimeter:f2}");
        }
    }
}
