
//  https://open.kattis.com/problems/laegdyfirlandinu

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
        int lines = int.Parse(input[0]);
        int columns = int.Parse(input[1]);
        int[,] tempMap = new int[lines,columns];
        for(int i=0; i<lines; i++)
        {
            string[] temperatures = Console.ReadLine().Split(' ');
            for(int j=0; j<columns;j++)
            {
                tempMap[i,j] = int.Parse(temperatures[j]);
            }
        }
        int lowPresure = 0;
         for(int i=1; i<lines-1; i++)        {
            
            for(int j=1; j<columns-1;j++)
            {
                if(tempMap[i,j] < tempMap[i+1,j] && tempMap[i,j] < tempMap[i-1,j] 
                        && tempMap[i,j] < tempMap[i,j+1] && tempMap[i,j] < tempMap[i,j-1])
                        lowPresure++;
            }
        }   
        if(lowPresure > 0) 
            Console.WriteLine("Jebb");
        else
            Console.WriteLine("Neibb");
       
    }
    }
}