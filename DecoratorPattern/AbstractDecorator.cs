using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal abstract class AbstractDecorator : AbstractHome
    {
        protected AbstractHome _home;

        public AbstractDecorator(AbstractHome home)
        {
            this._home = home;
            this.AdditionalPrice = 0;
        }

        public override void MakeHome()
        {
            this._home.MakeHome();
        }
    }
}
