using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class OnlinePrice : IPrice
    {
        public void DisplayDetails(string productType, double price)
        {
            Console.WriteLine($"{productType} price at online is : {price}$");
        }

        public void GetDiscount(int percentage)
        {
            Console.WriteLine($"At online, you can get upto {percentage}% discount.");
        }
    }
}
