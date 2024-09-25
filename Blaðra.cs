
//   https://open.kattis.com/problems/bladra2


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string[] inputArray = Console.ReadLine().Split(' ');
         int v = int.Parse(inputArray[0]);
         int a = int.Parse(inputArray[1]);
         int t = int.Parse(inputArray[2]);
         
         double result = (double)(v * t) + (0.5 * a * Math.Pow(t, 2));
         Console.WriteLine(result);
        }
        
    }
}