namespace Practice.OtherStuff
{
    internal class Door
    {
        private bool openDoor = false;
        private bool lockedDoor = true;
        private int passWord;

        public Door(int password)
        {
            passWord = password;
        }

        public void DoorTransition()
        {
            string input;
            while (true)
            {
                Console.WriteLine("The Door is currently " + (openDoor ? "Open" : "Closed") + " and " + (lockedDoor ? "Locked" : "Unlocz ked"));
                Console.Write("What do you want to do: ");
                input = Console.ReadLine();

                if (input == "Open" && !openDoor && !lockedDoor)
                {
                    Console.WriteLine("\nDoor is Open\n");
                    openDoor = true;
                }
                else if (input == "Close" && openDoor)
                {
                    Console.WriteLine("\nDoor is Closed\n");
                    openDoor = false;
                }
                else if (input == "Unlock" && !openDoor && lockedDoor)
                {
                    Console.Write("Enter Password: ");
                    int passWordInput = int.Parse(Console.ReadLine());
                    if (passWord == passWordInput)
                    {
                        lockedDoor = false;
                        Console.WriteLine("\nDoor is Unlocked\n");
                    }
                    else { Console.WriteLine("\nWrong Password\n"); }
                }
                else if (input == "Lock" && !openDoor && !lockedDoor)
                {
                    Console.Write("Set a Password: ");
                    passWord = int.Parse(Console.ReadLine());
                    lockedDoor = true;
                    Console.WriteLine("\n");
                }
                else { Console.WriteLine("\nTry again\n"); }
            }


        }
    }
}
