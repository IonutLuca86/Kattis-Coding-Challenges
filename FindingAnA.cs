
//  https://open.kattis.com/problems/findingana

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string input = GetInput();
        int firstA = input.IndexOf("a");
        Console.WriteLine(input.Substring(firstA));
        }
          public static string GetInput()
        {
            string input = Console.ReadLine();
            if(input.Length > 0 && input.Length <= 1000)
                return input.ToLower();
            else
                return GetInput();
        }
        
        
    }
}