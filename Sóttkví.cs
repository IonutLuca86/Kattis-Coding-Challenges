
//  https://open.kattis.com/problems/sottkvi

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
        string[] line = Console.ReadLine().Split(' ');
        int numberOfFriends = int.Parse(line[0]);
        int bDay = int.Parse(line[1])+int.Parse(line[2]);;
        int today = int.Parse(line[2]);
        int isComming = 0;
        for(int i=0;i<numberOfFriends;i++)
            {
                int qDay = int.Parse(Console.ReadLine());
                if(qDay+14 <= bDay)
                    isComming++;
            }
        Console.WriteLine(isComming);
    }
    }
}