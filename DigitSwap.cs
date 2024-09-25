
//  https://open.kattis.com/problems/digitswap

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string input = GetInput();
        char[] inputCharArray = input.ToCharArray();
        Array.Reverse(inputCharArray);
        Console.WriteLine(new string(inputCharArray));
        }
        
        public static string GetInput()
        {
            string input = Console.ReadLine();
            if(input.Length > 0 && input.Length <= 2 && !input.Contains('0'))
                return input;
            else
                return GetInput();
        }
        
    }
}