using System;

namespace Exercise36
{
    class Program36
    {
        static void Main(string[] args)
        {
            Console.Write("How long array do you want? ");
            var n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            int[] number2 = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                Random rnd = new Random();
                numbers[i] = rnd.Next(1, 100);
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            foreach (var item in number2)
            {
                Array.Copy(numbers,number2,n);
            }

            Console.WriteLine();

            foreach (var item in number2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
