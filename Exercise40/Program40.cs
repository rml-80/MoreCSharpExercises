using System;

namespace Exercise40
{
    class Program40
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string of number, separated by a comma:");
            var str = Console.ReadLine();

            string[] arr = str.Split(",");

            int[] num = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                num[i] = int.Parse(arr[i]);
            }

            var min = 100;
            var max = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }
                if (num[i] < min)
                {
                    min = num[i];
                }
            }
            Console.WriteLine("Smallest number: " + min);
            Console.WriteLine("Largest number: " + max);

            var sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }

            Console.WriteLine("Average is " + sum / num.Length);
        }
    }
}
