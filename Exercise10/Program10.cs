using System;

namespace Exercise10
{
    class Program10
    {
        static void Main(string[] args)
        {
            // This code dosen't get the average of a + b
            // Missing () around a + b

            //int a = 10;
            //double b = 2;
            //double average = a + b / 2;

            //Console.WriteLine(average);


            // in this code int 'd' wont calculate, giving an error. You cant calculate int with float
            int a = 10;
            int b = 3;
            int c = 7;
            //int d = 7 / 2.0f;
            double result = ((double)a / b) * 2;
            Console.WriteLine(result);
            result = a / (b * c) + 9.0f;
            Console.WriteLine(result);
            result = a * a / (b + c);
            Console.WriteLine(result);
            result = a * (b + a) -100;
            Console.WriteLine(result);
        }
    }
}
