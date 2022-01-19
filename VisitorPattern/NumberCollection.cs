using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class NumberCollection
    {
        List<Number> _numbers;

        public NumberCollection()
        {
            this._numbers = new List<Number> {
                new SmallNumber("small-1", 10),
                new SmallNumber("small-2", 20),
                new SmallNumber("small-3", 30),
                new BigNumber("big-1", 200),
                new BigNumber("big-2", 150),
                new BigNumber("big-3", 70)
            };
        }

        public void AddNumberToList(Number number)
        {
            this._numbers.Add(number);
        }

        public void RemoveNumberFromList(Number number)
        {
            this._numbers.Remove(number);
        }

        public void DisplayList()
        {
            Console.WriteLine("Current list is as follows:");
            foreach (Number number in this._numbers)
            {
                Console.Write($"{number.NumberValue}\t");
            }
            Console.WriteLine();
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Number number in this._numbers)
            {
                number.Accept(visitor);
            }
        }
    }
}
