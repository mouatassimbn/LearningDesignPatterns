using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal abstract class ElectronicGoods
    {
        protected IPrice _price;
        protected string _type;
        protected double _cost;

        public IPrice Price
        {
            get => this._price;
            set => this._price = value;
        }

        public string Type
        {
            get => this._type;
            set => this._type = value;
        }

        public ElectronicGoods(IPrice price)
        {
            this._price = price;
        }

        public void Details()
        {
            this._price.DisplayDetails(this._type, this._cost);
        }

        public void Discount(int percentage)
        {
            this._price.GetDiscount(percentage);
        }
    }
}
