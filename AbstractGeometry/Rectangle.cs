using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AbstractGeometry
{
    internal class Rectangle : Shape
    {
        double width;
        double height;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public Rectangle
            (
            uint start_x, uint start_y, uint line_width, Color color
            ) : base(start_x, start_y, line_width, color)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
        public override double GetPerimeter()
        {
            return (Width + Height) * 2;
        }
    }
}
