using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
    internal class EquilateralTriangle : Triangle
    {
        double side;
        public double Side
        {
            get { return side; }
            set { side = value; }
        }
        public EquilateralTriangle(double side, uint start_x, uint start_y, uint line_width, Color color) :
        base(start_x, start_y, line_width, color)
        {
            Side = side;
        }
        public override double GetHeight()
        {
            return Math.Sqrt(side * side - side / 2 * side / 2);
        }
        public override double GetArea()
        {
            return side / 2 * GetHeight();
        }
        public override double GetPerimeter()
        {
            return side * 3;
        }
    }
}
