using System;

namespace Exercise21
{
    class Program21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var x = int.Parse(Console.ReadLine());

            if (x > 0)
            {
                for (int i = x; i >= 0; i--)
                {
                    Console.Write(i + ",");
                }
            }
            else
            {
                Console.WriteLine("You enterd 0 or below. Nothing much you can do with that!!!");
            }
        }
    }
}

