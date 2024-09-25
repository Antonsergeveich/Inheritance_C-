using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class VersatileTriangle : Triangle
    {
        double side_a;
        double side_b;
        double side_c;
        public double Side_A
        {
            get => side_a;
            set => side_a =
                value < MIN_SIZE ? MIN_SIZE :
                value > MAX_SIZE ? MAX_SIZE :
                value;
        }
        public double Side_B
        {
            get => side_b;
            set => side_b =
                value < MIN_SIZE ? MIN_SIZE :
                value > MAX_SIZE ? MAX_SIZE :
                value;
        }
        public double Side_C
        {
            get => side_c;
            set => side_c =
                value < MIN_SIZE ? MIN_SIZE :
                value > MAX_SIZE ? MAX_SIZE :
                value;
        }

        public VersatileTriangle(double side_a, double side_b, double side_c, int start_x, int start_y, int line_width, Color color) :
        base(start_x, start_y, line_width, color)
        {
            Side_A = side_a;
            Side_B = side_b;
            Side_C = side_c;
        }
        public override double GetPerimeter()
        {
            return side_a + side_b + side_c;
        }
        public double GetMaximal()
        {
            double maximal = Math.Max(Math.Max(side_a, side_b), side_c);
            return maximal;
        }
        public override double GetHeight()
        {
            
            return GetArea() * 2 / GetMaximal();
        }
        public override double GetArea()
        {
            return Math.Sqrt(GetPerimeter() / 2 * (GetPerimeter() / 2 - Side_A) * (GetPerimeter() / 2 - Side_B) * (GetPerimeter() / 2 - Side_C));
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth); 
            Point[] points = new Point[]
            {
                new Point(StartX, StartY + (int)GetHeight()),
                new Point(StartX + (int)side_a, StartY + (int)GetHeight()),
                new Point(StartX + (int)side_b/2, StartY)
            };
            e.Graphics.DrawPolygon(pen, points);
            DrawHeight(e);
        }
        public override void DrawHeight(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, 1);
            e.Graphics.DrawLine(pen, StartX + (float)GetMaximal()/ 2, StartY + (float)GetHeight(), StartX + (float)side_b / 2, (float)StartY);
        }
    }
}
