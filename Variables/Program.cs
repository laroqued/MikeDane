using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int age =0;

            Console.WriteLine("Write a name for the character");
            name = Console.ReadLine();

            Console.WriteLine("Write the character age.");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"There was once a man named {name}");
            Console.WriteLine($"He was {age} years old");
            Console.WriteLine($"He really didnt like the name {name}");
            Console.WriteLine($"But he didn't like being {age}");

            Console.ReadLine();
        }
    }
}
