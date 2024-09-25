
//  https://open.kattis.com/problems/storafmaeli

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int age = int.Parse(Console.ReadLine());
        if(age%10 == 0)
            Console.WriteLine("Jebb");
        else
            Console.WriteLine("Neibb");
           
        }
    
      
    }
}