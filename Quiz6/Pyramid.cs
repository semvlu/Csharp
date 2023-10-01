using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    internal class Pyramid: Shape
    {
        new private static int amt = 0;
        private double side;
        private double hei;

        public Pyramid(double mat, double side, double hei): base(mat)
        {
            this.side = side;
            this.hei = hei;
            amt++;
        }
        new public static int Amt { get { return amt; } }
        public double Side { get { return side; } }
        public double Hei { get { return hei; } }
        public override double velo() { return (double)1 / 3 * Math.Pow(side,2) * hei; }
    }
}
