// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Specialized;

namespace gta
{
    class Program
    {
        static void Main()
        {
            int month, year;
            do
            {
                month = Convert.ToInt32(Console.ReadLine());
            } while (month < 1 || month > 12);
            
            year = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        Console.WriteLine(31);
                        break;
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        Console.WriteLine(30);
                        break;
                    }
                case 2:
                    {
                        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                        {
                            Console.WriteLine(29);
                        }
                        else
                            Console.WriteLine(28);
                        break;
                    }
            }

        }
    }
}