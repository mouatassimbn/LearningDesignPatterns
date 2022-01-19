using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorCompositePatterns
{
    internal interface IVisitor
    {
        void VisitEmployees(Employee employee);
        void VisitEmployees(CompositeEmployee employee);
    }
}
