
//  https://open.kattis.com/problems/kvedja

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string input = GetInput();
         Console.WriteLine("Kvedja,");
         Console.WriteLine(input);
           
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