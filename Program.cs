using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int secretNumber = r.Next(1, 100);
            int token = 0;
            while (token < 4)
            {
                int remainingGuesses = 4 - token;
                Console.WriteLine($"Can you guess the secret number??? Remaining Guesses: {remainingGuesses}");
                token++;
                string guessString = Console.ReadLine();
                int guess = Int32.Parse(guessString);


                if (guess == secretNumber)
                {
                    Console.WriteLine("Success! You've guessed the secret number!");
                    break;
                }
                else
                {
                    Console.WriteLine("Failure! You have brought shame on yourself and your family!");
                }
            }


        }
    }
}
