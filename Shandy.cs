
//  https://open.kattis.com/problems/shandy

using System;
using System.Linq;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int beer = int.Parse(Console.ReadLine());
         int lemonade = int.Parse(Console.ReadLine());
         Console.WriteLine(beer>lemonade ? lemonade*2 : beer*2);
    }
    }
}