using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal sealed class Singleton
    {
        private Singleton() { }

        private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new());

        public static Singleton Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
