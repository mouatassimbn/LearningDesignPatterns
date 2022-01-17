using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class ShowroomPrice : IPrice
    {
        public void DisplayDetails(string productType, double price)
        {
            Console.WriteLine($"{productType} price at showroom is : {price + 300}$");
        }

        public void GetDiscount(int percentage)
        {
            Console.WriteLine($"At showroom, additional {percentage}% discount can be approved.");
        }
    }
}
