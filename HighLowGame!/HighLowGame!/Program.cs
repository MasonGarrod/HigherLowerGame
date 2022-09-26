using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowGame_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Random Number Generator \\
            Random rng = new Random();

            // Declare Variables \\
            int number = rng.Next(1, 100);
            int guess = 0;
            bool boolCorrect = false;

            Console.WriteLine("Welcome to the High-Low Game");
            Console.WriteLine("You will guess a number between 1 and 100 and I will tell you if the number is higher or lower.");

            while (!boolCorrect)
            {
                Console.Write("Guess: ");
                string enter = Console.ReadLine();

                if (!int.TryParse(enter, out guess))
                {
                    Console.WriteLine("That's not a number.");
                    continue;
                }

                if (guess < number)
                {
                    Console.WriteLine("Higher!");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower!");
                }
                else
                {
                    boolCorrect = true;
                    Console.WriteLine("You guessed right!");
                    Console.ReadKey();
                }
            }
        }
    }
}
