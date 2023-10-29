namespace Practice.OtherStuff
{
    internal class Door2
    {
        private DoorState currentState = DoorState.Closed;
        private bool openDoor = false;
        private bool lockedDoor = true;
        private int passWord;

        public Door2(int password)
        {
            passWord = password;
        }

        public void DoorTransitions()
        {
            while (true)
            {
                Console.Write($"The door is {currentState}.\n " +
                $"What do you want to do: ");
                string userInput = Console.ReadLine();

                currentState = userInput switch
                {
                    "Open" => OpenDoor(),
                    "Close" => CloseDoor(),
                    "Lock" => LockDoor()
                };
            }
        }

        DoorState OpenDoor()
        {
            if (!openDoor && !lockedDoor)
            {
                openDoor = true;
                return DoorState.Open;
            }
            else if (!openDoor && lockedDoor)
            {
                Console.Write("What is the password: ");
                int passWordAttempt = int.Parse(Console.ReadLine());
                if (passWordAttempt == passWord)
                {
                    lockedDoor = false;
                    openDoor = true;
                    GreenText("Door is Unlocked!!");
                    return DoorState.Open;
                }
                else
                {
                    RedText("Wrong PassWord");
                    return DoorState.Closed;
                }
            }
            else { return DoorState.Closed; }
        }

        DoorState CloseDoor()
        {
            openDoor = false;
            return DoorState.Closed;
        }

        DoorState LockDoor()
        {
            if (openDoor)
            {
                RedText("Need to close door first.");
                return DoorState.Open;
            }
            else
            {
                Console.Write("Set New PassWord: ");
                passWord = int.Parse(Console.ReadLine());
                lockedDoor = true;
                return DoorState.Locked;
            }
        }

        void GreenText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        void RedText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    enum DoorState
    {
        Open,
        Closed,
        Locked
    }
}
