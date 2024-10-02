
//  https://open.kattis.com/problems/dfyrirdreki

using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        double delta = Math.Sqrt(Math.Pow(b,2)-4*a*c);
        if(delta > 0)
        {
            Console.WriteLine(2);
        }
        else if(delta == 0)
            Console.WriteLine(1);
        else
            Console.WriteLine(0);
            
        
    }
    }
}