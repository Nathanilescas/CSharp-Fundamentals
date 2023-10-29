using Practice.OtherStuff.Enum;

namespace Practice.OtherStuff
{
    internal class Card
    {
        public Rank Rank { get; set; }
        public Color Color { get; set; }

        public static Card[] DeckGenerator()
        {
            Card[] Deck = new Card[56];
            int cardCount = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    Deck[cardCount] = new Card();
                    Deck[cardCount].Color = (Color)i;
                    Deck[cardCount].Rank = (Rank)j;

                    ++cardCount;
                }
            }

            return Deck;
        }
    }
}
