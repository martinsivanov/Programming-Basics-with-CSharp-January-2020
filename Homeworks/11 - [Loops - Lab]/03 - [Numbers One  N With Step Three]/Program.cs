using System;

namespace _03____Numbers_One__N_With_Step_Three_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
