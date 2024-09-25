
//  https://open.kattis.com/problems/jumbojavelin

using System;
using System.Linq;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int n = Int32.Parse(Console.ReadLine());
        int[] li = new int[n];
        int output = 0;
        for (int i = 0; i < n; i++)
        {
            li[i] = Int32.Parse(Console.ReadLine());
            output += li[i];
        }
        output = output - (n - 1);
        Console.WriteLine(output);
            
        }
        
    }
}