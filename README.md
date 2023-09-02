Hangman Game in C#
Description
This is a simple console-based Hangman game implemented in C#. The game picks a random word from a pre-defined list of words and asks the user to guess one letter at a time. The player has a limited number of incorrect guesses before they lose the game.

Features
Randomly selects a word from a pre-defined list.
Allows the player to guess one letter at a time.
Keeps track of letters that have already been guessed.
Displays the number of incorrect guesses left.
Ends the game if the player has guessed all the letters in the word or has used all their allowed attempts.

Requirements
.NET SDK

How to Run
Clone the repository.
Navigate to the project directory.
Run dotnet run to start the game.

Gameplay Instructions
The game starts by displaying a series of underscores, representing the letters in the word you need to guess.
You're prompted to guess a letter.
If you guess correctly, the letter will replace the corresponding underscore(s) in the word.
If you guess incorrectly, the number of allowed incorrect guesses will decrease by 1.
You can continue to guess letters until you either guess the entire word or run out of allowed incorrect guesses.

Code Structure
Main() is the entry point of the program, where the game loop and all logic are located.
MAX_GUESSES is the constant specifying the maximum number of incorrect guesses allowed.
words is the list containing all possible words that the game can randomly pick.
gameStateLetters is the array used to track the current state of guessed and unguessed letters.
guessedLetters is the list that stores all the letters the player has guessed.

Limitations and Possible Improvements
The list of possible words is hard-coded into the program. Adding a feature to read from an external dictionary file could make the game more interesting.
The game is case-insensitive but does not handle special characters or validate input thoroughly.
Could add more features like hints, scoring system, or multiplayer support.

Author
Martin Duffy




