using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _106_Quiz4;

namespace _106_Quiz5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            string message="";
            Triangle tri = new Triangle();
            tri.CreatePoints();
            tri.ptArr[0].xCoord = Double.Parse(txtPoint1X.Text);
            tri.ptArr[0].yCoord = Double.Parse(txtPoint1Y.Text);
            tri.ptArr[1].xCoord = Double.Parse(txtPoint2X.Text);
            tri.ptArr[1].yCoord = Double.Parse(txtPoint2Y.Text);
            tri.ptArr[2].xCoord = Double.Parse(txtPoint3X.Text);
            tri.ptArr[2].yCoord = Double.Parse(txtPoint3Y.Text);
            if (tri.isValid())
            {
                if (cbx_Area.Checked)
                    message += ("Area=" + tri.Area().ToString() + Environment.NewLine);
                if (cbx_Perimeter.Checked)
                    message += ("Perimeter=" + tri.Perimeter().ToString() + Environment.NewLine);
                if(cbx_ShapeType.Checked)
                {
                    switch (tri.ShapeType())
                    {

                        case 1:
                            message += "本三角形為直角三角形";
                            break;
                        case 2:
                            message += "本三角形為銳角三角形";
                            break;
                        case 3:
                            message += "本三角形為鈍角三角形";
                            break;
                        default:
                            message += "程式有錯";
                            break;
                    }
                }
            }
            else
            {
                message += "此三點無法形成三角形";
            }
            txt_Display.Text = message;

        }
    }
}
