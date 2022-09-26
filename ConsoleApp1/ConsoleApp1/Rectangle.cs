using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangle : Shape
    {
        protected Point a, b, c, d;
        public Rectangle()
        {
            this.a = new Point(0, 0);
            this.b = new Point(0, 0);
            this.c = new Point(0, 0);
            this.d = new Point(0, 0);
        }
        public Rectangle(Point a, Point b, Point c, Point d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public Rectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            this.a = new Point(x1, y1);
            this.b = new Point(x2, y2);
            this.c = new Point(x3, y3);
            this.d = new Point(x4, y4);
        }
        public Point A { get { return a; } }
        public Point B { get { return b; } }
        public Point C { get { return c; } }
        public Point D { get { return d; } }
        public override void Input()
        {
            Console.WriteLine("Nhap hinh chu nhat: ");
            Console.Write("Nhap diem A: ");
            a.Nhap();
            Console.Write("Nhap diem B: ");
            b.Nhap();
            Console.Write("Nhap diem C: ");
            c.Nhap();
            Console.Write("Nhap diem D: ");
            d.Nhap();
        }
        public override void Draw()
        {
            try
            {
                if (!Check())
                    throw new Exception();
                Console.Write("Hinh chu nhat co 4 dinh: ");
                a.Xuat();
                Console.Write(", ");
                b.Xuat();
                Console.Write(", ");
                c.Xuat();
                Console.Write(", ");
                d.Xuat();
            }
            catch (Exception e)
            {
                Console.WriteLine("Day khong phai hinh chu nhat");
            }
            
        }
        public override bool Check()
        {
            double center_x, center_y;

            center_x = (a.X + b.X + c.X + d.X) / 4;
            center_y = (a.Y + b.Y + c.Y + d.Y) / 4; 
            Point Center = new Point(center_x, center_y);
            bool ale = (Center.Distance(a) == Center.Distance(b)
                        && Center.Distance(a) == Center.Distance(c)
                        && Center.Distance(a) == Center.Distance(d));
            
            return ale;
        }
        public override double Perimeter()
        {
            try
            {
                if (!Check())
                    throw new Exception();
            }
            catch (Exception e) { Console.WriteLine("Khong tinh duoc chu vi"); }
            double center_x, center_y;
            center_x = (a.X + b.X + c.X + d.X) / 4;
            center_y = (a.Y + b.Y + c.Y + d.Y) / 4;
            Point Center = new Point(center_x, center_y);
            double DuongCheo = Center.Distance(a) * 2;
            double AB = a.Distance(b);
            double AC = a.Distance(c);
            double AD = a.Distance(d);
            if (AB == DuongCheo)
                return (AC + AD) * 2;
            if (AC == DuongCheo)
                return (AB + AD) * 2;

            return (AB + AC) * 2;
        }
        public override double Area()
        {
            try
            {
                if (!Check())
                    throw new Exception();
            }
            catch (Exception e) { Console.WriteLine("Khong tinh duoc dien tich");  return -1; }
            double center_x, center_y;
            center_x = (a.X + b.X + c.X + d.X) / 4;
            center_y = (a.Y + b.Y + c.Y + d.Y) / 4;
            Point Center = new Point(center_x, center_y);
            double DuongCheo = Center.Distance(a) * 2;
            double AB = a.Distance(b);
            double AC = a.Distance(c);
            double AD = a.Distance(d);
            if (AB == DuongCheo)
                return (AC * AD);
            if (AC == DuongCheo)
                return (AB * AD);

            return (AB * AC);
        }
        public override string Name()
        {
            return "Rectangle";
        }


    }
}
