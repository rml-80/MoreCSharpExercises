using System;

namespace Exercise04
{
    class Program04
    {
        static void Main(string[] args)
        {
            string firstname = "Bobo";
            string lastname = "HolloWeen";

            Console.Write("Please enter your first name: ");
            firstname = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            lastname = Console.ReadLine();

            Console.WriteLine(firstname);
            Console.WriteLine(lastname);
        }
    }
}
