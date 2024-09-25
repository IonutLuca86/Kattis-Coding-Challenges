
//  https://open.kattis.com/problems/twostones

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int numberOfStones = int.Parse(Console.ReadLine());
        if(numberOfStones % 2 == 1)
            Console.WriteLine("Alice");
        else
            Console.WriteLine("Bob");
        }
        
        
        
    }
}