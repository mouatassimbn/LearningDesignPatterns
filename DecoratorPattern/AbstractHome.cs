using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal abstract class AbstractHome
    {
        public double AdditionalPrice { get; set; }
        public abstract void MakeHome();
    }
}
