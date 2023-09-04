namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangman game");
            const char PLACEHOLDER = '_';
            const int MAX_GUESSES = 6;
            int guessesLeft = MAX_GUESSES;

            List<string> words = new List<string>
            {
            "hunting",
            "describe",
            "residence",
            "spoil",
            "output",
            "wire",
            "looting"
            };
            // Generate a random word for the player to guess
            Random randomWord = new Random();
            string wordToGuess = words[randomWord.Next(words.Count)];
            char[] gameStateLetters = new char[wordToGuess.Length];
            for (int i = 0; i < gameStateLetters.Length; i++)
            {
                gameStateLetters[i] = PLACEHOLDER;
            }
            List<char> guessedLetters = new List<char>();

            while (gameStateLetters.Contains(PLACEHOLDER) && guessesLeft > 0)
            {
                Console.Clear();
                Console.WriteLine($"Word: {string.Concat(gameStateLetters)}");
                Console.WriteLine($"Attempts left: {guessesLeft}");
                Console.Write("Guess a letter: ");
                char guess = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

                // Check if letter has already been guessed
                if (guessedLetters.Contains(guess))
                {
                    Console.WriteLine("you have already entered this letter! ");
                    continue;
                }

                // Check if player entered a number instead of a letter
                if (char.IsNumber(guess))
                {
                    Console.WriteLine("Cannot enter an Number!");
                    continue;
                }

                // Add guessed letter to the list of guessed letters
                guessedLetters.Add(guess);

                // Check if the guessed letter is in the word
                if (wordToGuess.Contains(guess))
                {
                    // Replace '_' in guessed word with the guessed letter wherever it matches
                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == guess)
                        {
                            gameStateLetters[i] = guess;
                        }
                    }
                }
                else
                {
                    // If guessed letter is not in the word, decrease remaining guesses
                    Console.WriteLine($"Incorrect guess.");
                    guessesLeft--;
                }
            }

            // Check and display if player has won or lost
            if (!gameStateLetters.Contains(PLACEHOLDER))
            {
                Console.WriteLine($"Congratulations! You guessed the word: {wordToGuess}");
            }
            else if (guessesLeft <= 0)
            {
                Console.WriteLine($"You lose! The word was: {wordToGuess}");
            }
        }
    }
}