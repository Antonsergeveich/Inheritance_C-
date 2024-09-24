using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace AbstractGeometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1)Инициализируем графику в консоле:
            IntPtr hwnd = GetConsoleWindow();
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
            (
                Console.WindowLeft, Console.WindowTop,
                Console.WindowWidth, Console.WindowHeight
            );
            PaintEventArgs e = new PaintEventArgs(graphics, window_rect); 
            //2) Только теперь можно создавать фигуры:
            Rectangle rectangle = new Rectangle(80, 50, 400, 100, 2, Color.AliceBlue);
            rectangle.Info(e);

            Square square = new Square(75, 500, 50, 3, Color.Red);
            square.Info(e);

            Circle circle = new Circle(80, 750, 50, 1, Color.Yellow);
            circle.Info(e);

            EquilateralTriangle triangle = new EquilateralTriangle(100, 600, 30, 3, Color.White);
            triangle.Info(e);
        }
        //https://learn.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.dllimportattribute?view=net-8.0
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
    }
}
