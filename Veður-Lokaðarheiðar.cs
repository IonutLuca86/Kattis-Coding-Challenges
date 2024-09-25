
//  https://open.kattis.com/problems/vedurheidar

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int currentWindSpeed = GetInput1();
        int numberOfRoads = GetInput2();
        string[] roadNames = new string[numberOfRoads];
        int[] windSpeeds = new int[numberOfRoads];
        for(int i=0;i<numberOfRoads;i++)
            {
                string[] roadArray = Console.ReadLine().Split(' ');
                roadNames[i] = roadArray[0];
                windSpeeds[i] = int.Parse(roadArray[1]);
                
            }
        for(int i=0;i<numberOfRoads;i++)
            {
                if(currentWindSpeed > windSpeeds[i])
                    Console.WriteLine($"{roadNames[i]} lokud");
                else
                    Console.WriteLine($"{roadNames[i]} opin");
            }
        }
        public static int GetInput1()
        {
            int input = int.Parse(Console.ReadLine());
            if(input > 0 || input <= 200)
                return input;
            else
                return GetInput1();
        }
        public static int GetInput2()
        {
            int input = int.Parse(Console.ReadLine());
            if(input > 0 || input <= 100)
                return input;
            else
                return GetInput2();
        }
    }
}