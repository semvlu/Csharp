using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4
{
    class Triangle
    {
        private double[] pt;
        public Triangle(double[] p)
        {
            pt = new double[6];
            pt[0] = p[0];
            pt[1] = p[1];
            pt[2] = p[2];
            pt[3] = p[3];
            pt[4] = p[4];
            pt[5] = p[5];
        }

        public bool isValid()
        {
            bool v = false;
            double[] side;
            side = new double[3];
            side[0] = sideDist(pt[0], pt[1], pt[2], pt[3]); // 1,2
            side[1] = sideDist(pt[2], pt[3], pt[4], pt[5]); // 2,3
            side[2] = sideDist(pt[0], pt[1], pt[4], pt[5]); // 1,3
            if (side[0] + side[1] > side[2] && side[1] + side[2] > side[0] && side[0] + side[2] > side[1])
                v = true;
            return v;
        }

        public double Perimeter()
        {
            double per = 0;
            double[] side;
            side = new double[3];
            side[0] = sideDist(pt[0], pt[1], pt[2], pt[3]); // 1,2
            side[1] = sideDist(pt[2], pt[3], pt[4], pt[5]); // 2,3
            side[2] = sideDist(pt[0], pt[1], pt[4], pt[5]); // 1,3
            for (int i = 0; i < side.Length; i++)
                per+= side[i];
            return per;
        }
        public double Area()
        { // area = sqrt(s*(s-1st)*(s-2nd)*(s-3rd)), s = (per/2) 
            double s = Perimeter() / 2;
            double[] side;
            side = new double[3];
            side[0] = sideDist(pt[0], pt[1], pt[2], pt[3]); // 1,2
            side[1] = sideDist(pt[2], pt[3], pt[4], pt[5]); // 2,3
            side[2] = sideDist(pt[0], pt[1], pt[4], pt[5]); // 1,3
            double area = Math.Sqrt(s * (s - side[0]) * (s - side[1]) * (s - side[2]));
            return area;
        }
        public double RadiusOfCircumcircle()
        { // rad = (1st*2nd*3rd) / (4*area)

            double[] side;
            side = new double[3];
            side[0] = sideDist(pt[0], pt[1], pt[2], pt[3]); // 1,2
            side[1] = sideDist(pt[2], pt[3], pt[4], pt[5]); // 2,3
            side[2] = sideDist(pt[0], pt[1], pt[4], pt[5]); // 1,3
            double rad = (side[0] * side[1] * side[2]) / (4 * Area());
            return rad;
        }
        public bool isRight()
        {
            double[] side;
            side = new double[3];
            side[0] = sideDist(pt[0], pt[1], pt[2], pt[3]); // 1,2
            side[1] = sideDist(pt[2], pt[3], pt[4], pt[5]); // 2,3
            side[2] = sideDist(pt[0], pt[1], pt[4], pt[5]); // 1,3
            if (Math.Pow(side[0], 2) + Math.Pow(side[1], 2) == Math.Pow(side[2], 2) ||
                Math.Pow(side[1], 2) + Math.Pow(side[2], 2) == Math.Pow(side[0], 2) ||
                Math.Pow(side[0], 2) + Math.Pow(side[2], 2) == Math.Pow(side[1], 2))
            { return true; }
            else { return false; }
        }

        private double sideDist(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double[] p;
                p = new double[6];
                Console.WriteLine("請依序輸入三角形的三個頂點 ");
                for (int i = 0; i < 6; i+=2)
                {
                    Console.Write("(x" + (i/2+1).ToString() + ", y" +  (i/2+1).ToString() + ") =");
                    string[] tk = Console.ReadLine().Split();
                    p[i] = int.Parse(tk[0]);
                    p[i+1] = int.Parse(tk[1]);
                }

                Triangle t = new Triangle(p);
                if (t.isValid() == true)
                {
                    Console.WriteLine("Perimeter={0}", t.Perimeter());
                    Console.WriteLine("Area={0}", t.Area());
                    Console.WriteLine("Radius of Circumcircle={0}", t.RadiusOfCircumcircle());
                    if (t.isRight() == true)
                        Console.WriteLine("This is a right triangle!");
                }
                else { Console.WriteLine("Not a Triangle, Please Input the new Coordinates!"); }

                Console.WriteLine("Again?");
                char a = Console.ReadKey().KeyChar;
                if (a == 'n')
                    break;
                Console.WriteLine();
            }
        }
    }
}
