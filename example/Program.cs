using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain;
            do
            {

                // Conditions for the fruits
                string[] words = { "Apple", "Banana", "Orange" };
            string[] hints = { "It's a green round fruit.", "It's a yellow moonlike fruit.", "It's a round and is also a color fruit." };

            Random random = new Random();
            int randomIndex = random.Next(words.Length);
            string selectedWord = words[randomIndex];
            string hint = hints[randomIndex];

            char[] guessedLetters = new char[selectedWord.Length];
            int attempts = 6;
            int correctGuesses = 0;
            int score = 0;

            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("Guess the letters to reveal the word.");

            // Initialize guessedLetters array with underscores
            for (int i = 0; i < selectedWord.Length; i++)
            {
                guessedLetters[i] = '_';
            }

            while (attempts > 0 && correctGuesses < selectedWord.Length)
            {
                Console.WriteLine();
                Console.WriteLine("Attempts Remaining: " + attempts);
                Console.WriteLine("Word: " + new string(guessedLetters));
                Console.WriteLine("Hint: " + hint);

                Console.Write("Enter a letter: ");
                char letter = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (!char.IsLetter(letter))
                {
                    Console.WriteLine("Invalid input! Please enter a letter.");
                    continue;
                }

                bool found = false;

                for (int i = 0; i < selectedWord.Length; i++)
                {
                    if (char.ToUpper(selectedWord[i]) == letter && guessedLetters[i] != letter)
                    {
                        guessedLetters[i] = letter;
                        correctGuesses++;
                        found = true;
                    }
                }

                if (found)
                {
                    Console.WriteLine("Correct guess!");
                    score += 10; // Increment score for each correct guess
                }
                else
                {
                    Console.WriteLine("Incorrect guess!");
                    attempts--;
                }
            }

            Console.WriteLine();

            if (correctGuesses == selectedWord.Length)
            {
                Console.WriteLine("Congratulations! You guessed the word: " + selectedWord);
            }
            else
            {
                Console.WriteLine("Game over! The word was: " + selectedWord);
            }

            Console.WriteLine("Score: " + score); // Display the final score
            Console.WriteLine("Thank you for playing Hangman!");

            Console.WriteLine("Do you want to play again? (yes/no)");
            Console.WriteLine();
            string playAgainChoice = Console.ReadLine().ToLower();

            playAgain = (playAgainChoice == "yes");
            Console.WriteLine();
        }
            while (playAgain);

            Console.WriteLine("Thank you for playing!");
        }
    }
}
