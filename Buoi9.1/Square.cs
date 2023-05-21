using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi9._1
{
    internal class Square:Rectangle
    {
        public Square() { }
        public Square(double side) : base(side, side) { }
        public Square(double side, string color, bool filled) : base(side, side, color, filled) { }
        public double getSide()
        {
            return this.getWidth();
        }
        public void setSide(double side)
        {
            this.setLength(side);
            this.setWidth(side);
        }
        public override void setWidth(double side)
        {
            this.setSide(side);
        }
        public override void setLength(double side)
        {
            this.setSide(side);
        }
        public override string ToString()
        {
            return $"Square[{base.ToString()}]";
        }
    }
}
