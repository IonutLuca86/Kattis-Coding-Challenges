
//  https://open.kattis.com/problems/fyi

using System;
using System.Linq;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string input = Console.ReadLine();
        int prefix = int.Parse(input.Substring(0,3));
        if (prefix == 555)
            Console.WriteLine("1");
        else
            Console.WriteLine("0");
            
        }
        
    }
}