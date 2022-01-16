using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Rectangle : IRectangle
    {
        private double _length;
        private double _width;

        public double Length { get { return _length; } }
        public double Width { get { return _width; } }

        public Rectangle(double length, double width)
        {
            this._width = width;
            this._length = length;
        }

        public double CalculateArea()
        {
            return this._width * this._length;
        }

        public void AboutMe()
        {
            Console.WriteLine("Actually, I am a Rectangle.");
        }

    }
}
