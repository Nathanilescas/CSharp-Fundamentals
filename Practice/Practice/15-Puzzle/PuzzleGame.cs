

namespace Practice._15_Puzzle
{
    internal class PuzzleGame
    {
        private int[] startingBoardNumbers;

        private int[,] boardNumbers;

        public int[,] BoardNumbers // This will be the current Board Values
        {
            get { return boardNumbers; }
            set { boardNumbers = value; } // Change this later
        }
        


        public PuzzleGame()
        {
            BoardGenerator generateBoard = new BoardGenerator();
            startingBoardNumbers = generateBoard.Board();
            boardNumbers = BoardDisplay.BoardFiller(startingBoardNumbers);

        }

        public void Play()
        {
            while (true)
            {
                Console.WriteLine("===============================================\n");
                BoardDisplay.DisplayBoard(BoardNumbers);
                Console.WriteLine("\n==============================================");
                Movement.MovementRules(BoardNumbers);
                Console.Clear();

                if (CheckForWinner())
                {
                    break;
                }
            }
            BoardDisplay.DisplayBoard(BoardNumbers);
            Console.WriteLine("WINNER WINNER CHICKEN DINNER!!");
        }


        private bool CheckForWinner()
        {
            int[,] winnigNumbers = new int[4, 4]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 0 }
            };
            
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if (BoardNumbers[i, j] != winnigNumbers[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;

        }

    }
}
