using System;

namespace _06____Vacation_books_list_
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesInCurrBook = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double totalTimeForRead = pagesInCurrBook / pagesPerHour;
            double totalHoursPerDay = totalTimeForRead / days;
            Console.WriteLine(totalHoursPerDay);
        }
    }
}
