using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal interface IObserver
    {
        void Update(ICelebrity subject);
    }
}
