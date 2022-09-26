using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circle : Shape
    {
        Point o;
        double r;
        public Circle()
        {
            this.o = new Point(0, 0);
            r = 1;
        }
        public Circle(Point o, double r)
        {
            this.o = o;
            while(r <= 0)
            {
                r = Convert.ToDouble(Console.ReadLine());
            }
            this.r = r;
        }
        public Point O { get; set; }
        public double R { get; set; }
        public override void Input()
        {
            Console.Write("Nhap tam O cua duong tron: ");
            o.Nhap();
            Console.Write("Nhap ban kinh: ");
            r = double.Parse(Console.ReadLine());
        }
        public override void Draw()
        {
            Console.Write("Hinh tron co tam O");
            o.Xuat();
            Console.WriteLine(" voi ban kinh R = " + r);
        }
        public override double Perimeter()
        {
            return Math.PI * 2 * r;
        }
        public override double Area()
        {
            return Math.PI * r * r;
        }
        public override string Name()
        {
            return "Circle";
        }
    }
}
