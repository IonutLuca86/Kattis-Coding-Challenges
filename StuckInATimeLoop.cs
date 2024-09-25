
//  https://open.kattis.com/problems/timeloop


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int magicNumber = int.Parse(Console.ReadLine());
        for(int i=1;i<=magicNumber;i++)
            Console.WriteLine($"{i} Abracadabra");
        }
        
        
        
    }
}