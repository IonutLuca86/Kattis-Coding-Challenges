
//  https://open.kattis.com/problems/spritt

using System;
using System.Linq;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string[] inputLine = Console.ReadLine().Split(' ');
        int classRooms = int.Parse(inputLine[0]);
        int bottles = int.Parse(inputLine[1]);
        int[] requests = new int[classRooms];
        for(int i=0;i<classRooms;i++)
            requests[i] = int.Parse(Console.ReadLine());
        int necessary = requests.Sum();
        if(necessary <= bottles)
            Console.WriteLine("Jebb");
        else
            Console.WriteLine("Neibb");
        }
        
    }
}