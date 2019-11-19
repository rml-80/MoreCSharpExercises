using System;

namespace Exercise30
{
    class Program30
    {
        static void Main(string[] args)
        {
            Console.Write("Entert a number: ");
            var n = int.Parse(Console.ReadLine());
            var n1 = n;

            for (int i = 0; i < n; i++)
            {
                for (int j = n1; j > 0; j--)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
                n1--;
            }
            n1 = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
                n1++;
            }
        }
    }
}
