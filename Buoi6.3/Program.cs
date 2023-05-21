using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(3, 4);
            Console.WriteLine(rect1.ToString());
            double perimeter = rect1.GetPerimeter();
            Console.WriteLine("Chu vi:"+perimeter);
            double area = rect1.GetArea();
            Console.WriteLine("Dien tich:"+area);    
            Rectangle rect2 = new Rectangle(6, 2);
            Console.WriteLine(rect2.ToString());
            bool isSameArea = rect1.IsSameArea(rect2);
            if (isSameArea) 
            {
                Console.WriteLine("Hai dien tich bang nhau");
            }
            else Console.WriteLine("Hai dien tich khong bang nhau");

        }
    }
}
