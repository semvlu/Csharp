using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    internal class Shape
    {
        protected static int amt = 0;
        protected double den;

        public Shape(double mat) {
            amt++;
            den = mat;
        }

        public static int Amt { get { return amt; } }
        public double Den {get { return den; } }
        public virtual double velo() { return 0.0; }
        public double mass() { return velo() * den; }
    }
}
