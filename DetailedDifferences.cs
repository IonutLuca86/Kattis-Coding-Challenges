
//  https://open.kattis.com/problems/detaileddifferences

using System;
using System.Linq;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int lines = GetInput();
        string[] firstWord = new string[lines];
        string[] secondWord = new string[lines];
        string[] differences = new string[lines];
        for(int i=0;i<lines;i++)
        {
            firstWord[i] = Console.ReadLine();
            secondWord[i] = Console.ReadLine();
            char[] firstArray = firstWord[i].ToCharArray();
            char[] secondArray = secondWord[i].ToCharArray();
            for(int j=0;j<firstWord[i].Length;j++)
                {
                    if(firstArray[j] == secondArray[j])
                        differences[i] += ".";
                    else
                        differences[i] += "*";
                }
        }
        for(int i=0;i<lines;i++)
            {
                Console.WriteLine(firstWord[i]);
                Console.WriteLine(secondWord[i]);
                Console.WriteLine(differences[i]);
            }
        
        }
          public static int GetInput()
        {
            int input = int.Parse(Console.ReadLine());
            if(input > 0 || input <= 500)
                return input;
            else
                return GetInput();
        }
    }
}