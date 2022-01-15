using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal static class FactoryProvider
    {
        public static IAnimalFactory GetAnimalFactory(string type)
        {
            switch (type.ToLower())
            {
                case "wild":
                    return new WildAnimalFactory();
                case "pet":
                    return new PetAnimalFactory();
                default:
                    throw new ArgumentException("You need to pass either wild or pet as argument.");
            }
        }
    }
}
