using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi9._1
{
    internal class Rectangle:Shape
    {
        protected double width;
        protected double length;
        public Rectangle()
        {
            this.width = 1.0;
            this.length = 1.0;
        }
        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {

        }
        public double getWidth()
        {
            return width;
        }
        public virtual void setWidth(double width)
        {
            this.width = width;
        }
        public double getLength()
        {
            return length;
        }
        public virtual void setLength(double length)
        {
            this.length = length;
        }
        public override double getArea()
        {
            return getWidth() * getLength();
        }
        public override double getPerimeter()
        {
            return (getWidth() + getLength()) * 2;
        }
        public override string ToString()
        {
            return $"Rectangle[{base.ToString()},width = {getWidth()},length = {getLength()}";
        }
    }
}
