using System;

namespace _03____Celsius_to_Fahrenheit_
{
    class Program
    {
        static void Main(string[] args)
        {
            double deg = double.Parse(Console.ReadLine());
            double far = (deg * 1.80) + 32;
            Console.WriteLine($"{far:f2}");
        }
    }
}
