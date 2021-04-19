using System;

namespace _12____Working_Hours_
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            if ((hour >= 10 && hour <= 18) && (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday"))
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
