using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnyves\nLaroque");//new line character \n
            Console.WriteLine();

            Console.WriteLine("Donnyves\"Laroque\"");//write out a quotation mark
            Console.WriteLine();

            string phrase = "Donnyves is cool" + ", or not";//concatenation
            Console.WriteLine(phrase);//passing in a variable inside the writeline method
            Console.WriteLine();

            phrase = "How long is this string?";
            Console.WriteLine(phrase.Length);// Length {get;} I will tell you how characters are in the string.             
            Console.WriteLine();

            phrase = "I want to be all uppercase!";
            Console.WriteLine(phrase.ToUpper() );//Use the ToUpper method to make all the characters uppercase
            Console.WriteLine();

            phrase = "I WANT TO BE ALL LOWERCASE";
            Console.WriteLine(phrase .ToLower ());//ToLower changes all the character to lower case.
            Console.WriteLine();

            phrase = "I wonder if I contain a certain text";
            Console.WriteLine(phrase.Contains (" text"));//Contains() help you find a word or character in your string.
            Console.WriteLine();

            phrase = "Hello";
            Console.WriteLine(phrase[0]); //Prints out the index of a string. Index 0 should print out H.
            Console.WriteLine();

            phrase = "Let's find the index of something";
            Console.WriteLine(phrase.IndexOf("index"));//Tell you the index location of the string or character. If it's not included, you get a -1.
            Console.WriteLine();

            phrase = "What is a substring";
            Console.WriteLine(phrase .Substring (10, 3));//Allows you get one part of the string at start of index 10, and then the next 3 character. 

            Console.ReadLine();

        }
    }
}
