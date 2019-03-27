using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = false;

            Console.Write("Are you a male?:  true or false:  ");
            isMale = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Are you tall?: true or false:  ");
            isTall = Convert.ToBoolean(Console.ReadLine());

            //You are tall an male.
            if (isMale || isTall )
            {
                Console.WriteLine("You are a tall male.");
            }
            //is male and not tall
            else if (isMale && !isTall )
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are male, but you are tall");
            }
            else
            {
                Console.WriteLine("You are not male or not tall, or both");
            }
            Console.ReadLine();
        }
    }
}
