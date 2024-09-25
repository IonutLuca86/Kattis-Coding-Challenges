
//  https://open.kattis.com/problems/whichisgreater

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        int a = int.Parse(inputArray[0]);
        int b = int.Parse(inputArray[1]);
        if(a>b)
            Console.WriteLine(1);
        else
            Console.WriteLine(0);
        }
        
        
        
    }
}