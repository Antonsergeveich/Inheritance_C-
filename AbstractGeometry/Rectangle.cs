using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AbstractGeometry
{
    internal class Rectangle : Shape
    {
        static readonly int MIN_SIDE = 20;
        static readonly int MAX_SIDE = 220;
        double width;
        double height;

        public double Width
        {
            get => width;
            set => width = 
                value < MIN_SIDE? MIN_SIDE:
                value > MAX_SIDE? MAX_SIDE:
                value;
        }
        public double Height
        {
            get => height;
            set => height = 
                value < MIN_SIDE? MIN_SIDE:
                value > MAX_SIDE? MAX_SIDE:
                value;
        }
        //              Constructors:
        public Rectangle
            (
            double width, double height, int start_x, int start_y, int line_width, Color color
            ) : base(start_x, start_y, line_width, color)
        {
            Width = width;
            Height = height;
        }
        public override double GetArea() => Width * Height;
        public override double GetPerimeter() => (Height + Width) * 2;    
        public override void Draw(PaintEventArgs e)
        {
            //Console.WriteLine("Здесь должен быть рисунок прямоугольника");
            Pen pen = new Pen(Color, LineWidth); // Создаём карандаш которым будем рисовать фигуру
            e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Width, (float)Height);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine(this.GetType()+":");
            Console.WriteLine($"Ширина: {Width}");
            Console.WriteLine($"Высота: {Height}");
            base.Info(e);
        }
    }
}
