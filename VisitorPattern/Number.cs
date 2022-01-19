using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal abstract class Number
    {
        private int _numberValue;
        private string _type;

        public Number(string type, int number)
        {
            this._type = type;
            this._numberValue = number;
        }

        public int NumberValue
        {
            get => this._numberValue;
        }

        public string TypeInfo
        {
            get => this._type;
        }

        public abstract void Accept(IVisitor visitor);
    }
}
