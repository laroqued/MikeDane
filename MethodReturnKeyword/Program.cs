using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodReturnKeyword
{
    class Program
    {
        static void DoWork()
        {
            Console.Write("Type is a number to cube: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Cubed(num);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            DoWork();
        }
        static int Cubed(int num)
        {
            int result = num * num * num;
            Console.WriteLine($"Your number cubed is {result}");

            //return will return the data type back to the caller
            return result;
        }
    }
}
