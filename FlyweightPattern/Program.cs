using System;
using System.Text;

namespace FlyweightPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Flyweight Pattern Demo.***");
            VehicleFactory vehiclefactory = VehicleFactory.GetInstance;
            IVehicle vehicle;
            /*
            * Now we are trying to get the 3 cars. Note that:we need not create
            additional cars if we have already created one of this category.
            */
            for (int i = 0; i < 3; i++)
            {
                vehicle = vehiclefactory.GetVehicleFromVehicleFactory("car");
                vehicle.AboutMe(GetRandomColor());
            }
            int numOfDistinctRobots = vehiclefactory.TotalObjectsCreated;
            Console.WriteLine($"Now, total numbers of distinct vehicle object(s) is = { numOfDistinctRobots}");
            /*
            Here we are trying to get the 5 more buses.Note that: we need
            not create additional buses if we have already created one of
            this category.
            */

            for (int i = 0; i < 5; i++)
            {
                vehicle = vehiclefactory.GetVehicleFromVehicleFactory("bus");
                vehicle.AboutMe(GetRandomColor());
            }
            numOfDistinctRobots = vehiclefactory.TotalObjectsCreated;
            Console.WriteLine($"Now, total numbers of distinct vehicle object(s) is = { numOfDistinctRobots}");
            /*
             Here we are trying to get the 2 future vehicles.Note that: we
             need not create additional future vehicle if we have already
             created one of this category.
             */
            for (int i = 0; i < 2; i++)
            {
                vehicle = vehiclefactory.GetVehicleFromVehicleFactory("future");
                vehicle.AboutMe(GetRandomColor());
            }
            numOfDistinctRobots = vehiclefactory.TotalObjectsCreated;
            Console.WriteLine($"Now, total numbers of distinct vehicle object(s) is = { numOfDistinctRobots}");
        }

        static string GetRandomColor()
        {
            Random r = new Random();
            int random = r.Next(100);
            if (random % 2 == 0)
            {
                return "red";
            }
            else
            {
                return "green";
            }
        }

        static void BuiltInFlyweightPattern()
        {
            string firstString = "a simple string";
            string secondString = new StringBuilder().Append("A").Append(" simple").Append(" string").ToString();
            string thirdString = String.Intern(secondString);

            // Different references.
            Console.WriteLine((Object)secondString == (Object)firstString);
            // Same reference
            Console.WriteLine((Object)thirdString == (Object)firstString);


        }
    }
}
