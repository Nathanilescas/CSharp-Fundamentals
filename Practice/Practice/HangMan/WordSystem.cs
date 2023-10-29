

namespace Practice.Hangman
{
    internal class WordSystem
    {
        private static string WordGenerator()
        {
            Random random = new Random();
            string[] wordList = new string[]
            {
                "Immutable",
                "Welcome",
                "Imaginary",
                "Tiresome",
                "Spiritual",
                "Encourage",
                "Materialistic",
                "Boundary",
                "Lackadaisical",
                "Scientific"
            };

            int randomNumber = random.Next(wordList.Length);

            return wordList[randomNumber];
        }


        public static (char[], bool[]) GetWord()
        {
            int count = 0;
            string generatedWord = WordGenerator();
            char[] word = new char[generatedWord.Length];
            bool[] boolword = new bool[word.Length];

            foreach (char letter in generatedWord)
            {
                word[count] = letter;
                ++count;
            }

            return (word, boolword);

        }
    }
}
