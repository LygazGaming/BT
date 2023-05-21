using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi8._1NST
{
    internal class Caculator
    {
        public Caculator()
        {

        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
        public double Divide(double a, double b)
        {
            return a / b;
        }
        public int Min(int a, int b)
        {
            return Math.Min(a, b);
        }
        public int Min(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
        public double Min(double a, double b, double c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
        public int Max(int a, int b)
        {
            return Math.Max(a, b);
        }
        public int Max(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        public double Max(double a, double b, double c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
    }
}
