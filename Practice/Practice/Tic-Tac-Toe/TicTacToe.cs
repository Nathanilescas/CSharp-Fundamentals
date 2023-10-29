
namespace Practice.Tic_Tac_Toe
{
    internal class TicTacToe
    {
        private bool player;
        private char[,] gameBoard = new char[3, 3];
        private int[,] placementBoard = GameBoard.PlacingSystem();
        private int[] numbersCalled = new int[9];
        public bool Player
        {
            get { return player; }
        }



        public void Play()
        {
            int count = 0;
            int X;
            int Y;
            player = true;


            Display(gameBoard, player);

            while (true)
            {
                while (true) // Input loop
                {
                    int input;
                    input = CheckingSystem.InputFromPlayer();
                    if (CheckingSystem.DuplicateNumber(input, numbersCalled))
                    {
                        Console.WriteLine("That number was chosen already.");
                        continue;
                    }
                    else
                    {
                        numbersCalled[count++] += input;
                        break;
                    }
                }

                // Placement of X or O
                (X, Y) = GameBoard.LocatePlace(placementBoard, numbersCalled[count - 1]);
                gameBoard[X, Y] = player ? 'X' : 'O';

                // Checking System
                if (CheckingSystem.DCheckSystem(gameBoard, Player) || CheckingSystem.VHCheckSystem(gameBoard, Player))
                {
                    Display(gameBoard, player);// tessst
                    break;
                }
                Console.Clear();
                Display(gameBoard, player);
                player = (player) ? false : true;

            }
            Console.Write($"Player ");
            Console.Write(player ? "1" : "2");
            Console.Write(" WON!!");


        }


        public void Display(char[,] gameBoard, bool player)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                    if (gameBoard[i, j] == 'X' || gameBoard[i, j] == 'O')
                    {
                        Console.Write(gameBoard[i, j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" | ");
                }
                Console.Write(gameBoard[i, 2]);
                Console.WriteLine();
            }


        }
    }
}
