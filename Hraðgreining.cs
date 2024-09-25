
//   https://open.kattis.com/problems/hradgreining

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string input = Console.ReadLine();
        if(input.ToUpper().Contains("COV"))
            Console.WriteLine("Veikur!");
        else
            Console.WriteLine("Ekki veikur!");
        }
    
    }
}