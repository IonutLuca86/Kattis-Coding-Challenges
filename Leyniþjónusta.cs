
//  https://open.kattis.com/problems/leynithjonusta

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string input = GetInput();
        Console.WriteLine(input.Replace(" ",""));
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