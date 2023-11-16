using TheFountainOfObjects.TheFountainOfObjects.GameCommands.MovementCommands;
using TheFountainOfObjects.TheFountainOfObjects;

namespace TheFountainOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            GridSystem grid = GridSystem.Instance;
            GameRules rules = new GameRules();

            CommandCall commands = new CommandCall();
            commands.Grid = grid;
            commands.Player = player;
            commands.Rules = rules;

            
            Console.WriteLine(commands.Grid[0, 2]);
            Console.WriteLine()


            /*while (true)
            {
                Console.WriteLine("Where do you want to move?");
                string input = Console.ReadLine();
                commands.CallMovementCommand(input);     
                Console.WriteLine($"({player.LocationRow},{player.LocationColumn})");
                commands.RoomCommand();
            }*/







        }
    }
}