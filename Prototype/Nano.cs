using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Nano : BaseCar
    {
        public Nano(string m)
        {
            ModelName = m;
            basePrice = 100000;
        }

        public override BaseCar Clone()
        {
            return this.MemberwiseClone() as Nano;
        }
    }
}
