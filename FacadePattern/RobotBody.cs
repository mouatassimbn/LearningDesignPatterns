using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class RobotBody
    {
        private string _robotType;
        private static int _count = 0;

        public RobotBody(string robotType)
        {
            this._robotType = robotType;
        }

        public void MakeRobotBody()
        {
            Console.WriteLine($"Constructing one {this._robotType} robot.");
            Console.WriteLine("Robot creation finished.");
            Console.WriteLine($"Total number of robot created at this moment={++RobotBody._count}");
        }

        public void DestroyRobotBody()
        {
            if (RobotBody._count > 0)
            {
                --RobotBody._count;
                Console.WriteLine("Robot's destruction process is over.");
            }
            else
            {
                Console.WriteLine("All robots are destroyed.");
                Console.WriteLine("Color removal operation will no continue.");
            }
        }
    }
}
