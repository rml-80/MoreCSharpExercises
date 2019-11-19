using System;

namespace Exercise15
{
    class Program15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string: ");
            var txt = Console.ReadLine();

            var i = txt.Length;

            if (i > 24)
            {
                Console.WriteLine("Your string is more then 25 characters!");
            }
            else
            {
                Console.WriteLine("Your string is less then 25 characters!");
            }

        }
    }
}
