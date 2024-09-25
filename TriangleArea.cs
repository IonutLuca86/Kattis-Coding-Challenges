
//   https://open.kattis.com/problems/triarea

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
        double area = (double)(a*b)/2;
        Console.WriteLine(area);
        }
        
    }
}