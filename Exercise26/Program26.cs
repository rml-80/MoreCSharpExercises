using System;

namespace Exercise26
{
    class Program26
    {
        static void Main(string[] args)
        {
            var x = 0;
            var sum = 0;
            var times = 0;


            // Counting -1

            //while (x != -1)
            //{
            //    Console.WriteLine("enter a number: ");
            //    x = int.Parse(Console.ReadLine());
            //    times++;
            //    sum += x;
            //}
            //    double y = sum / times;
            //    Console.WriteLine($"The sum is: {sum}");
            //    Console.WriteLine($"The average is: {y}");

            // Not counting -1
            while (true)
            {
                Console.WriteLine("enter a number: ");
                x = int.Parse(Console.ReadLine());

                if (x == -1)
                {
                    Console.WriteLine($"The sum is: {sum}");
                    double y = sum / times;
                    Console.WriteLine($"The average is: {y}");
                    break;
                }
                else
                {
                    sum += x;
                    times++;
                }
            }

        }
    }
}
