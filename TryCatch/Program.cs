using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
                Console.ReadLine();
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);

            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
         
            Console.ReadLine();
     
        }
    }
}
