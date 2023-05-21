using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi8._1ST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"4+5={Caculator.Add(4, 5)}");
            Console.WriteLine($"3.5+7.6={Caculator.Add(3.5, 7.6)}");
            Console.WriteLine($"7-5={Caculator.Subtract(7, 5)}");
            Console.WriteLine($"17.3-5.1={Caculator.Subtract(17.3, 5.1)}");
            Console.WriteLine($"6*5={Caculator.Multiply(6, 5)}");
            Console.WriteLine($"3.5*5.5={Caculator.Multiply(3.5, 5.5)}");
            Console.WriteLine($"10/5={Caculator.Divide(10, 5)}");
            Console.WriteLine($"23.5/4.5={Caculator.Divide(23.5, 4.5)}");
            Console.WriteLine($"Min(5,2)={Caculator.Min(5, 2)}");
            Console.WriteLine($"Min(4,7,3)={Caculator.Min(4, 7, 3)}");
            Console.WriteLine($"Min(6.2,2.3,4.6)={Caculator.Min(6.2, 2.3, 4.6)}");
            Console.WriteLine($"Max(5,2)={Caculator.Max(5, 2)}");
            Console.WriteLine($"Max(4,7,3)={Caculator.Max(4, 7, 3)}");
            Console.WriteLine($"Max(6.2,2.3,4.6)={Caculator.Max(6.2, 2.3, 4.6)}");
        }
    }
}
