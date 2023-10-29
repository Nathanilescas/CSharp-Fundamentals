

namespace Practice.Hangman
{
    internal class HangMan
    {
        private (char[] word, bool[] boolword) hiddenWord = WordSystem.GetWord();
        private int guessRemaining = 6;
        private string incorrectGuess = "";

        public (char[]word, bool[]boolWord) HiddenWord
        {
            get { return hiddenWord; }
        }

        public int GuessRemaining
        {
            get { return guessRemaining; }
        }

        public string IncorrectGuess
        {
            get { return incorrectGuess; }
        }

        public void CorrectGuess(int spot)
        {
            hiddenWord.boolword[spot] = true;
        }

        public void WrongGuess(char letter)
        {
            incorrectGuess += char.ToUpper(letter);
            --guessRemaining;
        }


        public static void Play()
        {
            HangMan game = new HangMan();
            bool wonGame = false;

            while(true)
            {

                GameSystem.LetterMatchingSystem(game);
                wonGame = GameSystem.CheckingSystem(game.hiddenWord.boolword);

                if (wonGame)
                {
                    Console.WriteLine("You Won!!");
                    break;
                }
                else if(game.guessRemaining == 0)
                {
                    Console.WriteLine("You lose");
                    break;
                }
               
            }

        }
    }
}
