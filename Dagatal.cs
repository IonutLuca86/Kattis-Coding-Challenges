
//  https://open.kattis.com/problems/dagatal

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int year = 2019;
        int month = GetInput();
        Console.WriteLine(DateTime.DaysInMonth(year,month));
        }
          public static int GetInput()
        {
            int input = int.Parse(Console.ReadLine());
            if(input > 0 || input <= 12)
                return input;
            else
                return GetInput();
        }
    }
}