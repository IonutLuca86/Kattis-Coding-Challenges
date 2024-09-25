
//  https://open.kattis.com/problems/ovissa

using System;
using System.Linq;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string input = GetInput();
         Console.WriteLine(input.Length);
           
        }
        
        public static string GetInput(){
            string input = Console.ReadLine();
            if(input.Length < 0 || input.Length > 100000 || input.All(c => c == 'u'))
                return input;
            else
               return GetInput();
        }
    }
}