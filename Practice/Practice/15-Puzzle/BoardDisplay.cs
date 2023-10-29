

using Practice;
using Practice._15_Puzzle;

namespace Practice
{
    internal static class BoardDisplay
    {
        public static void DisplayBoard(int[,]place)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(Box(place[i,0], place[i, 1],place[i, 2],place[i, 3]));
            }
        }
        private static string Box(int num1, int num2, int num3, int num4)
        {
            string box = 
             (" _____ \t _____ \t _____ \t _____\n") +
             ("|     |\t|     | |     | |     | \n" +
             $"|{num1,3}  | |{num2,3}  | |{num3,3}  | |{num4,3}  |\n" +
              "|_____|\t|_____| |_____| |_____| \n");
            return box;
        }

        public static int[,] BoardFiller(int[] board)
        {
            int[,] placeHolder = new int[4, 4];
            int count = 0;

            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4 ; j++)
                {
                    placeHolder[i,j]  = board[count];
                    ++count;
                }
            }
            return placeHolder;
        }
    }
}
