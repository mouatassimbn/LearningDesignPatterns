using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Celebrity : ICelebrity
    {
        private List<IObserver> _observers;
        private int _flag;
        private string _name;

        public List<IObserver> Observers
        {
            get => this._observers;
        }
        public int Flag
        {
            get => this._flag;
            set
            {
                this._flag = value;
                NotifyRegisteredUsers();
            }
        }
        public string Name
        {
            get => this._name;
        }

        public Celebrity(string name)
        {
            this._observers = new List<IObserver>();
            this._name = name;
        }

        public void Register(IObserver observer)
        {
            this._observers.Add(observer);
        }
        public void Unregister(IObserver observer)
        {
            this._observers.Remove(observer);
        }
        public void NotifyRegisteredUsers()
        {
            foreach (IObserver observer in this._observers)
            {
                observer.Update(this);
            }
        }
    }
}
