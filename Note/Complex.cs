using Note;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note
{
    internal class Complex
    {
        private double re;
        private double im;
        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        public static Complex operator *(Complex a, Complex b) {
            Complex res = new Complex(0, 0);
            res.re = a.re * b.re - a.im * b.im;
            res.im = a.re * b.im + a.im * b.re;
            return res;
        }
        // out
        public void outPow(int exp, out Complex res)
        {
            
            if (exp < 0)
                throw new PowerException("exp is negative");
            if (this.re == 0 && this.im == 0 && exp == 0)
                throw new PowerException("pow(0,0) N/A");
            res = new Complex(1, 0);
            if (exp == 0) return;
            for (int i = 0; i < exp; i++)
                res *= this;
        }

        // ref
        public void refPow(int exp, ref Complex res)
        {
            res.re = 1;
            res.im = 0;
            if (exp == 0) return;
            for (int i = 0; i < exp; i++)
                res *= this;
        }

        // params: able to send as many params as you want
        // able to send array as well
        public static Complex mul(params Complex[] a)
        {
            Complex res = new Complex(1, 0);
            for (int i = 0; i < a.Length; i++)
                res *= a[i];
            return res;
        }
    }

    class PowerException : Exception
    {
        public PowerException(string msg):base(msg) { }
    }

    try
    {
        double r = double.Parse(txt_re.Text);
    }
    catch // (FormatException eF)
    {
        MessageBox.Show("Format Error!");
        MessageBox.Show(eF.Message)
    }
    catch (PowerException eN){ MessageBox.Show(eN,.Message); }
}