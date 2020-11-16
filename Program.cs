using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess the secret number???");
            string guess = Console.ReadLine();
            string secretNumber = "42";

            if (guess == secretNumber)
            {
                Console.WriteLine("Success! You've guessed the secret number!");
            }
            else
            {
                Console.WriteLine("Failure! You have brought shame on yourself and your family!");
            }

        }
    }
}
