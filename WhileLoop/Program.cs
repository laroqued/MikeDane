using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While loop: index <= 5");
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.WriteLine();
            Console.WriteLine("Do While Loop");
            // although 6 in not <= than 5, the loop is executed at least once.
            int i= 6;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 5);
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
