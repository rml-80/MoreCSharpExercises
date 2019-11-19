using System;

namespace Exercise28
{
    class Program28
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var x = int.Parse(Console.ReadLine());
            var j = 0;

            for (int i = x - 1; i > 0; i--)
            {
                var y = x % i;

                if (y == 0 && j < 3)
                {
                    Console.WriteLine(i);
                    j++;
                }
            }

        }
    }
}
