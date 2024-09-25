
//   https://open.kattis.com/problems/reduplikation

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string input = Console.ReadLine();
        int replicator = int.Parse(Console.ReadLine());
        for(int i=1; i<=replicator;i++)
            Console.Write(input);
        }
    
    }
}