using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class InvestigateNumberVisitor : IVisitor
    {
        public void VisitNumbers(SmallNumber number)
        {
            Number currentNumber = number as Number;
            string isTrue = currentNumber.NumberValue > 10 ? "Yes" : "No";
            Console.WriteLine($"is {currentNumber.TypeInfo} greater than 10 ? {isTrue}");
        }

        public void VisitNumbers(BigNumber number)
        {
            Number currentNumber = number as Number;
            string isTrue = currentNumber.NumberValue > 100 ? "Yes" : "No";
            Console.WriteLine($"is {currentNumber.TypeInfo} greater than 100 ? {isTrue}");
        }
    }
}
