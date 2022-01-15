using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class WildDog : IDog
    {
        public void AboutMe()
        {
            Console.WriteLine("Wild Dog says: I prefer to ream freely in jungles. Bow-Wow.");
        }
    }
}
