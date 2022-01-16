using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    internal class Bus : IVehicle
    {
        private string _description;

        public Bus(string description)
        {
            this._description = description;
        }

        public void AboutMe(string color)
        {
            Console.WriteLine($"{this._description} with {color} color.");
        }
    }
}
