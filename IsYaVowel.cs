
//  https://open.kattis.com/problems/isyavowel

using System;
using System.Linq;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string input = Console.ReadLine().ToLower();  
            char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u'};
            int vowelCount = 0;
            int vowelWithYCount = 0;
           
            foreach (char c in input)
            {
                if (Array.Exists(vowels, v => v == c))
                {
                    vowelCount++;
                }
            }
            
            vowelWithYCount = vowelCount;
            foreach (char c in input)
            {
                if (c == 'y')
                {
                    vowelWithYCount++;
                }
            }
         
            Console.WriteLine(vowelCount + " " + vowelWithYCount);
        
    }
    }
}