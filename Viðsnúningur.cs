
//  https://open.kattis.com/problems/vidsnuningur

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string input = Console.ReadLine();
        char[] inputArray = input.ToCharArray();
        Array.Reverse(inputArray);
        Console.WriteLine(new string(inputArray));
        }
    
    }
}