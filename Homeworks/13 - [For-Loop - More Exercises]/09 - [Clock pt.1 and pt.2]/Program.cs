using System;

namespace _09____Clock_pt._1_and_pt._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours <= 23; hours++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    Console.WriteLine($"{hours} : {minutes}");
                }
            }

            //---------------------Part 2---------------------
            for (int hours = 0; hours <= 23; hours++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    for (int seconds = 0; seconds <= 59; seconds++)
                    {
                        Console.WriteLine($"{hours} : {minutes} : {seconds}");
                    }
                }
            }
            //----------------------Part 3-------------------
            for (int hours = 0; hours <= 23; hours++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    for (int seconds = 0; seconds <= 59; seconds++)
                    {
                        for (int milliseconds = 0; milliseconds <= 1000; milliseconds++)
                        {
                            Console.WriteLine($"{hours} : {minutes} : {seconds} : {milliseconds}");
                        }
                    }
                }
            }
        }
    }
}
