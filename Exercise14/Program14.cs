using System;

namespace Exercise14
{
    class Program14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string of text: ");
            var txt = Console.ReadLine();

            var i = txt.IndexOf("city");

            if (i == -1)
            {
                Console.WriteLine("Couldn't find city in your string!");
            }
            else
            {
                Console.WriteLine($"City is in your string at position: {i}");
            }
        }
    }
}
