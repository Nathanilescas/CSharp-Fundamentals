using Practice._15_Puzzle;
using Practice.Hangman;
using Practice.Tic_Tac_Toe;
using Practice;

static class Program
{
    static void Main(string[] args)
    {while(true)
        {
            Console.Write("What game do you want to play: \n" +
            "1. Rock, Paper, Scissors\n" +
            "2. 15 Puzzle \n" +
            "3. HangMan\n" +
            "4. Tic-Tac-Toe\n" +
            "Pick a number: ");
            int answer = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (answer)
            {
                case 1:
                    RPSgame rPSgame = new RPSgame(); rPSgame.Play(); Console.Clear();
                    break;
                case 2:
                    PuzzleGame puzzleGame = new PuzzleGame(); puzzleGame.Play(); Console.Clear();
                    break;
                case 3:
                    HangMan.Play(); Console.Clear();
                    break;
                case 4:
                    TicTacToe ticTacToeGame = new TicTacToe(); ticTacToeGame.Play(); Console.Clear();
                    break;
            }
        }
    }

}
