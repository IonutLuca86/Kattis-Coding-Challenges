
//  https://open.kattis.com/problems/hissingmicrophone

using System;
using System.Linq;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string input = Console.ReadLine();
        if(input.Contains("ss"))
            Console.WriteLine("hiss");
        else
            Console.WriteLine("no hiss");
        }
      
    }
}