using System;

namespace _04____Inches_to_Centimeters_
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;
            Console.WriteLine($"{centimeters:f2}");
        }
    }
}
