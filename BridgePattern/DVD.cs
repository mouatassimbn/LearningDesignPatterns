using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class DVD : ElectronicGoods
    {
        public DVD(IPrice price) : base(price)
        {
            this._type = "DVD";
            this._cost = 3000;
        }

        public void DoubleDiscount()
        {
            // Normal 10% discount 
            Discount(10);
            // Festive season additional 5% discount
            Discount(5);
        }
    }
}
