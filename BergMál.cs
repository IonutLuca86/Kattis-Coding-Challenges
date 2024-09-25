// https://open.kattis.com/problems/bergmal

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine(GetInput());
        }
          public static string GetInput()
        {
            string input = Console.ReadLine();
            if(input.Length > 0 || input.Length <= 1000)
                return input;
            else
                return GetInput();
        }
    }
}