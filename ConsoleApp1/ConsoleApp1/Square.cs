using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Square : Rectangle
    {
        public Square()
        {
            this.a = new Point(0, 0);
            this.b = new Point(0, 0);
            this.c = new Point(0, 0);
            this.d = new Point(0, 0);
        }
        public Square(Point a, Point b, Point c, Point d):base(a, b, c, d)
        {
            

        }
        public override void Draw()
        {
            try
            {
                if (!Check())
                    throw new Exception();
                Console.Write("Hinh vuong co 4 dinh: ");
                a.Xuat();
                Console.Write(", ");
                b.Xuat();
                Console.Write(", ");
                c.Xuat();
                Console.Write(", ");
                d.Xuat();
            }
            catch(Exception e) { Console.WriteLine("This is not a square!"); }
            
        }
        public override void Input()
        {
            base.Input();
        }
        public override bool Check()
        {
            if (!base.Check()) { return false; }
            double center_x = (a.X + b.X + c.X + d.X) / 4;
            double center_y = (a.Y + b.Y + c.Y + d.Y) / 4;
            Point Center = new Point(center_x, center_y);
            double z = Center.Distance(A) * 2;
            double ab, ac, ad;
            ab = a.Distance(b);
            ac = a.Distance(c);
            ad = a.Distance(d);
            if (ab == z)
                return (ac == ad);
            if (ac == z)
                return (ab == ad);
            return (ab == ac);

            
        }
        
        public override double Area()
        {
            if (!Check()) { return -1; }
            
            double center_x = (a.X + b.X + c.X + d.X) / 4;
            double center_y = (a.Y + b.Y + c.Y + d.Y) / 4;
            Point Center = new Point(center_x, center_y);
            double z = Center.Distance(A) * 2;
            double ab, ac, ad;
            ab = a.Distance(b);
            ac = a.Distance(c);
            ad = a.Distance(d);
            if (ab == z)
                return (ac * ad);
            if (ac == z)
                return (ab * ad);
            return (ab * ac);
        }


    }
}
