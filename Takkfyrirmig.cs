
//  https://open.kattis.com/problems/takkfyrirmig

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int numberOfGuests = int.Parse(Console.ReadLine());
        string[] guestNames = new string[numberOfGuests];
        for(int i=0;i<numberOfGuests;i++)
            guestNames[i] = Console.ReadLine();
        for(int i=0;i<numberOfGuests;i++)
            Console.WriteLine($"Takk {guestNames[i]}");
        }
    
    }
}