// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1
{
    class Program
    {
        static void Main(string[] Args)
        {
            /*
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + " + " + y + " = " + (x + y));
            string A, B, C;
            A = Console.ReadLine();
            B = Console.ReadLine();
            C = Console.ReadLine();
            Console.WriteLine(A + " is the smart guy, " + B + " is the brute, and " + C +  " is the monster");*/
            int[] arr = { 5, 1, 3 };
            string[] str = new string[100];
            Console.WriteLine(GetPow(3,2));
           
            Console.ReadLine();

        }
        static void ChuHoa(int x)
        {
            Console.WriteLine("I need ammunition, not a ride.");
        }
        static int GetPow(int x, int n)
        {
            if (n == 0)
                return 1;
            
            return x * GetPow(x, n - 1);
        }
    }
}

