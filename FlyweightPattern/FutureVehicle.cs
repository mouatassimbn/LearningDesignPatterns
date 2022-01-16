using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    internal class FutureVehicle : IVehicle
    {
        private string _description;

        public FutureVehicle(string description)
        {
            this._description = description;
        }

        public void AboutMe(string color)
        {
            _ = color;
            Console.WriteLine($"{this._description} with blue color.");
        }
    }
}
