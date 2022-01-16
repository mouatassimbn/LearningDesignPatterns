using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    internal class VehicleFactory
    {

        private static readonly VehicleFactory _instance;
        private Dictionary<string, IVehicle> _vehicles;


        static VehicleFactory()
        {
            _instance = new VehicleFactory();
        }

        private VehicleFactory()
        {
            // Drawback is it creates all objects even if not needed (Usless memory occupation)...
            this._vehicles = new()
            {
                { "car", new Car("One car is created") },
                { "bus", new Bus("One bus is created") },
                { "future", new FutureVehicle("Vehicule 2050 is created") }
            };

        }

        public static VehicleFactory GetInstance
        {
            get
            {
                return _instance;
            }
        }


        public int TotalObjectsCreated
        {
            get { return _vehicles.Count; }
        }

        public IVehicle GetVehicleFromVehicleFactory(string vehicleType)
        {
            IVehicle vehicleCategory = null;
            if (this._vehicles.ContainsKey(vehicleType.ToLower()))
            {
                vehicleCategory = this._vehicles[vehicleType.ToLower()];
            }
            else
            {
                throw new ArgumentException("Currently, the vehicle factory can have cars and buses only.");
            }

            return vehicleCategory;
        }
    }
}
