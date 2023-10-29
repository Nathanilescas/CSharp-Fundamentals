using System;


namespace Practice
{
    internal class BoardGenerator
    {
        private int[] startingNumbers = new int[15];
        private int[] board = new int[16];




        public int[] Board()
        {
            for (int i = 0; i < this.startingNumbers.Length; i++)
            {
                startingNumbers[i] = i + 1;
            }

            board = RandomSpot(startingNumbers);
            return board;

        }

        private int[] RandomSpot(int[] array)
        {
            Random random = new Random();
            int[] placeHolder = new int[array.Length + 1];

            foreach (int value in array)
            {
                int randomSpot = random.Next(0, (array.Length + 1));

                while (true) // Repeat until it finds a spot with a zero
                {
                    if (placeHolder[randomSpot] == 0)
                    {
                        placeHolder[randomSpot] = value;
                        break;
                    }
                    else { randomSpot = random.Next(1, (array.Length)); }

                }
            }
            return placeHolder;
        }

    }
}
