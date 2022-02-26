using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class GameStartCommand : ICommand
    {
        private Game _game;
        public GameStartCommand(Game game)
        {
                this._game = game;
        }

        public void Execute()
        {
            this._game.Start();
            this._game.DisplayScore();
        }

        public void Undo()
        {
            Console.WriteLine("Undoing start command.");
            this._game.Finnish();
        }
    }
}
