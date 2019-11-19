using System;

namespace Exercise22
{
    class Program22
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
