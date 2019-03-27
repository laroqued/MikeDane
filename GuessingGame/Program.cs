using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = " ";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;


            while(guess != secretWord && !outOfGuesses )
            {
                if (guessCount < guessLimit )
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    //boolean flag
                    outOfGuesses = true;
                }
                
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.Write("You win!!");

            }

            Console.ReadLine();
        }
    }
}
