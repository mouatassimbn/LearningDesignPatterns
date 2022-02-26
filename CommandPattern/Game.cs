using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Game
    {
        private string _gameName;

        public Game(string name)
        {
            this._gameName = name;
        }

        public void Start() {
            Console.WriteLine($"{this._gameName} is on.");
        }

        public void DisplayScore() {
            Console.WriteLine($"The score is changing time to time.");
        }

        public void Finnish() {
            Console.WriteLine("---The game of {gameName} is over.---");
        }
    }
}
