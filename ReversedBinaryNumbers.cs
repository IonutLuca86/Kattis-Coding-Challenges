
//  https://open.kattis.com/problems/reversebinary

using System;
using System.Linq;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int input = int.Parse(Console.ReadLine());
        string binaryInput = Convert.ToString(input,2);   
        char[] binaryChars = binaryInput.ToCharArray();
        Array.Reverse(binaryChars);
        int result = Convert.ToInt32(new string(binaryChars), 2);
        Console.WriteLine(result);
        }
        
    }
}