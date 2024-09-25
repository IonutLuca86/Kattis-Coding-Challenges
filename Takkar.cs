
//  https://open.kattis.com/problems/takkar

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if(a > b)
            Console.WriteLine("MAGA!");
        else if(a < b)
            Console.WriteLine("FAKE NEWS!");
        else
            Console.WriteLine("WORLD WAR 3!");
           
        }
    
    }
}