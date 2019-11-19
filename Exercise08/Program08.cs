using System;

namespace Exercise08
{
    class Program08
    {
        static void Main(string[] args)
        {

            String str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            str = str.Substring(str.IndexOf('['));
            str = str.Remove(str.IndexOf('2'),4);

            for (int i = 6; i < 11; i++)
            {
                str = str.Insert((str.Length - 1), $",{i}");
            }
            
            Console.WriteLine(str);
        }
    }
}
