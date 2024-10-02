
//  https://open.kattis.com/problems/keysphonewallet

using System;
using System.Linq;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int items = int.Parse(Console.ReadLine());
         string[] importantItems = new string[] {"keys","phone","wallet"};
         string[] itemsGrabbed = new string[items];
         for(int i=0;i<items;i++)
            itemsGrabbed[i] = Console.ReadLine().ToLower();
        
        string[] takenImportantItems = importantItems.Intersect(itemsGrabbed).ToArray();
        string[] leftHome = importantItems.Except(takenImportantItems).ToArray();
        
        if(leftHome.Length == 0)
            Console.WriteLine("ready");
        else{
             foreach(var item in leftHome)
            Console.WriteLine(item);
        }
       
    }
    }
}