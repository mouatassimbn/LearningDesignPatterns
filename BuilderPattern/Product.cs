using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Product
    {
        private List<string> _parts;

        public Product()
        {
            _parts = new();
        }

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Product completed as below:");
            foreach (string part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
