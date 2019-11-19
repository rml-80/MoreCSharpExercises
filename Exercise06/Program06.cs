using System;

namespace Exercise06
{
    class Program06
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name? ");
            string firstname = Console.ReadLine();
            firstname = firstname.ToUpper();

            Console.Write("What is yor last name? ");
            string lastname = Console.ReadLine();
            lastname = lastname.ToUpper();

            Console.WriteLine($"Hello {firstname} {lastname}");
        }
    }
}
