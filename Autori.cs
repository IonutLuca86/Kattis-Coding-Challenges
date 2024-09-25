
//  https://open.kattis.com/problems/autori


using System;
using System.Linq;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string input = GetInput();
        string output = string.Empty;
        if(input.Contains("-"))
        {
        string[] inputArray = input.Split('-');
        foreach(var word in inputArray)
            output += word[0];
        Console.WriteLine(output);
        }
        else
            Console.WriteLine(input[0]);
        
        }
        
        public static string GetInput()
        {
            string input = Console.ReadLine();
            if(input.Length > 0 && input.Length <= 100)
                return input;
            else
                return GetInput();
        }
        
    }
}