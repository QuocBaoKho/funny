// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Mitsuharu_Misawa;
class program
{
    enum Days { Mon = 2, Tues, Wednes, Thurs, Fri, Satur, Sun };
    static void Main()
    {/*
        int x, y;
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        
        int z = Multiply(x, y);
        Console.Write("{0} x {1} = {2}", x, y, z);*/
        /* 
         int[,] darr = new int[3, 4];
         Console.Write("Type in the number of numbers in array: ");
         int n = Convert.ToInt32(Console.ReadLine());
         int[] arr = new int[n];
         for (int i = 0; i < n; i++)
         {
             Console.Write(i + 1 + ".\t");            
             arr[i] = Convert.ToInt32(Console.ReadLine()); 
         }

         int sum = 0;
         for(int i = 0; i < n; i++)
         {
             sum += arr[i];
         }
         Console.WriteLine("Sum of all numbers in array: " + sum);
         *//*
         string axel = Console.ReadLine();
         string[] NumberSplit = axel.Split(", ");

         int[] arr = new int[NumberSplit.Length];
         for(int i = 0; i < NumberSplit.Length; i++)
         {
             arr[i] = Convert.ToInt32(NumberSplit[i]);
         }
         Console.WriteLine(Sum(arr));*/
        /*try
        {
            double a = 5, b = 0;
            Console.WriteLine("{0} / {1} = {2}", a, b, DoDivide(a,b));
        }
        catch (System.DivideByZeroException)
        {
            Console.WriteLine("You get caught by zero!");
        }
        catch
        {
            Console.WriteLine("Another exception gets caught!");
        }*/
        
        int n;
        do { n = Convert.ToInt32(Console.ReadLine()); } while (n <= 0);
        Shape[] SH = new Shape[n];
        Random rand = new Random();
        for(int i = 0; i < n; i++)
        {
            int r = rand.Next(1, 5);
            switch (r)
            {
                case 1:
                    {
                        SH[i] = new Triangle();
                        


                        break;
                    }
                case 2:
                    {
                        SH[i] = new Rectangle();
                        break;
                    }
                case 3:
                    {
                        SH[i] = new Square();
                        break;
                    }
                case 4:
                    {
                        SH[i] = new Circle();
                        break;
                    }
            }
            
        }
        for(int i = 0; i < n; i++)
        {
            SH[i].Input();
            Console.WriteLine();
        }    
        for(int i = 0; i < n; i++)
        {
            SH[i].Draw();
            Console.WriteLine();
            Console.Write("Area = ");
            Console.WriteLine(SH[i].Area());
            Console.WriteLine();

        }
       


      
    }
    public static double DoDivide(double a, double b)
     {
        if (b == 0)
        throw new System.DivideByZeroException();
        if (a == 0)
        throw new System.ArithmeticException();
         return a / b;
   }

static int Multiply(int x, int y)
    {
        if (y == 1)
            return x;
        return x + Multiply(x, y - 1);
    }
    static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
    static int Sum(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
} 