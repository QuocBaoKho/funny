using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        double x, y;
        public Point(double x = 0, double y = 0)
        {
            this.x = x;
            this.y = y;
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public void Nhap()
        {
            Console.Write("Nhap hoanh do: ");
            x = Double.Parse(Console.ReadLine());
            Console.Write("Nhap tung do: ");
            y = Double.Parse(Console.ReadLine());
            
        }
        public void Xuat()
        {
            Console.Write("({0},{1})", x, y);
        }
        public double Distance(Point Zelensky)
        {
            double a = Zelensky.X - x;
            double b = Zelensky.Y - y;
            double answer = Math.Sqrt(a * a + b * b);
            return answer;

            
        }

    }
    class Shape{
        public virtual void Input()
        {

        }
        public virtual void Draw()
        {

        }
        public virtual bool Check()
        {
            return false;
        }
        public virtual double Perimeter()
        {
            return -1;
        }
        public virtual double Area() { return -1; }
        public virtual string Name() { return "Michael Myers"; }
    }
    
    
    
}
