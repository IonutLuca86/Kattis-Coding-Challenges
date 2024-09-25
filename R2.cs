
//  https://open.kattis.com/problems/r2

using System;
using System.Linq;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string[] input = Console.ReadLine().Split(' ');
        int r1 = int.Parse(input[0]);
        int s = int.Parse(input[1]);
        int result = 2*s-r1;;
        Console.WriteLine(result);
        }
      
    }
}