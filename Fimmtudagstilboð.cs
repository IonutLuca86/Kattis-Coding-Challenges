
//  https://open.kattis.com/problems/fimmtudagstilbod

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
         int basePrice = 1000;
         if(input <= 2020)
            Console.WriteLine(basePrice);
        else
        {
            int newPrice = (input-2020)*100+basePrice;
            Console.WriteLine(newPrice);
        }
            
       
    }
    }
}