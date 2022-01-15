using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Car : IBuilder
    {
        private string _brandName;
        private Product _product;

        public Car(string brand)
        {
            this._product = new();
            this._brandName = brand;
        }

        public IBuilder AddHeadLights(int optionalNoOfHeadlights = 2)
        {
            this._product.Add($"Headlights: {optionalNoOfHeadlights.ToString()}");
            return this;
        }

        public IBuilder BuildBody(string optionalBodyType = "Steel")
        {
            this._product.Add($"Body type: {optionalBodyType}");
            return this;
        }

        public Product ConstructCar()
        {
            return this._product;
        }

        public IBuilder EndOperations(string optionalEndMessage = "Card construction is complete.")
        {
            this._product.Add(optionalEndMessage);
            return this;
        }

        public IBuilder InsertWheels(int optionalNoOfWheels = 4)
        {
            this._product.Add($"Wheels: {optionalNoOfWheels.ToString()}");
            return this;
        }

        public IBuilder StartUpOperations(string optionalStartUpMessage = "Making a car for you.")
        {
            this._product.Add(optionalStartUpMessage);
            this._product.Add($"Car model name: {this._brandName}");
            return this;
        }
    }
}
