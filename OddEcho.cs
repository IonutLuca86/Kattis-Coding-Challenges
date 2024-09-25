
//  https://open.kattis.com/problems/oddecho

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int lines = GetInput();
        string[] words = new string[lines];
        for(int i=0;i<lines;i++)
            words[i] = Console.ReadLine();
        for(int i=0;i<lines;i++)
            {
                if(i%2 == 0)
                    Console.WriteLine(words[i]);
            }
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