using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal interface IVisitor
    {
        void VisitNumbers(SmallNumber number);
        void VisitNumbers(BigNumber number);
    }
}
