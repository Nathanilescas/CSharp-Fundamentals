

namespace Practice.Tic_Tac_Toe
{
    internal class CheckingSystem
    {
        /// <summary>
        /// Takes the user's input and checks if its within the 0 and 10
        /// </summary>
        /// <returns>user's int input</returns>
        public static int InputFromPlayer()
        {
            Console.Write("Choose a spot: ");
            while (true)
            {
                int response = int.Parse(Console.ReadLine());

                if (response > 0 && response < 10)
                {
                    return response;
                }
                else Console.Write("Choose a number between 1-9: ");
            }
        }

        /// <summary>
        /// It compares the int number to an Array of ints 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="numbers"></param>
        /// <returns>If the number matches any int inside the array then true else false</returns>
        public static bool DuplicateNumber(int number, int[] numbers)
        {
            foreach (int num in numbers)
            {
                if (number == num)
                {
                    return true;
                }
            }
            return false;
        }





        // Diagonal Checking System
        public static bool DCheckSystem(char[,] gameBoard, bool player)
        {
            int winningCount = 0;
            int winningCount2 = 0;
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[i, i] != null )
                {
                    if (gameBoard[i, i] == ((player) ? 'X' : 'O'))
                    {
                        ++winningCount;
                        if (winningCount > 2) { Console.WriteLine("DigonalCheckingSystem number1"); return true; }
                    }
                }


                if(gameBoard[i, (2 - i)] != null)
                {
                    if (gameBoard[i, (2 - i)] == ((player) ? 'X' : 'O'))
                    {
                        ++winningCount2;
                        if (winningCount2 > 2) { Console.WriteLine("DigonalCheckingSystem Number2"); return true; }
                    }
                }
            }
            return false;
        }


        // Vertical and Horizontial Checking System
        public static bool VHCheckSystem(char[,] gameBoard, bool player)
        {
            for (int i = 0; i < 3; i++)
            {
                int winningCount = 0;
                int winningCount2 = 0;

                for (int j = 0; j < 3; j++)
                {
                    if (gameBoard[j, i] != null || gameBoard[i, j] == ((player) ? 'X' : 'O'))
                    {
                        if (gameBoard[j, i] == ((player) ? 'X' : 'O'))
                        {
                            ++winningCount;
                            if (winningCount > 2) { Console.WriteLine("VHCheckingSystem"); return true; }
                        }

                        if(gameBoard[i, j] == ((player) ? 'X' : 'O'))
                        {
                            ++winningCount2;
                            if (winningCount2 > 2) { Console.WriteLine("VHCheckingSystem number2"); return true; }
                        }
                        
                    }
                    else { break; }
                }
            }
            return false;
        }
    }
}
