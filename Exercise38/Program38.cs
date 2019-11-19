using System;
using System.Collections;

namespace Exercise38
{
    class Program38
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[5];
            int[] n2 = new int[5];
            Random rnd = new Random();

            for (int i = 0; i < n1.Length; i++)
            {
                n1[i] = rnd.Next(1,1000);
                n2[i] = rnd.Next(1,1000);
            }

            foreach (var item in n1)
            {
                Console.WriteLine("1: " + item);
            }

            foreach (var item in n2)
            {
                Console.WriteLine("2: " + item);
            }
            
            ArrayList even = new ArrayList();
            ArrayList odd = new ArrayList();

            for (int i = 0; i < n1.Length; i++)
            {
                var number = n1[i];

                if (number % 2 == 0)
                {
                    even.Add(n1[i]);
                }
                else
                {
                    odd.Add(n1[i]);
                }
            }

            for (int i = 0; i < n2.Length; i++)
            {
                var number = n2[i];

                if (number % 2 == 0)
                {
                    even.Add(n2[i]);
                }
                else
                {
                    odd.Add(n2[i]);
                }
            }
            Console.WriteLine();

            foreach (var item in even)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in odd)
            {
                Console.WriteLine(item);
            }

            int[] oddArr = odd.ToArray(typeof(int)) as int[];
            int[] evenArr = even.ToArray(typeof(int)) as int[];

            int[] n3 = new int[10];

            oddArr.CopyTo(n3, 0);
            evenArr.CopyTo(n3, oddArr.Length);

            Console.WriteLine();

            foreach (var i in n3)   
            {
                Console.WriteLine("3: " + i);
            }
        }   
    }
}
