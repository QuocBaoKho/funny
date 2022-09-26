using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triangle : Shape
    {
        Point a, b, c;
        public Triangle()
        {
            this.a = new Point(0, 0);
            this.b = new Point(0, 0);
            this.c = new Point(0, 0);
            
        }
        public Triangle(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Point A { get { return a; } }
        public Point B { get { return b; } }
        public Point C { get { return c; } }

        public override void Input()
        {
            Console.WriteLine("Nhap hinh tam giac: ");
            Console.Write("Nhap diem A: ");
            a.Nhap();
            Console.Write("Nhap diem B: ");
            b.Nhap();
            Console.Write("Nhap diem C: ");
            c.Nhap();

        }
        public override void Draw()
        {
            try
            { if (!Check()) 
                { 
                      throw new Exception(); 
                
                }
                Console.Write("Tam giac co 3 dinh: ");
                a.Xuat();
                Console.Write(", ");
                b.Xuat();
                Console.Write(", ");
                c.Xuat();
            }
            catch(Exception e) { Console.WriteLine("Not triangle"); }
            


        }
        public override bool Check()
        {
            double AB = a.Distance(b);
            double BC = b.Distance(c);
            double AC = a.Distance(c);

            return (AB + BC > AC && AB + AC > BC && AC + BC > AB );
        }
        public override double Perimeter()
        {
            try
            {
                if (!Check())
                    throw new Exception();
            }
            catch (Exception e) { Console.WriteLine("Day khong phai hinh tam giac"); }
            double AB = a.Distance(b);
            double BC = b.Distance(c);
            double AC = a.Distance(c);
            return AB + BC + AC;
        }
        public override double Area()
        {
            if (!Check())
                return -1;
            double AB = a.Distance(b);
            double BC = b.Distance(c);
            double AC = a.Distance(c);
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - AB) * (p - AC) * (p - BC));
        }
        public override string Name()
        {
            return "Triangle";
        }



    }
}
