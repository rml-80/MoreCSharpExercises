using System;

namespace Exercise12
{
    class Program12
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            var name = Console.ReadLine();

            if (name == "Bob" || name == "Alice")
            {
                Console.WriteLine($"Hi {name}");
            }
            else
            {
                Console.WriteLine($"Good Bye {name}");
            }
        }
    }
}
