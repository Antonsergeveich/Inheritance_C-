using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AbstractGeometry
{
    internal class EquilateralTriangle : Triangle
    {
        double side;
        public double Side
        {
            get => side;
            set => side = 
                value < MIN_SIZE ? MIN_SIZE :
                value > MAX_SIZE ? MAX_SIZE :
                value;
        }
        public EquilateralTriangle(double side, int start_x, int start_y, int line_width, Color color) :
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
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth); // Создаём карандаш которым будем рисовать фигуру
            Point[] points = new Point[]
            {
                new Point(StartX, StartY + (int)Side),
                new Point(StartX + (int)Side, StartY + (int)Side),
                new Point(StartX + (int)Side/2, StartY + (int)Side - (int)GetHeight())
            };
            e.Graphics.DrawPolygon(pen, points);
            DrawHeight(e);
        }
        public override void DrawHeight(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, 1);
            e.Graphics.DrawLine(pen, StartX + (float)Side / 2, StartY + (float)Side, StartX + (float)Side / 2, (float)(StartY + Side - GetHeight()));
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine(this.GetType());
            Console.WriteLine($"Длина стороны: {Side}");
            base.Info(e);
        }
    }
}
