using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _106_Quiz6;
using System.Collections;

namespace _106_Quiz6
{
    public partial class Form1 : Form
    {
        private Shape[] arr = new Shape[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddShape_Click(object sender, EventArgs e)
        {
            string shape = cboxShape.SelectedItem.ToString();
            switch (shape)
            {
                case "球":
                    arr[Shape.Amount] = new Ball(Double.Parse(txtPara1.Text), Double.Parse(txtDensity.Text));
                    break;
                case "立方體":
                    arr[Shape.Amount] = new Cube(Double.Parse(txtPara1.Text), Double.Parse(txtDensity.Text));
                    break;
                case "圓柱體":
                    arr[Shape.Amount] = new Cylinder(Double.Parse(txtPara1.Text), Double.Parse(txtPara2.Text),Double.Parse(txtDensity.Text));
                    break;
                case "金字塔":
                    arr[Shape.Amount] = new Pyramid(Double.Parse(txtPara1.Text), Double.Parse(txtPara2.Text),Double.Parse(txtDensity.Text));
                    break;
                default:
                    break;
            }
            txtAmountOfShape.Text = Shape.Amount.ToString();
            txtBallAmount.Text = Ball.Amount.ToString();
            txtCubeAmount.Text = Cube.Amount.ToString();
            txtCylinderAmount.Text = Cylinder.Amount.ToString();
            txtPyramidAmount.Text = Pyramid.Amount.ToString();
            ShowAllInfo();
        }

        private void ShowAllInfo()
        {
            string info = "";
            for (int i = 0; i < Shape.Amount; i++)
                info += (arr[i].ShapeProperty() + "\r\n");
            txtMessage.Text = info;
        }

        private void cboxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            string shape = cboxShape.SelectedItem.ToString();
            switch (shape)
            {
                case "球":
                    lblPara1.Text = "半徑";
                    lblPara2.Visible= false;
                    txtPara2.Visible = false;
                    break;
                case "立方體":
                    lblPara1.Text = "邊長";
                    lblPara2.Visible = false;
                    txtPara2.Visible = false;
                    break;
                case "圓柱體":
                    lblPara1.Text = "半徑";
                    lblPara2.Visible = true;
                    lblPara2.Text = "高";
                    txtPara2.Visible = true;
                    break;
                case "金字塔":
                    lblPara1.Text = "邊長";
                    lblPara2.Visible = true;
                    lblPara2.Text = "高";
                    txtPara2.Visible = true;
                    break;
                default:
                    break;

            }

        }

        private void cBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            string material = cBoxMaterial.SelectedItem.ToString();
            double density;
            bool canModified = false;
            switch (material)
            {
                case "鋁":
                    density = 2.7; 
                    break;
                case "鐵":
                    density = 7.87;
                    break;
                case "鉛":
                    density = 11.3;
                    break;
               
                default:
                    density = 0;
                    canModified = true;
                    break;
            }
            txtDensity.Text = density.ToString();
            if (!canModified)
                txtDensity.Enabled = false;
        }

        private void btn_FindHeaviestShape_Click(object sender, EventArgs e)
        {
            string info = "";
            double maxWeight = 0;
            int index = 0;
            while (arr[index]!=null)
            {
                if(arr[index].Weight() > maxWeight)
                {
                    maxWeight = arr[index].Weight();
                    info = arr[index].ShapeProperty();
                }
                index++;
            }
            txt_ShowHeaviestShape.Text = info;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
