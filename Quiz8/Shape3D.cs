using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106_Quiz7
{
    static class ShapeType
    {
        public enum Geo { UNKNOWN = -1, BALL = 0, CUBE, CYLINDER, PYRAMID };
        public enum Material { UNKNOWN = -1, Al = 0, Fe, Pb };
    }
    abstract class Shape3D
    {
        protected ShapeType.Geo geo;
        protected ShapeType.Material material;
        protected static int _amount;  //被繼承的欄位 (資料成員)需宣告為 protected
        public Shape3D()
        {
            material = ShapeType.Material.UNKNOWN; ;
            _amount++;
        }

        public Shape3D(ShapeType.Material mType)
        {
            material = mType;
            _amount++;
        }

        public ShapeType.Material Material
        { get { return material; } }
        public ShapeType.Geo Geo
        { get { return geo; } }
        public double Density()
        {
            double d = 0;
            switch (material)
            {
                case ShapeType.Material.Al:
                    d = 2.7;
                    break;
                case ShapeType.Material.Fe:
                    d = 7.87;
                    break;
                case ShapeType.Material.Pb:
                    d = 11.3;
                    break;
                default:
                    break;
            }
            return d;
        }
        public static int Amount     //要給其他類別取用, 故宣告為 public
        {
            get { return _amount; }
        }

        public abstract double Volume();  //虛擬函式, 子類別需進行 override
        public double Weight()         //開放給其他類別使用, 故宣告成 public
        {
            return Density() * Volume();
        }
        public abstract string ShapeProperty();   //虛擬函式, 子類別需進行 override
        protected string Property()      //只讓子類別呼叫, 故宣告 protected, 抽出子類別重複的程式碼進行重構
        {
            string str = "";
            str += string.Format("{0,8:F2}", Density());
            str += '\t';
            str += string.Format("{0,8:F2}", Volume());
            str += '\t';
            str += string.Format("{0,8:F2}", Weight());
            return str;
        }
    }
    
}
