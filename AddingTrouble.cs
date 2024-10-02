

//  https://open.kattis.com/problems/addingtrouble


using System;
using System.Linq;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string[] input = Console.ReadLine().Split(' ');
        int a=int.Parse(input[0]);
        int b=int.Parse(input[1]);
        int c=int.Parse(input[2]);
        if(a+b==c)
            Console.WriteLine("correct!");
        else
            Console.WriteLine("wrong!");
        
        }
    }
}