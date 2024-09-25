
//  https://open.kattis.com/problems/jackolanternjuxtaposition


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        int eyes = int.Parse(inputArray[0]);
        int noses = int.Parse(inputArray[1]);
        int mouths = int.Parse(inputArray[2]);
        Console.WriteLine(eyes*noses*mouths);
        }
        
        
        
    }
}