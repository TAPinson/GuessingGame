using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess the secret number???");
            string guess = Console.ReadLine();
            Console.WriteLine($"Your guess was: {guess}");
        }
    }
}
