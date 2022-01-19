using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal interface ICelebrity
    {
        string Name { get; }
        int Flag { get; set; }

        void Register(IObserver observer);
        void Unregister(IObserver observer);
        void NotifyRegisteredUsers();
    }
}
