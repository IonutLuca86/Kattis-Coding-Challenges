
//  https://open.kattis.com/problems/qaly

using System;
using System.Linq;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int periods = GetInput();
        double qaly = 0.0;
        for(int i=0;i<periods;i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            double quality = Convert.ToDouble(input[0], CultureInfo.InvariantCulture);
            double years = Convert.ToDouble(input[1], CultureInfo.InvariantCulture);
            qaly += quality*years;
        }
        Console.WriteLine(qaly);
        }
        public static int GetInput()
        {
            int input = int.Parse(Console.ReadLine());
            if(input > 0 || input <= 100)
                return input;
            else
                return GetInput();
        }
    }
}