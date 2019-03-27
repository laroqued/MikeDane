using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    //Method perform a particular task
    //Methods can be reused.
    class Program
    {
        static void DoWork()
        {
            //You call the method SayHi() by calling it in the Dowork() method.

            Console.Write("What is your name? ");
            string inputName = Console.ReadLine();

            Console.Write("How old are you? ");
            int inputAge = Convert.ToInt32(Console.ReadLine());

            //*******I passed in a string, into the method parameters for SayHi(string name)******
            SayHi(inputName, inputAge);
            Console.ReadLine();

        }
        //a parameter (),is a value/argument that gets passed into a method. 
        static void SayHi(string name,int age)
        {
            //
            Console.WriteLine($"Hello {name}, your are {age} years old.");          
        }
        static void Main(string[] args)
        {
            DoWork();       
        }
        
    }
}
