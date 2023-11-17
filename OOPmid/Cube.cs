using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Cube:Shape3D
    {
        new static private int amount;
        private double side;
        public Cube() : base() { geo = ShapeType.Geo.CUBE; amount++;side = 0; }
        public Cube(double s,ShapeType.Material m) : base(m) { geo = ShapeType.Geo.CUBE;amount++;side = s; }
        new static public int Amount {  get { return amount; } }
        public double Side { get { return side; } set { if (value < 0) side = 0; else side = value; } }
        public override double Volume()
        { return Math.Pow(side, 3); }
        public override string ShapeProperty()
        {
            string s = string.Format("{0,8}", "Cube");
            s += '\t';
            s += string.Format("{0,8:F2}", side);
            s += '\t';
            s += string.Format("{0,8}", "");
            s += '\t';
            s += Property();
            return s;
        }

    }
}
