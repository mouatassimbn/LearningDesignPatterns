using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal interface IPrice
    {
        void DisplayDetails(string product, double price);
        void GetDiscount(int percentage);
    }
}
