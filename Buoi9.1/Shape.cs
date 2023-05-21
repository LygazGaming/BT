using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi9._1
{
    internal abstract class Shape
    {
        protected string color;
        protected bool filled;
        public Shape() { }
        public Shape(string color ,bool filled)
        {
            this.color = color;
            this.filled = filled;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string color) { this.color = color; }
        public bool isFilled() { return this.filled; }
        public void setFilled(bool filled) { this.filled = filled; }
        public abstract double getArea();
        public abstract double getPerimeter();
        public override string ToString()
        {
            return $"Shape[color = {color}, filled = {filled}]";
        }
    }
}
