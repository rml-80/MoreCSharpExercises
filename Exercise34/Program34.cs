using System;

namespace Exercise34
{
    class Program34
    {
        static void Main(string[] args)
        {
            var x = 0;
            int[] numbers = new int[4] { 1, 2, 3, 4 };
            string[] names = new string[4] { "Bob", "Mike", "Susan", "Joe" };

            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }

            foreach (var i in names)
            {
                
                if (x==0)
                {
                    Console.WriteLine(i);
                    x++;
                }
                else
                {
                    string name = i.ToUpper();
                    Console.WriteLine(name);
                    x = 0;
                }
            } 

        }
    }
}
