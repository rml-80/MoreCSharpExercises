using System;

namespace Exercise25
{
    class Program25
    {
        static void Main(string[] args)
        {
            var x = 5;
            for (int i = x; i >= 0; i--)
            {
                for (int j = 0; j <= x; j++)
                {
                    Console.Write(" = ");
                }
                x--;
                Console.WriteLine("\n");
            }
        }
    }
}
