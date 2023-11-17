using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public static class ShapeType
    {
        public enum Material { UNKNOWN =-1, Al=0,Fe,Pb};
        public enum Geo { UNKNOWN=-1, BALL=0,CUBE,CYLINDER,PYRAMID};
    }
    public abstract class Shape3D
    {
        protected static int amount;
        protected ShapeType.Material material;
        protected ShapeType.Geo geo;
        public Shape3D() { amount++; material= ShapeType.Material.UNKNOWN; }
        public Shape3D(ShapeType.Material material)
        {
            this.material = material;
            amount++;
        }
        public static int Amount {  get { return amount; } }
        public ShapeType.Geo Geo { get { return geo; } }
        public ShapeType.Material Material { get {  return material; } }

        public double Density() { return MaterialTable.Density(material); }
        public abstract double Volume();
        public double Weight() { return Volume() * Density(); }
        public abstract string ShapeProperty();
        public string Property()
        {
            string s = "";
            s += string.Format("{0,8:F2}", Density());
            s += '\t';
            s += string.Format("{0,8:F2}", Volume());
            s += '\t';
            s += string.Format("{0,8:F2}", Weight());
            return s;
        }
    }
}
