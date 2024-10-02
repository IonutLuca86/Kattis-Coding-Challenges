
//  https://open.kattis.com/problems/monopol

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
        int numberOfHotels = int.Parse(Console.ReadLine());
        string[] distances = Console.ReadLine().Split(' ');
        double probability = 0.0;
        foreach(var distance in distances)
        {
            int value= int.Parse(distance);
            if(value == 2 || value == 12)
                probability += (double)1/36;
            else if(value == 3 || value == 11)
                probability += (double)2/36;
            else if(value == 4|| value == 10)
                probability += (double)3/36;
            else if(value == 5 || value == 9)
                probability += (double)4/36;
            else if(value == 6 || value == 8)
                probability += (double)5/36;
            else if(value == 7)
                probability += (double)6/36;
        }
       Console.WriteLine(probability);
    }
    }
}