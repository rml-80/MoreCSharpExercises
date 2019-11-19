using System;

namespace Exercise11
{
    class Program11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a decimal number: ");
            double n = double.Parse(Console.ReadLine());

            var n1 = Math.Sqrt(n);
            Console.WriteLine(n1);

            var n2 = Math.Pow(n, 2);
            Console.WriteLine(n2);

            var n3 = Math.Pow(n, 3);
            Console.WriteLine(n3);

            var n4 = Math.Pow(n, 10) ;
            Console.WriteLine(n4);
        }
    }
}
