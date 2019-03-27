using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is 2 times 3?:");
            Console.WriteLine(2 * 3);         // Basic Arithmetic: +, -, /, *

            Console.WriteLine("What is 10 modulo 3?:");
            Console.WriteLine(10 % 3);        // Modulus Op. : returns remainder of 10/3

            Console.WriteLine("What is 1 plus, two, times 3?:");
            Console.WriteLine(1 + 2 * 3);     // order of operations

            Console.WriteLine("What is 10 divided by 3.0(double)?:");
            Console.WriteLine(10 / 3.0);      // int's and doubles

            Console.WriteLine("What is 10 += 100");
            int num = 10;
            num += 100; // +=, -=, /=, *=
            Console.WriteLine(num);

            Console.WriteLine("What is num++, if num =10 and num += 100");
            num++;//prints out 111
            Console.WriteLine(num);

            Console.WriteLine("What is 2^3?:");
            Console.WriteLine(Math.Pow(2, 3));

            Console.WriteLine(" What is the square root of 144?:");
            Console.WriteLine(Math.Sqrt(144));

            Console.WriteLine("What is 2.7 rounded up ");
            Console.WriteLine(Math.Round(2.7));

            Console.WriteLine("What is the absolute value of -40?:");
            Console.WriteLine(Math.Abs(-40));

            Console.WriteLine("Which number is the largest number? 4 or 67");
            Console.WriteLine(Math.Max(4,67));

            Console.WriteLine("what is 4.43 rounded down?");
            Console.WriteLine(Math.Round(4.43));
            Console.ReadLine();

        }
    }
}
