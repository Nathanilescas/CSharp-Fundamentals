
namespace Practice.Tic_Tac_Toe
{
    internal class GameBoard
    {

        /// <summary>
        /// **Must have a board with PlacingSystem()** This method locates the X,Y position on the board
        /// </summary>
        /// <param name="board"></param>
        /// <param name="num"></param>
        /// <returns>X,Y position</returns>
        public static (int, int) LocatePlace(int[,] board, int num)
        {
            (int X, int Y) coordinate = (0, 0);

            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    if (board[a, b] == num)
                    {
                        coordinate = (a, b);
                    }
                }
            }
            return coordinate;
        }


        public static int[,] PlacingSystem()
        {
            int[,] assignBoard = new int[3, 3];
            int assignNum = 9;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 2; j > -1; j--)
                {
                    assignBoard[i, j] = assignNum;
                    --assignNum;
                }
            }
            return assignBoard;
        }


    }
}
