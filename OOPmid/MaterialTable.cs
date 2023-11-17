using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Element
    {
        public ShapeType.Material Material { get; set; }
        public string Name { get; set; }
        public double Density { get; set; }
        public Element(){}
        public Element(ShapeType.Material material, string n, double d)
        {
            this.Material = material;
            this.Name = n;
            this.Density = d;
        }
    }
    public static class MaterialTable
    {
        public static Element[] elements = {new Element(ShapeType.Material.Al, "鋁",2.7),
        new Element(ShapeType.Material.Fe, "鐵",7.87), new Element(ShapeType.Material.Pb,"鉛",11.3)};
        public static ShapeType.Material Type(string name)
        {
            foreach(var e in elements)
            {
                if (e.Name == name)
                    return e.Material;
            }
            return 0;
        }
        public static double Density(string  name)
        {
            foreach (var e in elements)
            { if (e.Name == name) return e.Density;}
            return 0;
        }
        public static double Density(ShapeType.Material material)
        {
            foreach (var e in elements) { if (e.Material == material) return e.Density; }
            return 0;
        }
    }
}
