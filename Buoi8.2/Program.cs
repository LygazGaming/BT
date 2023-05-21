using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction();
            f1.Input();
            Console.WriteLine("Phan so thu 1 la:"+f1.ToString());
            Fraction f2 = new Fraction();
            f2.Input();
            Console.WriteLine("Phan so thu 2 la:"+f2.ToString());
            Fraction cong=f1+f2;
            Fraction tru = f1 - f2;
            Fraction nhan = f1* f2;
            Fraction chia = f1/ f2;
            if (f1==f2) Console.WriteLine("2 Phan so bang nhau");
            if (f1!=f2) Console.WriteLine("Hai phan so khong bang nhau");
            if (f1>=f2) Console.WriteLine("Phan so thu 1 lon hon hoac bang phan so thu 2");
            if (f1>f2) Console.WriteLine("Phan so thu 1 lon hon phan so thu 2");
            if (f1<=f2) Console.WriteLine("Phan so thu 1 be hon hoac bang phan so thu 2");
            if (f1<f2) Console.WriteLine("Phan so thu 1 be hon phan so thu 2");
            Console.WriteLine("Tong hai phan so:"+cong.ToString());
            Console.WriteLine("Hieu hai phan so:"+tru.ToString());
            Console.WriteLine("Tich hai phan so:"+nhan.ToString());
            Console.WriteLine("Thuong hai phan so:"+chia.ToString());
            Fraction a = new Fraction(1, 2);
            Console.WriteLine("Phan so thu 3 la:"+a.ToString());
            a = -a;
            Console.WriteLine("Phan so thu 3 sau khi doi dau:"+a.ToString());
            MixedFraction p1 = new MixedFraction(1,2,3);
            Console.WriteLine("Hon so thu 1 la:" +p1.ToString());
            MixedFraction p2 = new MixedFraction(1, 2, 3);
            Console.WriteLine("Hon so thu 2 la:"+p2.ToString());
            MixedFraction a1 = p1 + p2;
            Console.WriteLine("Tong hai hon so la:"+a1.ToString());
            MixedFraction a2 = p1 - p2;
            Console.WriteLine("Hieu hai hon so la:"+a2.ToString());
            MixedFraction a3 = p1 * p2;
            Console.WriteLine("Tich hai hon so la:"+a3.ToString());
            MixedFraction a4 = p1 / p2;
            Console.WriteLine("Thuong hau hon so la:"+a4.ToString());
            if (p1 == p2) Console.WriteLine("Hai hon so bang nhau");
            if (p1 != p2) Console.WriteLine("Hai hon so khong bang nhau");
            if (p1 >= p2) Console.WriteLine("Hon so thu 1 lon hon hoac bang hon so thu 2");
            if (p1 > p2) Console.WriteLine("Hon so thu 1 lon hon hon hon so thu 2");
            if (p1 <= p2) Console.WriteLine("Hon so thu 1 be hon hoac bang hon so thu 2");
            if (p1 < p2) Console.WriteLine("Hon so thu 1 be hon hon so thu 2");
        }
    }
}
