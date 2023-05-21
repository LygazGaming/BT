using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi9._1
{
    internal class Circle:Shape
    {
        protected double radius;
        public Circle()
        {
            this.radius = 1.0;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public override double getArea()
        {
            return Math.PI * Math.Pow(getRadius(), 2);
        }
        public override double getPerimeter()
        {
            return 2 * Math.PI * getRadius();
        }
        public override string ToString()
        {
            return $"Circle[{base.ToString()}, radius = {getRadius()}";
        }
    }
}
