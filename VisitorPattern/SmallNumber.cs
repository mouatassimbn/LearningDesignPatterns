using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class SmallNumber : Number
    {
        public SmallNumber(string type, int number) : base(type, number) { }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitNumbers(this);
        }
    }
}
