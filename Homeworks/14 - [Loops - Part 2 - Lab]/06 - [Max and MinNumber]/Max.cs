using System;

namespace _06____Max_and_MinNumber_
{
    class Max
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int counter = 1;
            while (counter <= number)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers > maxNumber)
                {
                    maxNumber = numbers;
                }
                counter++;
            }
            Console.WriteLine(maxNumber);
        }
    }
}
