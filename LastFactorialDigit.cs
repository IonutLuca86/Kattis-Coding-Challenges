
//  https://open.kattis.com/problems/lastfactorialdigit

using System;
using System.Linq;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int row = GetInput();
        int[] factorial = new int[row];
       
        for(int i=0;i<row;i++)
        {
            int input = int.Parse(Console.ReadLine());
            factorial[i] = 1;
            for(int j=1; j<=input;j++)
                factorial[i] = factorial[i]*j;
        }
        for(int i=0;i<row;i++)
        {
            string result = factorial[i].ToString();
            Console.WriteLine($"{result[result.Length-1]}");
        }
            
        }
        public static int GetInput()
        {
            int input = int.Parse(Console.ReadLine());
            if(input > 0 || input <= 10)
                return input;
            else
                return GetInput();
        }
    }
}