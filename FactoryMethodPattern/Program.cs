using System;

namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Factory Pattern Demo.***");
            AnimalFactory animalFactory = new ConcreteAnimalFactory();
            IAnimal tiger = animalFactory.CreateAnimal("tiger");
            tiger.AboutMe();

            IAnimal dog = animalFactory.CreateAnimal("dog");
            dog.AboutMe();
        }
    }
}
