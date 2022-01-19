using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class ObserverType2 : IObserver
    {
        private string _name;

        public ObserverType2(string name)
        {
            this._name = name;
        }

        public void Update(ICelebrity celebrity)
        {
            Console.WriteLine($"{this._name} notified. Inside {celebrity.Name}, the updated value is: {celebrity.Flag}");
        }
    }
}
