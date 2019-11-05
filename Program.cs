using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string[] data = input.ToString().Split();
            string[] newString = new string[data.Length];

            var len = data.Length;
         
            int i, j;
           
            for(j = len-1, i = 0; j >= 0; j--, i++)
            {
               
                newString[i] = data[j];
             //   Console.WriteLine($"{i} :  {newString[i]}");

            }

            string res = string.Join(" ", newString);

            Console.WriteLine($"Output string : {res}");

            Console.ReadKey();
        }
    }
}
