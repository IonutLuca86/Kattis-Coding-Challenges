
//  https://open.kattis.com/problems/cosmicpathoptimization

using System;
using System.Linq;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int numberOfReadings = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int readingsSum = 0;
        foreach(var temp in input)
            readingsSum += int.Parse(temp);
        Console.WriteLine(readingsSum/numberOfReadings);
        }
    }
}