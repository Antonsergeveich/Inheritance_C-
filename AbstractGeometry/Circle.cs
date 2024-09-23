using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AbstractGeometry
{
    internal class Circle:Shape
    {
        double radius;
        public double Radius
        {
            get => radius;
            set => radius = 
                value < MIN_SIZE ? MIN_SIZE:
                value > MAX_SIZE ? MAX_SIZE:
                value;
            //get { return radius; }
            //set { radius = value; }
        }
        public Circle(double radius, int start_x, int start_y, int line_width, Color color)
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
