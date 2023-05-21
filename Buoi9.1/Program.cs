using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle(2.5);
            Rectangle myRec = new Rectangle(3.0, 5.0);
            Square mySquare = new Square(10);
            Square anotherSquare = new Square(4.5, "green", false);
            Console.WriteLine(myCircle);
            Console.WriteLine(myCircle.getPerimeter());
            Console.WriteLine(myCircle.getArea());
            Console.WriteLine(myRec);
            Console.WriteLine(myRec.getPerimeter());
            Console.WriteLine(myRec.getArea());
            Console.WriteLine(mySquare);
            Console.WriteLine(mySquare.getPerimeter());
            Console.WriteLine(mySquare.getArea());
            Console.WriteLine(anotherSquare);
            Console.WriteLine(anotherSquare.getPerimeter());
            Console.WriteLine(anotherSquare.getArea());

        }
    }
}
