using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class WildTiger : ITiger
    {
        public void AboutMe()
        {
            Console.WriteLine("Wild tiger says: I prefer hunting in jungles. Halum.");
        }
    }
}
