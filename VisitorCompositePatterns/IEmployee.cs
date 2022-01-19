using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorCompositePatterns
{
    internal interface IEmployee
    {
        string Name { get; set; }
        string Dept { get; set; }
        string Designation { get; set; }
        double Experience { get; set; }

        void DisplayDetails();
        void Accept(IVisitor visitor);
    }
}
