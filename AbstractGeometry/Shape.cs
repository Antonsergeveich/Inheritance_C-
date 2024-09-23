using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AbstractGeometry
{
    abstract class Shape //Форма
    {
        uint start_x;
        uint start_y;
        uint line_width;
        public Color Color { get; set; }
        public uint StartX
        {
            get { return start_x; }
            set { start_x = value; }
        }
        public uint StartY
        {
            get { return start_y; }
            set { start_y = value; }
        }
        public uint LineWidth
        {
            get { return line_width; }
            set { line_width = value; }
        }
        public Shape(uint start_x, uint start_y, uint line_width, Color color)
        {
            StartX = start_x;
            StartY = start_y;
            LineWidth = line_width;
            Color = color;
        }
        public abstract double GetArea();
        public abstract double GetPerimeter();


    }
}
