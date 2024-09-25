
//  https://open.kattis.com/problems/umferd

using System;
using System.Linq;
using System.Reflection;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int numberOfSpaces = GetInput();
        int numberOfLines = GetInput();
        int totalCells = numberOfSpaces * numberOfLines;  
        int emptyCells = 0;

            
        for (int i = 0; i < numberOfLines; i++)
        {
            string lane = Console.ReadLine();
            emptyCells += lane.Count(c => c == '.');  
        }

        
        double proportion = (double)emptyCells / totalCells;
        Console.WriteLine(proportion);
        }
        
         public static int GetInput()
        {
            int input = int.Parse(Console.ReadLine());
            if(input > 0 && input <= 500)
                return input;
            else
                return GetInput();
        }
        
    }
 
}