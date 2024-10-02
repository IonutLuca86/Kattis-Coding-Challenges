
//  https://open.kattis.com/problems/bitteeinbit

using System;
using System.Linq;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string input = Console.ReadLine();
         char[] inputArray = input.ToCharArray();
         Random random= new Random();
         int randomPosition = random.Next(0,input.Length);
        Console.WriteLine(inputArray[randomPosition]);
    }
    }
}