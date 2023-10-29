using Practice.Enum;


namespace Practice
{
    internal class RPSgame
    {
        private int scorePlayer1 = 0;
        private int scorePlayer2 = 0;

        public int ScorePlayer1 { get { return scorePlayer1; } }
        public int ScorePlayer2 { get { return scorePlayer2; } }

        public void RPSsystem(string Player1, string Player2)
        {


            RockPaperScissors Player1Choice = UserChoice(Player1);
            RockPaperScissors Player2Choice = UserChoice(Player2);



            // value for user1 
            switch (Player1Choice)
            {
                case RockPaperScissors.Rock: 
                    if (Player2Choice == RockPaperScissors.Paper)
                    {
                        ++scorePlayer2;
                    }
                    else if(Player2Choice == RockPaperScissors.Scissor)
                    {
                        ++scorePlayer1;
                    }
                    break;
                case RockPaperScissors.Paper:
                    if (Player2Choice == RockPaperScissors.Scissor)
                    {
                        ++scorePlayer2;
                    }
                    else if (Player2Choice == RockPaperScissors.Rock)
                    {
                        ++scorePlayer1;
                    }
                    break;
                case RockPaperScissors.Scissor:
                    if (Player2Choice == RockPaperScissors.Rock)
                    {
                        ++scorePlayer2;
                    }
                    else if (Player2Choice == RockPaperScissors.Paper)
                    {
                        ++scorePlayer1;
                    }
                    break;
            }

            Console.Write($"Player1: {scorePlayer1} || ");
            Console.WriteLine($"Player2: {scorePlayer2}");
        }


        private RockPaperScissors UserChoice(string UserChoice)
        {
            if ("Rock" == UserChoice)
            {
                return RockPaperScissors.Rock;
            }
            else if ("Paper" == UserChoice)
            {
                return RockPaperScissors.Paper;
            }
            else { return RockPaperScissors.Scissor; }
        }

        public void Play()
        {
            while (true)
            {
                Console.WriteLine("Player1");
                Console.Write("Rock, Paper or Scissor: ");
                string player1 = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Player2");
                Console.Write("Rock, Paper or Scissor: ");
                string player2 = Console.ReadLine();
                Console.Clear();

                RPSsystem(player1, player2);

                Console.WriteLine("Do you want to keep playing: Y/N");
                string answer = Console.ReadLine();
                if (answer.ToUpper() == "N") { break; }
            }

        }
    }
}
