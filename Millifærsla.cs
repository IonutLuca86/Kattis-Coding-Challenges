
//  https://open.kattis.com/problems/millifaersla

using System;
using System.Linq;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int monnei = int.Parse(Console.ReadLine());
        int fjee = int.Parse(Console.ReadLine());
        int dolla = int.Parse(Console.ReadLine());
        
        int[] serviceFees = new int[] {monnei,fjee,dolla};
        int min = serviceFees.Min();
        if(min == monnei)
        {
            Console.WriteLine("Monnei");
        }
        else if(min == fjee)
        {
            Console.WriteLine("Fjee");
        }
        else if (min == dolla)
        {
            Console.WriteLine("Dolladollabilljoll");
        }
        
        }
    
    }
}