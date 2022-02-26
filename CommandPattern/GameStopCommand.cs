using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class GameStopCommand : ICommand
    {
        private Game _game;
        public GameStopCommand(Game game)
        {
            this._game = game;
        }

        public void Execute()
        {
            this._game.Finnish();
        }

        public void Undo()
        {
            Console.WriteLine("Undoing stop command.");
            this._game.Start();
            this._game.DisplayScore();
        }
    }
}
