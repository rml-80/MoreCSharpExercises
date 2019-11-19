using System;

namespace Exercise35
{
    class Program35
    {
        static void Main(string[] args)
        {
            Console.Write("How long array do you want? ");
            var n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                Random rnd = new Random();
                numbers[i] = rnd.Next(1,100);
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
