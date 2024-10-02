
//  https://open.kattis.com/problems/betting

using System;
using System.Linq;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int input = int.Parse(Console.ReadLine());
        double ratio1 = (double)100/input;
        double ratio2 = (double)100/(100-input);
         Console.WriteLine(ratio1.ToString("F10"));
        Console.WriteLine(ratio2.ToString("F10"));
        }
    }
}