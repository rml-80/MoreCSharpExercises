using System;

namespace Exercise29
{
    class Program29
    {
        static void Main(string[] args)
        {
            var a = 0;
            var b = 1;

            Console.WriteLine("How long Fibonacci serie do you want to show?");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("0");

            for (int i = 0; i < n - 1; i++)
            {
                int tmp = a;
                a = b;
                b = tmp + b;
                Console.WriteLine(a);
            }
        }
    }
}
