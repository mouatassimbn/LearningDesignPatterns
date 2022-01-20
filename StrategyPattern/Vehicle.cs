using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Vehicle
    {
        private VehicleBehavior _vehicleBehavior;
        private string _vehicleType;

        public Vehicle(string vehicleType)
        {
            this._vehicleType = vehicleType;
            this._vehicleBehavior = new InitialBehavior();
        }

        public void SetVehicleBehavior(VehicleBehavior behavior)
        {
            this._vehicleBehavior = behavior;
        }

        public void DisplayAboutMe()
        {
            this._vehicleBehavior.AboutMe(this._vehicleType);
        }
    }
}
