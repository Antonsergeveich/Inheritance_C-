using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
    internal class Square:Rectangle
    {
        public Square
            (
            double width, uint start_x, uint start_y, uint line_width, Color color
            ) : base(
                start_x,
                start_y,
                line_width,
                color) { }
    }
}
