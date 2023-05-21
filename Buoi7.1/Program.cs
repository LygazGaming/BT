using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.Input();
            Console.WriteLine(st1.ToString());
            Student st2=new Student("Nguyen Van A", 2004, "Su Van Hanh", "CNTT",1);
            Console.WriteLine(st2.ToString());
            Staff nv1 = new Staff();
            nv1.Input();
            Console.WriteLine(nv1.ToString());
            Staff nv2 = new Staff("Nguyen Van A",2004,"Su Van Hanh","CNTT",150000);
            Console.WriteLine(nv2.ToString());
            nv2.UpdataSalary(19000);
            Console.WriteLine(nv2.ToString());
        }
    }
}
