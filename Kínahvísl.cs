
//  https://open.kattis.com/problems/kinahvisl

using System;
using System.Linq;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        char[] firstWord = Console.ReadLine().ToLower().ToCharArray();
        char[] secondWord = Console.ReadLine().ToLower().ToCharArray();
        int numberOfPlayers = 1;
        for(int i=0; i<firstWord.Length;i++)
        {
            if(firstWord[i] != secondWord[i])    
                numberOfPlayers++;
            else
                continue;
        }
        Console.WriteLine(numberOfPlayers);
            
       
    }
    }
}