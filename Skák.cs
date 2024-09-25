
//  https://open.kattis.com/problems/skak

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string petraCoord = Console.ReadLine();
         string gardarCoord = Console.ReadLine();
         string[] pCoord = petraCoord.Split(' ');
         string[] gCoord = gardarCoord.Split(' ');
         int pX = int.Parse(pCoord[0]);
         int pY = int.Parse(pCoord[1]); 
         int gX = int.Parse(gCoord[0]);
         int gY = int.Parse(gCoord[1]);
         
         if(pX == gX || pY == gY)
            Console.WriteLine(1);
        else
            Console.WriteLine(2);
        }
        
    }
}