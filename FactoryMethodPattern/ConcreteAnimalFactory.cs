using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    internal class ConcreteAnimalFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal(string animalType)
        {
            if (animalType.Contains("dog"))
            {
                return new Dog();
            }
            else if (animalType.Contains("tiger"))
            {
                return new Tiger();
            }
            else
            {
                throw new ArgumentException("You need to pass either a dog or a tiger as an argument.");
            }
        }
    }
}
