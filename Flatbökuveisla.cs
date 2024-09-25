// https://open.kattis.com/problems/flatbokuveisla

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int numberOfSlices = int.Parse(Console.ReadLine());
        int numberOfPersons = int.Parse(Console.ReadLine());
        Console.WriteLine(numberOfSlices%numberOfPersons);
        }
    
    }
}