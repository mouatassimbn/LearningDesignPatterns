using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class PaintDecorator : AbstractDecorator
    {
        public PaintDecorator(AbstractHome home) : base(home)
        {
            this.AdditionalPrice = 5000;
        }

        public override void MakeHome()
        {
            base.MakeHome();
            AddPaint();
        }

        private void AddPaint()
        {
            Console.WriteLine($"--Painting done. Pay additional ${this.AdditionalPrice} for it.");
        }
    }
}
