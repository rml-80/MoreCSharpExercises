using System;

namespace Exercise16
{
    class Program16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose:");
            Console.WriteLine("1");
            Console.WriteLine("2"); 
            Console.WriteLine("3");
            var x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("You choose 1");
                    break;
                case 2:
                    Console.WriteLine("You choose 2");
                    break;
                case 3:
                    Console.WriteLine("You choose 3");
                    break;
                default:
                    break;
            }

        }
    }
}
