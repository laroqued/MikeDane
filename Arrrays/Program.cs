using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Arrays is container, its structure can hold multiple variables.
//You have to specify the data type. ex: int
//the numbers inside the {} are called elements.
namespace Arrrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 16, 23, 42 };
            //the first index in the array is 0.
            //the first element is 4.
            Console.WriteLine(luckyNumbers[0]);

            //you can update the value of index[1] to 900.
            luckyNumbers[1] = 900;
            Console.WriteLine(luckyNumbers [1]);

            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Jack";
            friends[2] = "Sally";
            friends[3] = "Bob";
            friends[4] = "Donnyves";
            Console.WriteLine($"{friends [4]} is the best!!");

            Console.ReadLine();
        }
    }
}
