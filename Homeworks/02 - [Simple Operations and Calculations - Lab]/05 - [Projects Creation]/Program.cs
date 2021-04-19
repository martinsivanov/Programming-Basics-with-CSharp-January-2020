using System;

namespace _05____Projects_Creation_
{
    class Program
    {
        static void Main(string[] args)
        {
            string archName = Console.ReadLine();
            int projectsNumber = int.Parse(Console.ReadLine());

            int neededHours = projectsNumber * 3;
            Console.WriteLine($"The architect {archName} will need {neededHours} hours to complete {projectsNumber} project/s.");
        }
    }
}
