using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWork();
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
          
        
            return result;
        }
        static void DoWork()
        {
            Console.Write("Type integer number 1 of 3:  ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Type integer number 2 of 3:  ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Type integer number 3 of 3:  ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The biggest number is: ");
            Console.WriteLine();
            Console.WriteLine(GetMax(num1,num2,num3));
            Console.ReadLine();
        }
    }
}
