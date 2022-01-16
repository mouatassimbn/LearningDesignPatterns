using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class RobotFacade
    {
        private RobotBody _robotBody;
        private RobotColor _robotColor;

        public RobotFacade(string robotType, string color = "steel")
        {
            this._robotBody = new RobotBody(robotType);
            this._robotColor = new RobotColor(color);
        }

        public void ConstructRobot()
        {
            Console.WriteLine("Robot creation through facade starts...");
            this._robotBody.MakeRobotBody();
            this._robotColor.SetColor();
        }

        public void DestroyRobot()
        {
            Console.WriteLine("Making an attempt to destroy one robot using the facade now.");
            this._robotColor.RemoveColor();
            this._robotBody.DestroyRobotBody();
        }
    }
}
