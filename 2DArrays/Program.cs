using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //2d array
            int[,] numberGrid =
            {
                {1,2},
                {3,4},
                {5,6}
            };
            Console.WriteLine(numberGrid [2,1]);// [1,1] will output 4

            Console.ReadLine();

        }
    }
}
