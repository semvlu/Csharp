using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    internal class Cube: Shape
    {
        new private static int amt = 0;
        private double side;

        public Cube(double mat, double side) : base(mat)
        {
            this.side = side;
            amt++;
        }
        new public static int Amt { get { return amt; } }
        public double Side { get { return side; } }
        public override double velo() { return Math.Pow(side, 3); }

    }
}
