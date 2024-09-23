using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
    internal class Circle:Shape
    {
        double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle(double radius, uint start_x, uint start_y, uint line_width, Color color)
            : base(start_x, start_y, line_width, color)
        {
            Radius = radius;
        }
        public double GetDiameter()
        {
            return radius * 2;
        }
        public override double GetArea()
        {
            return  Math.PI * radius * radius;
        }
        public override double GetPerimeter()
        {
            return Math.PI * GetDiameter();
        }
    }
}
