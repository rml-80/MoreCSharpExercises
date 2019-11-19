using System;

namespace Exercise18
{
    class Program18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var x = int.Parse(Console.ReadLine());

            //if (x >= 10 && x <= 20)
            //{
            //    Console.WriteLine("Number is between 10 and 20.");
            //}
            //else
            //{
            //    Console.WriteLine("Number is NOT between 10 and 20.");
            //}

            if (x >= 10)
            {
                if (x <= 20)
                {
                    Console.WriteLine("Number is between 10 and 20.");
                }
            }
            else
            {
                Console.WriteLine("Number is NOT between 10 and 20.");
            }

        }
    }
}
