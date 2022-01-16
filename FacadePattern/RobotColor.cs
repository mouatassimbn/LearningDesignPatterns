using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class RobotColor
    {
        private string _color;

        public RobotColor(string color)
        {
            this._color = color;
        }

        public void SetColor()
        {
            if (this._color == "steel")
            {
                Console.WriteLine($"The default color {this._color} is set for the robot.");
            }
            else
            {
                Console.WriteLine($"Painting the robot with your favorite {this._color} color.");
            }
        }

        public void RemoveColor()
        {
            Console.WriteLine("Attempting to remove the colors from the robot.");
        }
    }
}
