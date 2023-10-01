using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    internal class Ball : Shape
    {
        new private static int amt = 0;
        private double dia;

        public Ball(double mat, double dia) : base(mat)
        {
            this.dia = dia;
            amt++;
        }
        new public static int Amt{ get {return amt;} }
        public double Dia { get { return dia; } }

        public override double velo() { return  (double)4/3 * Math.PI * Math.Pow(dia, 3); }
    }
}
