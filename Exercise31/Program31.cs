using System;
using System.Collections.Generic;

namespace Exercise31
{
    class Program31
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            var t = Console.ReadLine();

            var t1 = t.Replace(" ", "");
            Console.WriteLine(t1);
                        
            if (t1 == Reverse(t1))
            {
                Console.WriteLine($"{t} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{t} is not a palindrome");
            }

        }

        static string Reverse(string t)
        {
            char[] tArr = t.ToCharArray();
            Array.Reverse(tArr);
            return new string(tArr);
        }
    }

}
