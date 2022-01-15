using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    internal abstract class AnimalFactory
    {
        public abstract IAnimal CreateAnimal(string animalType);
    }
}
