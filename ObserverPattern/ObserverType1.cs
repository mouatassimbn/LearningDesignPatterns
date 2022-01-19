using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class ObserverType1 : IObserver
    {
        private string _name;

        public ObserverType1(string name)
        {
            this._name = name;
        }

        public void Update(ICelebrity celebrity)
        {
            Console.WriteLine($"{this._name} has received an alert from {celebrity.Name}. Updated value is: {celebrity.Flag}");
        }
    }
}
