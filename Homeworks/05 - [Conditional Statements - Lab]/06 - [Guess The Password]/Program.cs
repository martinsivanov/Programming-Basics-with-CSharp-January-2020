using System;

namespace _06____Guess_The_Password_
{
    class Program
    {
        static void Main(string[] args)
        {
            string passwordInsert = Console.ReadLine();
            string password = "s3cr3t!P@ssw0rd";

            if (passwordInsert == password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
