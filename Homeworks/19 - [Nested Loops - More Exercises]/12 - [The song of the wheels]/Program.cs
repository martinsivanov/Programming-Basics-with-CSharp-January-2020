using System;

namespace _12____The_song_of_the_wheels_
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlValue = int.Parse(Console.ReadLine());

            int counter = 0;
            string password = null;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            if ((i < j) && (k > l))
                            {
                                if (((i * j) + (k * l)) == (controlValue))
                                {
                                    Console.Write($"{i}{j}{k}{l} ");
                                    counter++;
                                    if (counter == 4)
                                    {
                                        password = $"{i}{j}{k}{l}";
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (counter > 0)
            {
                Console.WriteLine();
            }
            if (password != null)
            {
                Console.WriteLine($"Password: {password}");
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
