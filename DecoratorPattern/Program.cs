using System;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Decorator Pattern Demo***");

            // Scenario 1
            Console.WriteLine("Scenario 1: Building home, Adding floor and the painting it.");

            AbstractHome home = new ConcreteHome();
            Console.WriteLine("Current bill breakups are as follows:");
            home.MakeHome();

            // Applying a decorator
            // Adding a floor
            home = new FloorDecorator(home);
            Console.WriteLine("Floor added. Current bill breakups are as follows:");
            home.MakeHome();

            // Working on top of the previous decorator
            // Painting the home
            home = new PaintDecorator(home);
            Console.WriteLine("Paint applied. Current bill breakups are as follows:");
            home.MakeHome();

            // Scenario 2
            Console.WriteLine("Scenario 2: Building home, painting it and the adding two additional floors on top of it.");
            home = new ConcreteHome();
            Console.WriteLine("Going back to original home. Current bill breakups are as follows:");
            home.MakeHome();

            // Applying paint on original home.
            home = new PaintDecorator(home);
            Console.WriteLine("Paint applied. Current bill breakups are as follows:");
            home.MakeHome();

            // Adding a floow on the painted home.
            home = new FloorDecorator(home);
            Console.WriteLine("Floor added. Current bil breakups are as follows:");
            home.MakeHome();

            // Adding another floor on the current home.
            home = new FloorDecorator(home);
            Console.WriteLine("Floor added. Current bill breakups are as follows:");
            home.MakeHome();

        }
    }
}
