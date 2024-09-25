
//  https://open.kattis.com/problems/bijele

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string[] inputArray = Console.ReadLine().Split(' ');
        int[] chessPieces = new int[] {1,1,2,2,2,8};
       
        for(int i=0;i<6;i++)
            {
                int input = int.Parse(inputArray[i]);
                if(input > chessPieces[i])
                    Console.Write($"-{input-chessPieces[i]} ");
                else if(input < chessPieces[i])
                    Console.Write(chessPieces[i]-input+" ");
                else
                    Console.Write(0+" ");
            }
        }
        
    }
}