using System;
using System.Linq;

namespace Exercise07
{
    class Program07
    {
        static void Main(string[] args)
        {
            string str = "The quick fox Jumped Over the DOG";
            str = str.ToLower();
            str = str.First().ToString().ToUpper() + str.Substring(1);
            str = str.Replace("quick", "brown");
            str = str.Insert(str.Length - 4, " lazy");
            Console.WriteLine(str);
        }
    }
}
