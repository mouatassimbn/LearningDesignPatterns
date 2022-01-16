using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class FloorDecorator : AbstractDecorator
    {
        public FloorDecorator(AbstractHome home) : base(home)
        {
            this.AdditionalPrice = 2500;
        }

        public override void MakeHome()
        {
            base.MakeHome();
            AddFloor();
        }

        private void AddFloor()
        {
            Console.WriteLine($"-Additional floor added. Pay additional {this.AdditionalPrice}$ for it.");
        }
    }
}
