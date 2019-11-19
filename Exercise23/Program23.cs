using System;

namespace Exercise23
{
    class Program23
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.Write(j * i + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
