using System;

namespace Exercise17
{
    class Program17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a another number: ");
            var b = double.Parse(Console.ReadLine());

            if (b == 0)
            {
                Console.WriteLine("You can't divied by zero");
            }
            else
            {
                double c = a + b;
                Console.WriteLine("a + b = " + c);

                c = a - b;
                Console.WriteLine("a - b = " + c);

                c = a * b;
                Console.WriteLine("a * b = " + c);

                c = a / b;
                Console.WriteLine("a / b = " + c);
            }
        }
    }
}
