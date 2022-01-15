using System;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Prototype Pattern Demo***");
            Demo3();
        }

        static void Demo1()
        {
            BaseCar nano = new Nano("Green Nano");
            BaseCar ford = new Ford("Ford Yellow");
            BaseCar baseCar;

            // Nano
            baseCar = nano.Clone();
            // Working on cloned copu
            baseCar.onRoadPrice = baseCar.basePrice + BaseCar.setAdditionalPrice();
            Console.WriteLine("Car is : {0}, and it's price is ${1}", baseCar.ModelName, baseCar.onRoadPrice);

            // Ford
            baseCar = ford.Clone();
            baseCar.onRoadPrice = baseCar.basePrice + BaseCar.setAdditionalPrice();
            Console.WriteLine("Car is : {0}, and it's price is ${1}", baseCar.ModelName, baseCar.onRoadPrice);
        }

        static void Demo2()
        {
            EmpAddress initialAddress = new("21, abc Roed, USA");
            Employee emp = new(1, "John", initialAddress);
            Console.WriteLine("The original object is empl which is as follows:");
            Console.WriteLine(emp);

            Console.WriteLine("Making a clone of emp1 now.");
            Employee empClone = emp.Clone() as Employee;
            Console.WriteLine("EmpClone object is as follows:");
            Console.WriteLine(empClone);

            Console.WriteLine("Now changing the name, id and address of the cloned object ");
            empClone.Id = 10;
            empClone.Name = "Sam";
            empClone.Address.Address = "221, xyz Road, Canada";

            Console.WriteLine("Now emp1 object is as follows:");
            Console.WriteLine(emp);
            Console.WriteLine("And emp1Clone object is as follows:");
            Console.WriteLine(empClone);
        }

        static void Demo3()
        {

        }
    }
}
