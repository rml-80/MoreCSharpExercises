using System;

namespace Exercise32
{
    class Program32
    {
        static int Sum(int x, int y)
        {
            var sum = x + y;
            return sum;
        }

        static void Repeat()
        {
            Console.Write("Enter a string to repeat: ");
            var n = Console.ReadLine();
            Console.Write("How many times to repeat: ");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(n);
            }
        }

        static string ToUpper(string n)
        {
            n = n.ToUpper();

            return n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            var co = true;

            do
            {
                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine("1. Sum to numbers");
                Console.WriteLine("2. Repeat a string");
                Console.WriteLine("3. Convert a string to uppercases");
                Console.WriteLine("4. Quit");
                Console.WriteLine("=================================");

                var c = int.Parse(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        Console.Write("Enter first number: ");
                        var x = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        var y = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine(Sum(x, y));

                        break;

                    case 2:

                        Repeat();

                        break;

                    case 3:

                        Console.Write("Input a string to convert: ");
                        var n = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine(ToUpper(n));

                        break;

                    default:
                        co = false;
                        break;
                }
            }
            while (co);
        }
    }
}
