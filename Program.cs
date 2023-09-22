using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3
{
    class Triangle
    {
        public double Point1X;
        public double Point1Y;
        public double Point2X;
        public double Point2Y;
        public double Point3X;
        public double Point3Y;

        public bool isValid() { // true if any sum of 2 sides > the 3rd side
            bool v = false;
            double _1 = sideDist(Point1X, Point1Y, Point2X, Point2Y); // 1,2
            double _2 = sideDist(Point2X, Point2Y, Point3X, Point3Y); // 2,3
            double _3 = sideDist(Point1X, Point1Y, Point3X, Point3Y); // 1,3
            if (_1+_2 > _3 && _2+_3 > _1 && _1+_3 > _2)
                v = true;
            return v;
        }
        public double Perimeter() {
            double per = 0;
            double _1 = sideDist(Point1X, Point1Y, Point2X, Point2Y); // 1,2
            double _2 = sideDist(Point2X, Point2Y, Point3X, Point3Y); // 2,3
            double _3 = sideDist(Point1X, Point1Y, Point3X, Point3Y); // 1,3
            per = _1 +_2+_3;
            return per;
        } 
        public double Area() { // area = sqrt(s*(s-1st)*(s-2nd)*(s-3rd)), s = (per/2) 
            double s = Perimeter() / 2;
            double _1 = sideDist(Point1X, Point1Y, Point2X, Point2Y); // 1,2
            double _2 = sideDist(Point2X, Point2Y, Point3X, Point3Y); // 2,3
            double _3 = sideDist(Point1X, Point1Y, Point3X, Point3Y); // 1,3
            double area = Math.Sqrt(s * (s - _1) * (s - _2) * (s - _3));
            return area;
        }
        public double RadiusOfCircumcircle() { // rad = (1st*2nd*3rd) / (4*area)
            
            double _1 = sideDist(Point1X, Point1Y, Point2X, Point2Y); // 1,2
            double _2 = sideDist(Point2X, Point2Y, Point3X, Point3Y); // 2,3
            double _3 = sideDist(Point1X, Point1Y, Point3X, Point3Y); // 1,3
            double rad = (_1 * _2 * _3) / (4 * Area());
            return rad;
        }
        public bool isRight() {
            double _1 = sideDist(Point1X, Point1Y, Point2X, Point2Y); // 1,2
            double _2 = sideDist(Point2X, Point2Y, Point3X, Point3Y); // 2,3
            double _3 = sideDist(Point1X, Point1Y, Point3X, Point3Y); // 1,3
            if (Math.Pow(_1,2) + Math.Pow(_2,2) == Math.Pow(_3,2) ||
                Math.Pow(_2, 2) + Math.Pow(_3, 2) == Math.Pow(_1, 2) ||
                Math.Pow(_1, 2) + Math.Pow(_3, 2) == Math.Pow(_2, 2))
            { return true; }
            else { return false; }
        }

        private double sideDist(double x1, double y1, double x2, double y2)
        { return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)); }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Triangle tri = new Triangle();
                Console.WriteLine("Enter x1 & y1: ");
                tri.Point1X = double.Parse(Console.ReadLine());
                tri.Point1Y = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter x2 & y2: ");
                tri.Point2X = double.Parse(Console.ReadLine());
                tri.Point2Y = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter x3 & y3: ");
                tri.Point3X = double.Parse(Console.ReadLine());
                tri.Point3Y = double.Parse(Console.ReadLine());

                if (tri.isValid() == true)
                {
                    Console.WriteLine("Valid Triangle!");
                    Console.WriteLine("Perimeter = {0}", tri.Perimeter());
                    Console.WriteLine("Area = {0}", tri.Area());
                    Console.WriteLine("Radius of circumcircle = {0}", tri.RadiusOfCircumcircle());
                    if (tri.isRight() == true)
                        Console.WriteLine("Right Triangle!");
                    else
                        Console.WriteLine("Not Right Triangle!");
                }
                else { Console.WriteLine("Invalid Triangle!"); }

                Console.WriteLine("Play again? ");
                char choice = Console.ReadKey().KeyChar;
                if (choice == 'n')
                    break;
                else if (choice == 'y')
                {
                    Console.WriteLine();
                    continue;
                }
            }

        }
    }
}
