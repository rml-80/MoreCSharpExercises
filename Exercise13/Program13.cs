using System;

namespace Exercise13
{
    class Program13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            var n = int.Parse(Console.ReadLine());

            if (n % 4 == 0)
            {
                Console.WriteLine($"{n}, is divideble with 4. result {n /4}");
            }
            else
            {
                Console.WriteLine($"{n} is not divideble by 4");
            }

        }
    }
}
