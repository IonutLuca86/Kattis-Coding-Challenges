
//  https://open.kattis.com/problems/tarifa

using System;
using System.Linq;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int plan = GetInput();
        int months = GetInput();
        int totalMB = plan*(months+1);
        int spent = 0;
        for(int i=0;i<months;i++)
        {
            spent += int.Parse(Console.ReadLine());
        }
        Console.WriteLine(totalMB-spent);
        }
          public static int GetInput()
        {
            int input = int.Parse(Console.ReadLine());
            if(input > 0 || input <= 100)
                return input;
            else
                return GetInput();
        }
    }
}