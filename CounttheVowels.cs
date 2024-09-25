
//  https://open.kattis.com/problems/countthevowels

using System;
using System.Linq;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string input = Console.ReadLine();
        char[] vowels = new char[]{'a','e','i','o','u'};
        char[] inputChar = input.ToLower().ToCharArray();
        char[] result = inputChar.Where(x => vowels.Contains(x)).ToArray();
        Console.WriteLine(result.Length);
        }
    }
}