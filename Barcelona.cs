
//  https://open.kattis.com/problems/barcelona

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string[] line1 = Console.ReadLine().Split(' ');
         int numberOfBags = int.Parse(line1[0]);
         int bennisBag = int.Parse(line1[1]);
         
         string[] bags = Console.ReadLine().Split(' ');
         int position = 0;
         for(int i=0;i<numberOfBags;i++)
         {
             if(int.Parse(bags[i]) == bennisBag)
                position = i+1;
         }
         if(position == 1)
            Console.WriteLine("fyrst");
        else if(position == 2)
            Console.WriteLine("naestfyrst");
        else
            Console.WriteLine($"{position} fyrst");
        }
        
    }
}