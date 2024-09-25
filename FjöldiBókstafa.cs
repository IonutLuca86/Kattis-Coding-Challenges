
//  https://open.kattis.com/problems/fjoldibokstafa

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string input = GetInput();
        
        Regex regEx = new Regex("[^a-zA-Z]");
        input = regEx.Replace(input,"");
        
        Console.WriteLine(input.Length);
        }
          public static string GetInput()
        {
            string input = Console.ReadLine();
            if(input.Length > 0 || input.Length <= 100)
                return input;
            else
                return GetInput();
        }
    }
}