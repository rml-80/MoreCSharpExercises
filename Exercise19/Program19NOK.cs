using System;

namespace Exercise19
{
    class Program19NOK
    {
        static void Main(string[] args)
        {
            ConsoleColor[] color = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            string[] colors = new string[color.Length];

            foreach (var i in color)
            {
                colors[i] = Convert.ToString(color[i];
            }

            Console.WriteLine("Write a color: ");
            var input = Console.ReadLine();

            var pos = Array.IndexOf(color,input);

            if (pos == - 1)
            {
                Console.WriteLine("Color dosen't exist");
            }
            else
            {
                Console.WriteLine("color exist");
            }

        }
    }
}
