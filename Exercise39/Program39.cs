using System;

namespace Exercise39
{
    class Program39
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            string[] pass = new string[5];

            names[0] = "bob";
            names[1] = "gert";
            names[2] = "bertil";
            names[3] = "per";
            names[4] = "james";


            pass[0] = "halloween";
            pass[1] = "fast";
            pass[2] = "robert";
            pass[3] = "apple";
            pass[4] = "bond";


            Console.WriteLine("Welcome!");
            Console.WriteLine("===============");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Please enter your username: ");
                var user = Console.ReadLine();

                var pos = Array.IndexOf(names, user);

                if (pos == -1)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("User dosen't exist");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                }
                else
                {
                    while (true)
                    {
                        Console.Write("Please enter your password: ");
                        var input = Console.ReadLine();

                        if (input == pass[pos])
                        {
                            Console.WriteLine();
                            Console.WriteLine("Welcome to NORAD!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid password");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                        }
                    }
                    break;
                }
            }
        }
    }
}
