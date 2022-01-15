using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class Proxy : Subject
    {
        private Subject _subject;
        public override void DoSomeWork()
        {

            Console.WriteLine("Wecome, my Client.");

            if (this._subject == null)
            {
                this._subject = new ConcreteSubject();
            }

            this._subject.DoSomeWork();
        }
    }
}
