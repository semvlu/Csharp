using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz6
{
    public partial class Form1 : Form
    {
        List<Ball> b = new List<Ball>();
        List<Cube> c = new List<Cube>();
        List<Cylinder> cy = new List<Cylinder>();
        List<Pyramid> p = new List<Pyramid>();
        static string s = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            switch(cbox_shape.SelectedIndex)
            {
                case 0: // Ball
                    b.Add(new Ball(double.Parse(txt_den.Text), double.Parse(txt_dia.Text)));
                    txt_msg.AppendText("Ball" + "\t" + b.Last().Dia +"\t\t" + b.Last().Den +"\t"+ b.Last().velo() +"\t"+ b.Last().mass() + Environment.NewLine);
                    break;
                case 1: // Cube
                    c.Add(new Cube(double.Parse(txt_den.Text), double.Parse(txt_side.Text)));
                    txt_msg.AppendText("Cube" + "\t" + c.Last().Side + "\t\t" + c.Last().Den + "\t" + c.Last().velo() + "\t" + c.Last().mass() + Environment.NewLine);
                    break;
                case 2: // Cylinder
                    cy.Add(new Cylinder(double.Parse(txt_den.Text), double.Parse(txt_dia.Text), double.Parse(txt_hei.Text)));
                    txt_msg.AppendText("Cylinder" + "\t" + cy.Last().Dia + "\t" + cy.Last().Hei + "\t" + cy.Last().Den +"\t" +cy.Last().velo() + "\t" +
                         cy.Last().mass() + Environment.NewLine);
                    break;
                case 3: // Pyramid
                    p.Add(new Pyramid(double.Parse(txt_den.Text), double.Parse(txt_side.Text), double.Parse(txt_hei.Text)));
                    txt_msg.AppendText("Pyramid" + "\t" + p.Last().Side + "\t" + p.Last().Hei + "\t" +p.Last().Den +"\t"+ p.Last().velo() + "\t" +
                        p.Last().mass() + Environment.NewLine);
                    break;
            }
            txt_ball.Text = Ball.Amt.ToString();
            txt_cube.Text = Cube.Amt.ToString();
            txt_cyl.Text = Cylinder.Amt.ToString();
            txt_pyr.Text = Pyramid.Amt.ToString();
            txt_amt.Text = Shape.Amt.ToString();
        }

        private void cbox_mat_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbox_mat.SelectedIndex)
            {
                case 0: // alu
                    txt_den.Text = 2.7.ToString();
                    break;
                case 1: // iron
                    txt_den.Text = 7.87.ToString();
                    break;
                case 2: // lead
                    txt_den.Text = 11.3.ToString();
                    break;
            }
        }

        private void cbox_shape_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbox_shape.SelectedIndex)
            {
                case 0: // ball
                    lbl_dia.Visible = true;
                    txt_dia.Visible = true;
                    lbl_hei.Visible = false;
                    txt_hei.Visible = false;
                    lbl_side.Visible = false;
                    txt_side.Visible = false;
                    break;
                case 1: // cube
                    lbl_side.Visible = true;
                    txt_side.Visible = true;
                    lbl_hei.Visible = false;
                    txt_hei.Visible = false;
                    lbl_dia.Visible = false;
                    txt_dia.Visible = false;
                    break;
                case 2: // cylinder
                    lbl_dia.Visible = true;
                    txt_dia.Visible = true;
                    lbl_hei.Visible = true;
                    txt_hei.Visible = true;
                    lbl_side.Visible = false;
                    txt_side.Visible = false;
                    break;
                case 3: // pyramid
                    lbl_side.Visible = true;
                    txt_side.Visible = true;
                    lbl_hei.Visible = true;
                    txt_hei.Visible = true;
                    lbl_dia.Visible = false;
                    txt_dia.Visible = false;
                    break;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



    }
}
