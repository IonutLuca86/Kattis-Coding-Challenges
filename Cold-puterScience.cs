
//  https://open.kattis.com/problems/cold

using System;
using System.Linq;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int input = int.Parse(Console.ReadLine());
        string[] inputArray = Console.ReadLine().Split(' ');
        int count = 0;
        foreach(var entry in inputArray)
        {
            if(entry.Contains("-"))
                count++;
        }
        Console.WriteLine(count);
        }
        
    }
}