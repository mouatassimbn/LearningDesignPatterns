using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class IncrementNumberVisitor : IVisitor
    {
        public void VisitNumbers(BigNumber number)
        {
            Number currentNumber = number as Number;
            int temp = currentNumber.NumberValue;
            Console.WriteLine($"{currentNumber.TypeInfo} is {currentNumber.NumberValue}; I use it as:{++temp} for rest of my code.");
        }

        public void VisitNumbers(SmallNumber number)
        {
            Number currentNumber = number as Number;
            int temp = currentNumber.NumberValue;
            Console.WriteLine($"{currentNumber.TypeInfo} is {currentNumber.NumberValue}; I use it as:{temp + 10} for rest of my code.");
        }
    }
}
