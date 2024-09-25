
//  https://open.kattis.com/problems/chanukah

using System;
using System.Linq;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int dataSets = GetInput();
        int[] increment = new int[dataSets];
        int[] candels = new int[dataSets];
        for(int i=0;i<dataSets;i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            increment[i] = int.Parse(input[0]);
            int days = int.Parse(input[1]);
            candels[i] = days;
            for(int j=1; j<=days;j++)
                candels[i] +=j;
        }
        for(int i=0;i<dataSets;i++)
            Console.WriteLine($"{increment[i]} {candels[i]}");
        }
        public static int GetInput()
        {
            int input = int.Parse(Console.ReadLine());
            if(input > 0 || input <= 10000)
                return input;
            else
                return GetInput();
        }
    }
}