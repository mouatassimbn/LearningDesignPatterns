using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Triangle : ITriangle
    {
        private double _baseLength;
        private double _height;

        public double BaseLength { get { return _baseLength; } }
        public double Height { get { return _height; } }

        public Triangle(double length, double height)
        {
            this._baseLength = length;
            this._height = height;
        }

        public double CalculateAreaOfTriangle()
        {
            return 0.5 * this._baseLength * this._height;
        }

        public void AboutTriangle()
        {
            Console.WriteLine("Actually, I am a Triangle.");
        }
    }
}
