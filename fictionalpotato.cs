using System;

class NumberGuessGame
{
    static void Main()
    {
        bool playAgain = true;

        while (playAgain)
        {
            Console.Clear();
            PlayGame();

            Console.Write("\nPlay again? (y/n): ");
            playAgain = Console.ReadLine().Trim().ToLower() == "y";
        }

        Console.WriteLine("Thanks for playing!");
    }

    static void PlayGame()
    {
        Random rand = new Random();
        int target = rand.Next(1, 101); // number between 1–100
        int attempts = 0;
        int guess = 0;

        Console.WriteLine("🎯 Guess the number (1–100)!");
        
        while (guess != target)
        {
            Console.Write("Enter your guess: ");

            if (int.TryParse(Console.ReadLine(), out guess))
            {
                attempts++;

                if (guess > target)
                {
                    Console.WriteLine("Too high! 📈");
                }
                else if (guess < target)
                {
                    Console.WriteLine("Too low! 📉");
                }
                else
                {
                    Console.WriteLine($"Correct! 🎉 You guessed it in {attempts} attempts!");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number!");
            }
        }
    }
}
