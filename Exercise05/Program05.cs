using System;

namespace Exercise05
{
    class Program05
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name? ");
            string firstname = Console.ReadLine();

            Console.Write("What is yor last name? ");
            string lastname = Console.ReadLine();

            Console.WriteLine($"Hello {firstname} {lastname}");
        }
    }
}
