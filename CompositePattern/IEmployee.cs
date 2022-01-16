using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal interface IEmployee
    {
        string Name { get; set; }
        string Dept { get; set; }
        string Designation { get; set; }
        void DisplayDetails();
    }
}
