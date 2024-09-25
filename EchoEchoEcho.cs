
//  https://open.kattis.com/problems/echoechoecho


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string input = GetInput();
        Console.WriteLine($"{input} {input} {input}");
        }
         public static string GetInput()
        {
            string input = Console.ReadLine();
            if(input.Length > 0 || input.Length <= 15)
                return input;
            else
                return GetInput();
        }
    }
}