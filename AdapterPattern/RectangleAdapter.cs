using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class RectangleAdapter : IRectangle
    {
        private ITriangle _triangle;

        public RectangleAdapter(ITriangle triangle)
        {
            this._triangle = triangle;
        }

        public void AboutMe()
        {
            this._triangle.AboutTriangle();
        }

        public double CalculateArea()
        {
            return this._triangle.CalculateAreaOfTriangle();
        }
    }
}
