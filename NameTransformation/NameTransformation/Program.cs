using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameTransformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FullName = "";
            FullName = Console.ReadLine();
            for(int i = 0; i < FullName.Length; i++)
            {
                if (FullName[i] > 97 && FullName[i] < 122)
                {
                    int x = (int)FullName[i] - 32;
                    char ch = (char)x;
                    
                }
                if(i == 0 || (FullName[i - 1] == ' '))
                {
                    Console.Write(Char.ToUpper(FullName[i]));
                }
                else
                {
                    Console.Write(Char.ToLower(FullName[i]));
                }
                
            }
            Console.WriteLine();

        }
    }
}
