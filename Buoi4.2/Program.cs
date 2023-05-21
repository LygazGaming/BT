using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            int n;
            int x;
            NhapMang(out a, out n, out x);
            Console.Write(vitri(a, x, 0, a.Length - 1));
        }
        static void NhapMang(out int[] a, out int n, out int x)
        {
            string line = Console.ReadLine();
            string[] nums = line.Split();
            n = int.Parse(nums[0]);
            x = int.Parse(nums[1]);
            a = new int[n];
            line = Console.ReadLine();
            nums = line.Split();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(nums[i]);
            }

        }
        static int vitri(int[] a, int x, int dau, int cuoi)
        {
            int k = (dau + cuoi) / 2;
            if (dau > cuoi) return -1;
            else if (a[k] == x) return k;
            else if (a[k] > x) return vitri(a, x, dau, k - 1);
            else return vitri(a, x, k + 1, cuoi);
        }

    }
}
