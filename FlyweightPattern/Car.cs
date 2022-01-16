using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    internal class Car : IVehicle
    {
        private string _description;

        public Car(string description)
        {
            this._description = description;
        }

        public void AboutMe(string color)
        {
            Console.WriteLine($"{this._description} with {color} color.");
        }
    }
}
