using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Ford : BaseCar
    {
        public Ford(string m)
        {
            ModelName = m;
            basePrice = 500000;
        }

        public override BaseCar Clone()
        {
            return this.MemberwiseClone() as Ford;
        }
    }
}
