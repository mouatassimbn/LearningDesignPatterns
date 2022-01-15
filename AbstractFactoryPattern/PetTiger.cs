using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class PetTiger : ITiger
    {
        public void AboutMe()
        {
            Console.WriteLine("Pet tiger says: Halum. I play in an animal circus.");
        }
    }
}
