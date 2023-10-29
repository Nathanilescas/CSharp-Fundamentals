
namespace Practice.Hangman
{
    internal class GameSystem
    {
        public static void LetterMatchingSystem(HangMan player)
        {
            char guess;
            int count = 0;

            Console.Write("Make a guess: ");
            guess = (char)Console.Read();
            Console.ReadLine();

            foreach(char letter in player.HiddenWord.word)
            {
                if (char.ToUpper(letter) == char.ToUpper(guess))
                {
                    player.CorrectGuess(count);
                    DisplaySystem(player, guess);
                    return;
                }
                ++count;
            }
            player.WrongGuess(guess);
            DisplaySystem(player, guess);
        }



        public static void DisplaySystem(HangMan player, char guess)
        {
            Console.Clear();
            DisplayWord(player);
            Console.Write($"| Remaining Guesses: {player.GuessRemaining} ");
            Console.Write($"| Incorrect Guesses: {player.IncorrectGuess}");
            Console.Write($"| Guess: {guess}\n");
            
        }

        public static void DisplayWord(HangMan player) // Part of DisplaySystem()
        {
            for (int i = 0; i < player.HiddenWord.word.Length; i++)
            {
                if (player.HiddenWord.boolWord[i])
                {
                    Console.Write(player.HiddenWord.word[i]);
                }
                else { Console.Write(" _ "); }
            }
        }


        public static bool CheckingSystem(bool[] word) // Checks to see if the hidden word has been guessed
        {
            foreach (bool letter in word)
            {
                if (!letter) { return false; }
            }
            return true;
        }

    }
}
