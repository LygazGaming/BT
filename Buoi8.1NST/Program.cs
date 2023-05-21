using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi8._1NST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caculator myCal = new Caculator();
            Console.WriteLine($"4+5={myCal.Add(4, 5)}");
            Console.WriteLine($"3.5+7.6={myCal.Add(3.5, 7.6)}");
            Console.WriteLine($"7-5={myCal.Subtract(7, 5)}");
            Console.WriteLine($"17.3-5.1={myCal.Subtract(17.3, 5.1)}");
            Console.WriteLine($"6*5={myCal.Multiply(6, 5)}");
            Console.WriteLine($"3.5*5.5={myCal.Multiply(3.5, 5.5)}");
            Console.WriteLine($"10/5={myCal.Divide(10, 5)}");
            Console.WriteLine($"23.5/4.5={myCal.Divide(23.5, 4.5)}");
            Console.WriteLine($"Min(5,2)={myCal.Min(5, 2)}");
            Console.WriteLine($"Min(4,7,3)={myCal.Min(4, 7, 3)}");
            Console.WriteLine($"Min(6.2,2.3,4.6)={myCal.Min(6.2, 2.3, 4.6)}");
            Console.WriteLine($"Max(5,2)={myCal.Max(5, 2)}");
            Console.WriteLine($"Max(4,7,3)={myCal.Max(4, 7, 3)}");
            Console.WriteLine($"Max(6.2,2.3,4.6)={myCal.Max(6.2, 2.3, 4.6)}");
        }
    }
}
