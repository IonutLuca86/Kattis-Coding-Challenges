
//  https://open.kattis.com/problems/ameriskur

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int input = int.Parse(Console.ReadLine());
        double result = (double)input*0.09144;
        Console.WriteLine(result);
        }
        
    }
}