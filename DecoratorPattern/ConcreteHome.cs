using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class ConcreteHome : AbstractHome
    {
        public ConcreteHome()
        {
            this.AdditionalPrice = 0;
        }

        public override void MakeHome()
        {
            Console.WriteLine("Original House is constructed. Price for this $10000");
        }
    }
}
