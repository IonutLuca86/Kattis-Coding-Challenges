
//  https://open.kattis.com/problems/knightpacking

using System;
using System.Linq;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int input = int.Parse(Console.ReadLine());
        int pieces = 0;
        if(input ==1)
            Console.WriteLine("first");
        else{
          for(int i=1;i<=input;i++)
        {
            for(int j=1;j<=input;j++)
            {
                if(i+1<=input && j+2<=input)
                    pieces += 1;
                else if(i+2<=input && j+1<=input)
                    pieces += 1;
            }   
        }
        Console.WriteLine(pieces%2==0?"second":"first");  
        }
        
        }
    }
}