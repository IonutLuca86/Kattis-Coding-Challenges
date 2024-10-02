
//  https://open.kattis.com/problems/prjonamynstur

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
        string[] input = Console.ReadLine().Split(' ');
        int lines = int.Parse(input[0]);
        int columns = int.Parse(input[1]);
        
        Dictionary<string,int> yarnTable = new Dictionary<string,int>();
        yarnTable["."] = 20;
        yarnTable["O"] = 10;
        yarnTable[@"\"] = 25;
        yarnTable["/"] = 25;
        yarnTable["A"] = 35;
        yarnTable["^"] = 20;
        yarnTable["v"] = 20;
  
        int totalCost = 0;
        string[] recipeRow = new string[columns];
        for(int i=0;i<lines;i++)
        {
            recipeRow[i]= Console.ReadLine();
           
        }
        foreach(var row in recipeRow)
        {
            string[] steps = row
            .Split(' ');
            foreach(var step in steps)
            {
                int cost = 0;
                if(yarnTable.TryGetValue(step, out cost))
                    totalCost +=cost;
            }
        }

       Console.WriteLine(totalCost);
    }
    }
}