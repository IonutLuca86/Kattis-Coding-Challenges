
//  https://open.kattis.com/problems/nsum


using System;
using System.Linq;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int n = GetInput();
        string[] numbers = Console.ReadLine().Split(' ');
        int output = 0;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(numbers[i]);
            output += number;
        }
        Console.WriteLine(output);
            
        }
          public static int GetInput()
        {
            int input = int.Parse(Console.ReadLine());
            if(input > 1 && input <= 10)
                return input;
            else
                return GetInput();
        }
    }
}