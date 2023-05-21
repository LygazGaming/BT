using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a;
            Console.WriteLine("Nhap a:");
            Input2DArray(out a);
            Console.WriteLine("Bang a: ");
            Output2DArray(a);
            Console.Write("Nhap k: ");
            int k = int.Parse(Console.ReadLine());
            RowSort(a, k);
            Console.WriteLine("Bang a tang dan dong " + k);
            Output2DArray(a);
            ColumnSort(a, k);
            Console.WriteLine("Bang a tang dang cot" + k);
            Output2DArray(a);
            Console.Write("Nhap chi so 01: ");
            int cs1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap chi so 02: ");
            int cs2 = int.Parse(Console.ReadLine());
            RowSwap(a, cs1, cs2);
            Output2DArray(a);
            Console.Write("Bang a sau khi sap xep tong cua tung dong tang dan:");
            TableSortBySum(a);
            Output2DArray(a);
        }
        static void Input2DArray(out int[,] a)
        {
            int m, n;
            string line = Console.ReadLine();
            string[] nums = line.Split(' ');
            m = int.Parse(nums[0]);
            n = int.Parse(nums[1]);
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
        //Câu a
        static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        static void RowSort(int[,] a, int k)
        {
            for (int i = 0; i < a.GetLength(1) - 1; i++)
            {
                for (int j = i + 1; j < a.GetLength(1); j++)
                {
                    if (a[k, i] > a[k, j])
                        Swap(ref a[k, i], ref a[k, j]);
                }
            }
        }
        //Câu b
        static void ColumnSort(int[,] a, int k)
        {
            for (int i = 0; i < a.GetLength(0) - 1; i++)//Xét từng dòng
            {
                for (int j = i + 1; j < a.GetLength(0); j++)
                {
                    if (a[i, k] > a[j, k])
                        Swap(ref a[i, k], ref a[j, k]);

                }
            }
        }
        //Câu c
        static void RowSwap(int[,] a, int cs1, int cs2)
        {
            for (int i = 0; i < a.GetLength(1); i++)
            {
                Swap(ref a[cs1, i], ref a[cs2, i]);
            }
        }
        //Câu d
        static int SumOfRow(int[,] a, int k)
        {
            int sum = 0;
            if (k < 0 && k >= a.GetLength(0))
            {
                Console.WriteLine("Invalid k");
            }
            else
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    sum += a[k, c];
                }
            }
            return sum;
        }
        static void TableSortBySum(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < a.GetLength(0); j++)
                {
                    if (SumOfRow(a, i) > SumOfRow(a, j))
                        RowSwap(a, i, j);
                }
            }
        }
    }
}
