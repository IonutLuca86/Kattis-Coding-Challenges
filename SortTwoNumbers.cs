
//  https://open.kattis.com/problems/sorttwonumbers

using System;
using System.Linq;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string[] input = Console.ReadLine().Split(' ');
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        if(a<b)
            Console.WriteLine(a+" "+b);
        else
            Console.WriteLine(b+" "+a);
            
        }
        
    }
}