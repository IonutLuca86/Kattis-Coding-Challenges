
//  https://open.kattis.com/problems/decimaldeletion

using System;
using System.Linq;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        float input = GetInput();
        Console.WriteLine(Math.Round(input));
        }
          public static float GetInput()
        {
            float input = float.Parse(Console.ReadLine());
            if(input > 0 || input <= 1000)
                return input;
            else
                return GetInput();
        }
    }
}