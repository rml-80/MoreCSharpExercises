using System;

namespace Exercise20
{
    class Program20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var x = int.Parse(Console.ReadLine());

            if (x > 0 )
            {
                for (int i = 0 ; i < x; i++)
                {
                    Console.Write(i + ",");
                }
            }
            else
            {
                Console.WriteLine("You enterd 0. Nothing much you can do with that!!!");
            }
        }
    }
}
