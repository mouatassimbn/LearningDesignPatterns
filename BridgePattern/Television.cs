using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class Television : ElectronicGoods
    {
        public Television(IPrice price) : base(price)
        {
            this._type = "Television";
            this._cost = 2000;
        }
    }
}
