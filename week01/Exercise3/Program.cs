using System;

class Program
{
    static void Main()
    {
        Random randomGenerator = new Random();
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes") // Game loop
        {
            int magicNumber = randomGenerator.Next(1, 101); // Generate a random magic number between 1-100
            int guess = -1; // Initialize with an invalid value
            int guessCount = 0; // Counter for number of guesses

            Console.WriteLine("I have chosen a magic number between 1 and 100. Try to guess it!");

            // Loop until the correct guess
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                
                // Validate user input
                if (int.TryParse(input, out guess)) // Convert string to int safely
                {
                    guessCount++; // Increment guess count

                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it! It took you {guessCount} attempts.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}
