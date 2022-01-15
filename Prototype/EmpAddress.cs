using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class EmpAddress
    {
        public string Address { get; set; }

        public EmpAddress(string address)
        {
            this.Address = address;
        }

        public override string ToString()
        {
            return this.Address;
        }

        public object CloneAddress()
        {
            return this.MemberwiseClone();
        }
    }
}
