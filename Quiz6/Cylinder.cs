using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    internal class Cylinder: Shape
    {
        new private static int amt = 0;
        private double dia;
        private double hei;


        public Cylinder(double mat, double dia, double hei) : base(mat)
        {
            this.dia = dia;
            this.hei = hei;
            amt++;
        }
        new public static int Amt { get { return amt; } }
        public double Dia { get { return dia; } }
        public double Hei { get { return hei; } }
        public override double velo() { return Math.PI * Math.Pow(dia, 2) * hei; }

    }
}
