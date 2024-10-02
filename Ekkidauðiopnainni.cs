

// https://open.kattis.com/problems/ekkidaudi

using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string[] line1 = Console.ReadLine().Split('|');
        string[] line2 = Console.ReadLine().Split('|');
        List<string> result = new List<string>();
        
        for(int i=0;i<line1.Length;i++)
        {
            result.Add(line1[i]+line2[i]);
        }
        Console.WriteLine(string.Join(" ",result));
        
    }
    }
}