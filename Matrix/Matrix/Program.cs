using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            int[,] MatArr;
            int n, m;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            MatArr = new int[n, m];
            RandomMatrix(MatArr, n, m);
            Output(MatArr, n, m);
            Console.WriteLine("Row with most totals: " + RowWithMostTotals(MatArr, n, m));
        }
        static void RandomMatrix(int[,] arr, int n, int m)
        {
            Random rand = new Random();
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    arr[i, j] = rand.Next();
                }
            }
        }
        static void Output(int[,] arr, int n, int m)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int Max(int [,] arr, int n, int m)
        {
            int max = arr[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
                
            }
            return max;
        }
        static int RowWithMostTotals(int[,] arr, int n, int m)
        {
            int[] total = new int[n];
            
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    total[i] += arr[i, j]; 
                }
            }
            int max = 1;
            for(int i = 1; i < n; i++)
            {
                if(total[i] > max)
                {
                    max = i + 1;
                }
            }
            return max;
        }
        static bool IsPrimeNumber(int x)
        {
            if (x == 0 || x == 1)
                return false;
            if (x == 2 || x == 3)
                return true;
            if (x % 2 == 0)
                return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
        //d.Tim tong cac so khong phai so nguyen to
        static int SumPrimeNum(int[,] arr, int n, int m)
        {
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if(!IsPrimeNumber(arr[i, j]))
                    {
                        sum += arr[i, j];
                    }
                }
            }
            return sum;
        }
        //e. Xoa dong thu k trong ma tran
        // 1 2 3
        // 4 5 6
        // 7 8 0
        // 4 6 1
        static void XoaDongThuK(int[,]arr, ref int n, int m, int k)
        {
            for(int i = k; i < n - 1; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    arr[i, j] = arr[i + 1, j];
                }
            }
            n--;
            Output(arr, n, m);
        }
        static void XoaCotCoMax(int[,] arr, int n, ref int m)
        {
            int max = Max(arr, n, m);
            int mark = 0;// mark la cot chua so lon nhat
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if(arr[i, j] == max)
                    {
                        mark = j;
                        break;
                    }
                }
            }
            for(int i = 0; i < n; i++)
            {
                for(int j = mark; j < m - 1; j++)
                {
                    arr[i, j] = arr[i, j + 1];
                }
            }
            m--;
            Output(arr, n, m);
        }
    }
}
