using System;

namespace Exercise09
{
    class Program09
    {
        static void Main(string[] args)
        {
            String str = "(abc) and (cba) are each others reverse! Same goes for (bac) and (cab)!";
            String a = str.Substring(str.IndexOf('a') - 1, 5);
            String b = str.Substring(str.IndexOf("(c"), 5);
            String c = str.Substring(str.IndexOf("(b"), 5);
            String d = str.Substring(str.IndexOf("ca") - 1, 5);
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
