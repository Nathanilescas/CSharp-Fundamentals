namespace Practice.OtherStuff
{
    internal class PassWordValidator
    {

        public static bool CheckPassWord(string password)
        {
            if (CheckLength(password, 6, 13) && CheckUpandLowerCase(password))
            {
                return true;
            }
            else { return false; }
        }

        private static bool CheckSpecificRequest(char input)
        {
            char specificRequest1 = 'T';
            char specificRequest2 = '&';

            if (input == specificRequest1 || input == specificRequest2)
            {
                return false;
            }
            else { return true; }
        }

        private static bool CheckUpandLowerCase(string word)
        {
            bool oneUpper = false;
            bool oneLower = false;

            // Special Check
            bool SpecialCheck = true;


            foreach (char letter in word)
            {
                // Special Check
                if (!CheckSpecificRequest(letter))
                {
                    SpecialCheck = false;
                }

                if (char.IsUpper(letter))
                {
                    oneUpper = true;
                }
                else if (char.IsLower(letter))
                {
                    oneLower = true;
                }
            }

            if (oneUpper && oneLower && SpecialCheck)
            {
                return true;
            }
            else { return false; }
        }
        private static bool CheckLength(string userInput, int min, int max)
        {
            if (userInput.Length >= min && userInput.Length <= max)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"Must be at least {min} characters long and no more than {max}. ");
                return false;
            }
        }
    }
}
