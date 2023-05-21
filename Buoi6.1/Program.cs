using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student sv1 = new Student();
            sv1.Input();
            sv1.PrintInfo();
            Student sv2 = new Student("22DH114616", "Nguyen Van A", 2004, true, "T22310");
            sv2.PrintInfo();
        }
    }
}
