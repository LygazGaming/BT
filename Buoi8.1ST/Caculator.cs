using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi8._1ST
{
    internal class Caculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static double Divide(double a, double b)
        {
            return a / b;
        }
        public static int Min(int a, int b)
        {
            return Math.Min(a, b);
        }
        public static int Min(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
        public static double Min(double a, double b, double c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
        public static int Max(int a, int b)
        {
            return Math.Max(a, b);
        }
        public static int Max(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        public static double Max(double a, double b, double c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
    }
}
