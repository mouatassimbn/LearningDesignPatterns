using System;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Command Pattern Demonstration ****");
            RemoteControl invoker = new();

            Game game = new("Golf");
            GameStartCommand startCommand = new(game);
            GameStopCommand stopCommand = new(game);

            Console.WriteLine("** Starting the game and performing an undo **");
            invoker.SetCommand(startCommand);
            invoker.ExecuteCommand();

            Console.WriteLine("Undoing the previous command");
            invoker.UndoCommand();

            Console.WriteLine("** Starting the game again. Then stopping it and undoing the stop operation **");
            invoker.SetCommand(stopCommand);
            invoker.ExecuteCommand();

            Console.WriteLine("Undoing the previous command now.");
            invoker.UndoCommand();

        }
    }
}
