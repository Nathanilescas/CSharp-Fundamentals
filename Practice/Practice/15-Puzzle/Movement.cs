

namespace Practice._15_Puzzle
{
    internal static class Movement
    {
        public static void MovementRules(int[,] currentGameBoard) // void for now
        {
            Console.Write("Where did you want to move:");
            int answer = int.Parse(Console.ReadLine());

            (int, int) coordinate = LocateNumber(currentGameBoard, answer);
            (int, int)[] possibleMovements = PossibleMovement(currentGameBoard);
            List<(int, int)> onlyPossibleMovements = RestrictionsOnPossibleMovement(possibleMovements);


            foreach((int, int)i in onlyPossibleMovements)
            {
                if (coordinate == i)
                {
                    SwapNumbers(currentGameBoard, answer);
                }
            }

        }

        private static List<(int, int)> RestrictionsOnPossibleMovement((int, int)[]possibleMovements)
        {
            List<(int, int)> newPossibleMovements = new List<(int, int)> ();

            foreach ((int, int) coordinates in possibleMovements)
            {
                (int X, int Y) = coordinates;

                if (X >= 0 && Y >= 0 && X <= 3 && Y <= 3)
                {
                    newPossibleMovements.Add(coordinates);
                }

            }

            return newPossibleMovements;
        }

        private static (int, int)[] PossibleMovement(int[,] gameBoard)
        {
            (int X, int Y) xLocation = LocateNumber(gameBoard, 0);
            (int, int)[] possibleMovements = new (int, int)[] { (xLocation.X, xLocation.Y - 1), (xLocation.X + 1, xLocation.Y), (xLocation.X, xLocation.Y + 1), (xLocation.X - 1, xLocation.Y) };
            return possibleMovements;
        }

        private static int[,] SwapNumbers(int[,] gameBoard, int num)
        {
            int placeHolder;
            (int X, int Y) placeMentOfswapNumber = LocateNumber(gameBoard, num);
            (int X, int Y) placeMentOfzero =  LocateNumber(gameBoard, 0);

            placeHolder = gameBoard[placeMentOfswapNumber.X, placeMentOfswapNumber.Y];

            gameBoard[placeMentOfswapNumber.X, placeMentOfswapNumber.Y] = 0;
            gameBoard[placeMentOfzero.X, placeMentOfzero.Y] = placeHolder;

            return gameBoard;
        }

        private static (int, int) LocateNumber(int[,] gameBoard, int numberToFind)
        {
            (int X, int Y) placementOfNumber = (0,0);

            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if (gameBoard[i,j] == numberToFind)
                    {
                        placementOfNumber = (i, j);
                    }
                }
            }
            return placementOfNumber;
        }
    }
}
