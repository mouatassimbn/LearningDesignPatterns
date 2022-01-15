using System;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Abstract Factory Pattern Demo.***");

            IAnimalFactory animalFactory;

            // Making Wild Animal
            animalFactory = FactoryProvider.GetAnimalFactory("wild");
            IDog wildDog = animalFactory.GetDog();
            ITiger wildTiger = animalFactory.GetTiger();
            wildDog.AboutMe();
            wildTiger.AboutMe();

            Console.WriteLine("*******************");

            // Making Pet Animal
            animalFactory = FactoryProvider.GetAnimalFactory("pet");
            IDog petDog = animalFactory.GetDog();
            ITiger petTiger = animalFactory.GetTiger();
            petDog.AboutMe();
            petTiger.AboutMe();
        }
    }
}
