using System;

namespace _04____Sequence_2k_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number;)
            {
                Console.WriteLine(i);
                i = i * 2 + 1;
            }
        }
    }
}
