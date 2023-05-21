using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6._3
{
    internal class Rectangle
    {
        public double width;
        public double height;

        public Rectangle(double w, double h)
        {
            if (w <= 0 || h <= 0)
            {
                Console.WriteLine("Chieu dai va rong phai la so duong!");
            }
            width = w;
            height = h;
        }
        public string ToString()
        {
            return $"Chieu dai:{width}, Chieu rong:{height}";
        }
        public double GetPerimeter()
        {
            return 2 * (width + height);
        }
        public double GetArea()
        {
            return width * height;
        }
        public bool IsSameArea(Rectangle rect)
        {
            return this.GetArea() == rect.GetArea();
        }

    }
}
