
//  https://open.kattis.com/problems/fifa

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int freeYear = 2022;
        int totalImprovments = int.Parse(Console.ReadLine());
        int improvmentsPerYear = int.Parse(Console.ReadLine());
        
        Console.WriteLine(2022 + (totalImprovments/improvmentsPerYear));
           
        }
    
    }
}