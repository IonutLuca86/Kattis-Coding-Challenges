
//   https://open.kattis.com/problems/carrots


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string input = Console.ReadLine();
        string[] inputArray= input.Split(' ');
        int numberOfContestants = int.Parse(inputArray[0]);
        int huffNumber = int.Parse(inputArray[1]);
        for(int i=0; i<numberOfContestants;i++)
        {   
            Console.ReadLine();
        }
        Console.WriteLine(huffNumber);
        }
        
        
        
    }
}