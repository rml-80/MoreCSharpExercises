using System;

namespace Exercise27
{
    class Program27
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var x = int.Parse(Console.ReadLine());
            
            for (int i = x - 1; i > 0; i--)
            {
                var y = x % i;

                if (y == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
