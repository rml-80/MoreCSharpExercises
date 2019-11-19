using System;

namespace Exercise24
{
    class Program24
    {
        static void Main(string[] args)
        {
            var x = 1;

            for (int i = x; i < 11; i++)
            {
                Console.WriteLine($"{i} to the power of 2 is equal to " + Math.Pow(i, 2));  
            }
            x++;
        }
    }
}
