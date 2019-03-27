using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "While Loop");
            Console.WriteLine();
            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine("Loop through the array ");
            int[] luckyNumbers = {4,8,15,16,23,42 };
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
            Console.ReadLine();
        }
    }
}
//1.variable initializaton;2.Loop condition;3.
//luckyNumbers.Length will get you the length of the array
// set i=0 