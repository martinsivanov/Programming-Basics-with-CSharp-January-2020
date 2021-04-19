using System;

namespace _09____WeatherForecast_pt._1___pt._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string weather = Console.ReadLine();

            if (weather == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }

            double deg = double.Parse(Console.ReadLine());

            if (deg >= 5 && deg < 12)
            {
                Console.WriteLine("Cold");
            }
            else if (deg >= 12 && deg < 15)
            {
                Console.WriteLine("Cool");
            }
            else if (deg >= 15 && deg <= 20)
            {
                Console.WriteLine("Mild");
            }
            else if (deg > 20 && deg < 26)
            {
                Console.WriteLine("Warm");
            }
            else if (deg >= 26 && deg <= 35)
            {
                Console.WriteLine("Hot");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
