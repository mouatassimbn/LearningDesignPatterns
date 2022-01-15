using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal abstract class BaseCar
    {
        public int basePrice = 0, onRoadPrice = 0;
        public string ModelName { get; set; }

        public static int setAdditionalPrice()
        {
            Random random = new Random();
            return random.Next(200000, 500000);
        }

        public abstract BaseCar Clone();

    }
}
