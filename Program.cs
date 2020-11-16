using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(e)asy, (m)edium, (h)ard?");
            string difficulty = Console.ReadLine().ToLower();

            int difficultyToken = 0;

            if (difficulty == "e")
            {
                difficultyToken = 8;
            }
            else if (difficulty == "m")
            {
                difficultyToken = 6;
            }
            else if (difficulty == "h")
            {
                difficultyToken = 4;
            }



            Random r = new Random();
            int secretNumber = r.Next(1, 100);
            int token = 0;
            while (token < difficultyToken)
            {
                int remainingGuesses = difficultyToken - token;
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
                    if (guess > secretNumber)
                    {
                        Console.WriteLine("Your guess was too high!");
                    }
                    else
                    {
                        Console.WriteLine("Youre guess was too low!");

                    }
                }
            }


        }
    }
}
