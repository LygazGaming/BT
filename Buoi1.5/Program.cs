using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] a;
            int k;
            Input2DArray(out a, out k);
            Output2DArray(a);
            Console.WriteLine("Gia tri lon nhat cua dong la:" + MaxD(a, k));
            Console.WriteLine("Gia tri nho nhat cua cot la:" + MinC(a, k));
            List<int> kq = PhanTuNguyenTo(a);
            Console.Write("Day so nguyen to la:");
            for (int i = 0; i < kq.Count; i++)
                Console.Write(kq[i] + " ");
        }
        static void Input2DArray(out int[,] a, out int k)
        {
            int m, n;
            string line = Console.ReadLine();
            string[] nums = line.Split(' ');
            m = int.Parse(nums[0]);
            n = int.Parse(nums[1]);
            k = int.Parse(nums[2]);
            a = new int[m, n];
            for (int r = 0; r < a.GetLength(0); r++)
            {
                line = Console.ReadLine();
                nums = line.Split(' ');
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    a[r, c] = int.Parse(nums[c]);
                }
            }
        }

        static void Output2DArray(int[,] intArr)
        {
            for (int r = 0; r < intArr.GetLength(0); r++)
            {
                for (int c = 0; c < intArr.GetLength(1); c++)
                {
                    Console.Write(intArr[r, c] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static int MaxD(int[,] a, int k)
        {
            int max = a[k, 0];
            for (int i = 1; i < a.GetLength(0); i++)
                if (max < a[k, i]) max = a[k, i];
            return max;
        }
        static int MinC(int[,] a, int k)
        {
            int min = a[k, 0];
            for (int i = 1; i < a.GetLength(0); i++)
                if (min > a[i, k]) min = a[i, k];
            return min;
        }
        static bool snt(int a)
        {
            if (a <= 1) return false;
            else if (a >= 4)
            {
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0) return false;
                }
            }
            return true;
        }
        static List<int> PhanTuNguyenTo(int[,] a)
        {
            List<int> ketqua = new List<int>();
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (snt(a[i, j])) ketqua.Add(a[i, j]);
                }
            return ketqua;
        }
    }

}
