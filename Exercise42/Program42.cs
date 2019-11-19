using System;

namespace Exercise42
{
    class Program42
    {
        static void Main(string[] args)
        {
            string[] badWords = { "fuck", "hell", "hoe", "cunt" };

            Console.WriteLine("Input a string: ");
            var t = Console.ReadLine();

            foreach (var i in badWords)
            {
                t = t.Replace(i, "*flowers*");
            }

            Console.WriteLine(t);
        }
    }
}
