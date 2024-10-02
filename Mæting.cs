
//  https://open.kattis.com/problems/maeting

using System;
using System.Linq;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string[] numberOfStudents = Console.ReadLine().Split(' ');
         string[] students1Day = Console.ReadLine().Split(' ');
         string[] students2Day = Console.ReadLine().Split(' ');
         string[] students = students1Day.Intersect(students2Day).ToArray();
         Console.WriteLine(string.Join(" ",students));
    }
    }
}