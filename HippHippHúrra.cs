
//   https://open.kattis.com/problems/hipphipphurra

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        while(age != 0)
            {
                Console.WriteLine($"Hipp hipp hurra, {name.Trim()}!");
                age --;
            }
           
        }
    
    }
}