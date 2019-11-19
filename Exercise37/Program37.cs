using System;

namespace Exercise37
{
    class Program37
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int[] number2 = new int[5];
            var totalLength = numbers.Length + number2.Length;
            int[] n3 = new int[totalLength];

            for (int i = 0; i < numbers.Length; i++)
            {
                Random rnd = new Random();
                numbers[i] = rnd.Next(1, 100);
            }

            foreach (var item in numbers)
            {
                Console.WriteLine("1: " + item);
            }

            for (int j = 0; j < number2.Length; j++)
            {
                Random rnd = new Random();
                number2[j] = rnd.Next(1, 100);
            }

            foreach (var j in number2)
            {
                Console.WriteLine("2: " + j);
            }

            foreach (var item in numbers)
            {
                //Array.Copy(numbers, n3, numbers.Length);
                Array.ConstrainedCopy(numbers, 0, n3, 0, numbers.Length);
            }

            foreach (var item in numbers)
            {
                Array.ConstrainedCopy(number2, 0, n3, numbers.Length, number2.Length);
            }

            foreach (var item in n3)
            {
                Console.WriteLine("3: " + item);
            }
        }
    }
}
