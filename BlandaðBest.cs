
//  https://open.kattis.com/problems/blandadbest


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int meatCount = GetInput();
        if(meatCount == 1)
            {
                string meat = Console.ReadLine();
                Console.WriteLine(meat);
            }
        else
        {
        string meat1 = Console.ReadLine();
        string meat2 = Console.ReadLine();
        Console.WriteLine("blandad best");
        }
        
        }
          public static int GetInput()
        {
            int input = int.Parse(Console.ReadLine());
            if(input > 0 || input <= 2)
                return input;
            else
                return GetInput();
        }
    }
}