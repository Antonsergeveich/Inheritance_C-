using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    //Равнобедренный треугольник — это треугольник, у которого равны две стороны.
    internal class IsoscelesTriangle : Triangle 
    {
        double footing; //основание
        double side;    //сторона
        public double Side
        {
            get => side;
            set => side =
                value < MIN_SIZE ? MIN_SIZE :
                value > MAX_SIZE ? MAX_SIZE :
                value;
        }
        public double Footing
        {
            get => footing;
            set => footing =
                value < MIN_SIZE ? MIN_SIZE :
                value > MAX_SIZE ? MAX_SIZE :
                value;
        }
        public IsoscelesTriangle(double footing, double side, int start_x, int start_y, int line_width, Color color) :
        base(start_x, start_y, line_width, color)
        {
            Footing = footing;
            Side = side;
        }
        public override double GetHeight()
        {
            return Math.Sqrt(Math.Pow(side, 2) - Math.Pow(footing/2, 2));
        }
        public override double GetArea()
        {
            return footing * side / 2;
        }
        public override double GetPerimeter()
        {
            return side * 2 + footing;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth); // Создаём карандаш которым будем рисовать фигуру
            Point[] points = new Point[]
            {
                new Point(StartX, StartY + (int)GetHeight()),
                new Point(StartX + (int)footing, StartY + (int)GetHeight()),
                new Point(StartX + (int)footing/2, StartY)
            };
            e.Graphics.DrawPolygon(pen, points);
            DrawHeight(e);
        }
        public override void DrawHeight(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, 1);
            e.Graphics.DrawLine(pen, StartX + (float)Footing / 2, StartY + (float)GetHeight(), StartX + (float)Footing / 2, (float)StartY);
        }
    }
}
