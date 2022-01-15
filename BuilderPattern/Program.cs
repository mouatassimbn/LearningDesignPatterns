using System;

namespace BuilderPattern
{
    internal class Program
    {
        static Product customCar;
        static void Main(string[] args)
        {
            Console.WriteLine("***Builder Pattern Demo.***");
            customCar = new Car("Suzuki Swift")
                .StartUpOperations()
                .AddHeadLights(6)
                .BuildBody("Plastic")
                .EndOperations("Suzuki construction Completed.")
                .ConstructCar();

            customCar.Show();

            Product customCar2 = new Car("Sedan")
                .InsertWheels(7)
                .AddHeadLights(6)
                .StartUpOperations("Sedan creation in progress")
                .BuildBody()
                .EndOperations()
                .ConstructCar();

            customCar2.Show();
        }
    }
}
