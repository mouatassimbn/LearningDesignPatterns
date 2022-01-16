using System;

namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Facade Pattern Demo***");
            //Demo1();
            Demo2();
        }

        static void Demo1()
        {
            // Without Facade pattern
            Console.WriteLine("Without facade pattern");
            RobotBody robotBody = new RobotBody("Milano");
            robotBody.MakeRobotBody();
            RobotColor robotColor = new RobotColor("green");
            robotColor.SetColor();
        }

        static void Demo2()
        {
            // Making a Milano robot with green color.
            RobotFacade facade = new RobotFacade("Milano", "green");
            facade.ConstructRobot();

            // Making a robonaut robot with default steel color.
            facade = new RobotFacade("Robonaut");
            facade.ConstructRobot();

            // Destroying one robot
            facade.DestroyRobot();

            // Destroying another robot
            facade.DestroyRobot();

            // this destruction attempt should fail.
            facade.DestroyRobot();
        }
    }
}
