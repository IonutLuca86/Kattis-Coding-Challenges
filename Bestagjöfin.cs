
//  https://open.kattis.com/problems/bestagjofin

using System;
using System.Linq;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int numberOfGuests = GetInput();
        int highestRate = 0;
        string topGuest =  string.Empty;
        for(int i=0;i<numberOfGuests;i++)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            int rating = int.Parse(inputArray[1]);
            if(rating > highestRate)
            {
                highestRate = rating;
                topGuest = inputArray[0];
            }
                
        }
        Console.WriteLine(topGuest);
        }
        
         public static int GetInput()
        {
            int input = int.Parse(Console.ReadLine());
            if(input > 0 && input <= 1000)
                return input;
            else
                return GetInput();
        }
        
    }
 
}