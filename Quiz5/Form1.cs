using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Quiz5
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void exp(object sender, EventArgs e)
        {
            string s = "";
            Triangle t = new Triangle();
            t.CreatePoints();
            t.ptArr[0].xCoord = double.Parse(txt_x1.Text);
            t.ptArr[0].yCoord = double.Parse(txt_y1.Text);
            t.ptArr[1].xCoord = double.Parse(txt_x2.Text);
            t.ptArr[1].yCoord = double.Parse(txt_y2.Text);
            t.ptArr[2].xCoord = double.Parse(txt_x3.Text);
            t.ptArr[2].yCoord = double.Parse(txt_y3.Text);

            if (t.isValid())
            {
                if (cbox_area.Checked)
                    s += "Area=" + t.Area().ToString() + "\n";
                if (cbox_peri.Checked)
                    s += "Perimeter=" + t.Perimeter().ToString() + "\n";
                if (cbox_type.Checked)
                {
                    switch (t.ShapeType())
                    {
                        case 1:
                            s += "本三角形為直角三角形\n";
                            break;
                        case 2:
                            s += "本三角形為銳角三角形\n";
                            break;
                        case 3:
                            s += "本三角形為鈍角三角形\n";
                            break;
                        default:
                            break;
                    }
                }
            }
            else
                s += "此三點無法形成三角形\n";
            txt_exp.Text = s;
        }
    }
}
