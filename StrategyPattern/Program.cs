using System;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Strategy PAttern Demo***");
            Vehicle context = new Vehicle("Aeroplane");
            context.DisplayAboutMe();

            Console.WriteLine("Setting flying capability to vehicle.");
            context.SetVehicleBehavior(new FlyBehavior());
            context.DisplayAboutMe();

            Console.WriteLine("Changing the vehicle behavior again.");
            context.SetVehicleBehavior(new FloatBehavior());
            context.DisplayAboutMe();
        }
    }
}
