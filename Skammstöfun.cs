
//  https://open.kattis.com/problems/skammstofun

using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int wordsCount = int.Parse(Console.ReadLine());
        if(wordsCount >=1 && wordsCount<=1000)
        {
            string[] words = Console.ReadLine().Split(' ');
        List<char> abbreviation = new List<char>();
        
        foreach(string word in words)
        {
            if(char.IsUpper(word[0]))
                {
                    abbreviation.Add(word[0]);
        }}
       Console.WriteLine(string.Join("",abbreviation));
        }
        
    }
    }
}