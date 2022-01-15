using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class PetDog : IDog
    {
        public void AboutMe()
        {
            Console.WriteLine("Pet dog says: Bow-Wow. I prefer to stay at home.");
        }
    }
}
