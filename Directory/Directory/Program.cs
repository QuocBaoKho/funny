// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Collections;
namespace Director
{
    class ehowejo
    {
        static void Main()
        {
            Console.Write("Write directory: ");
            string strFile = Console.ReadLine();
            if (System.IO.Directory.Exists(strFile))
            {
                string[] str = Directory.GetFiles(strFile);
                if (str.Length != 0)
                {
                    Console.WriteLine();
                    for (int i = 0; i < str.Length; i++)
                    {
                        Console.WriteLine(str[i]);
                    }
                }
            }
            else
                Console.Write("There's no file in this folder");
            Console.WriteLine();
            /*
             1.	Viết chương trình yêu cầu người dùng nhập đường dẫn thư mục, xuất tất cả tên tập tin và thư mục con
                2.	Xây dựng chương trình có chức năng
                a.	Nhập / xuất ma trận hai chiều các số nguyên
                b.	Tìm kiếm một phần tử trong ma trận
                c.	Xuất các phần tử là số nguyên tố

             */
            int[,] Matrix = new int[100, 100];
            int row, column;
            Console.Write("Type rows number: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type columns number: ");
            column = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < column; j++)
                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i< row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Write("Cac so nguyen to trong mang 2 chieu: ");
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    if (IsSoNguyenTo(Matrix[i, j]))
                    {
                        Console.WriteLine(Matrix[i, j]);
                    }
                }
            }
            string FullName;

            
            
        }
        static bool Search(int[,] arr, int r, int c, int value)
        {
            for(int i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    if(arr[i, j] == value)
                        return true;
                }
            }
            return false;

        }
        static bool IsSoNguyenTo(int x)
        {
            if (x == 1)
                return false;
            if (x == 2 || x % 2 == 0)
                return true;
            for(int i = 2; i <= x; i++)
            {
                if (x % i == 0)
                    return false;
            }

            return true;
        }
    }
}
 