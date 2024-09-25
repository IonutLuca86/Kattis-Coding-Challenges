
//  https://open.kattis.com/problems/oddities

using System;
using System.Linq;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int lines = GetInput();
        int[] inputArray = new int[lines];
        for(int i=0;i<lines;i++)
            inputArray[i] = int.Parse(Console.ReadLine());
        for(int i=0;i<inputArray.Length;i++)
            {
                if(inputArray[i]%2 == 0)
                    Console.WriteLine($"{inputArray[i]} is even");
                else
                    Console.WriteLine($"{inputArray[i]} is odd");
            }
        }
          public static int GetInput()
        {
            int input = int.Parse(Console.ReadLine());
            if(input > 0 || input <= 20)
                return input;
            else
                return GetInput();
        }
    }
}