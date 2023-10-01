namespace Quiz6
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Material = new System.Windows.Forms.GroupBox();
            this.txt_den = new System.Windows.Forms.TextBox();
            this.lbl_den = new System.Windows.Forms.Label();
            this.cbox_mat = new System.Windows.Forms.ComboBox();
            this.lbl_mat = new System.Windows.Forms.Label();
            this.Geometry = new System.Windows.Forms.GroupBox();
            this.txt_dia = new System.Windows.Forms.TextBox();
            this.lbl_hei = new System.Windows.Forms.Label();
            this.lbl_dia = new System.Windows.Forms.Label();
            this.txt_side = new System.Windows.Forms.TextBox();
            this.lbl_side = new System.Windows.Forms.Label();
            this.lbl_shape = new System.Windows.Forms.Label();
            this.cbox_shape = new System.Windows.Forms.ComboBox();
            this.AmountOfShape = new System.Windows.Forms.GroupBox();
            this.lbl_pyr = new System.Windows.Forms.Label();
            this.txt_pyr = new System.Windows.Forms.TextBox();
            this.lbl_cyl = new System.Windows.Forms.Label();
            this.txt_cyl = new System.Windows.Forms.TextBox();
            this.lbl_cube = new System.Windows.Forms.Label();
            this.txt_cube = new System.Windows.Forms.TextBox();
            this.lbl_ball = new System.Windows.Forms.Label();
            this.txt_ball = new System.Windows.Forms.TextBox();
            this.lbl_amt = new System.Windows.Forms.Label();
            this.txt_amt = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.Msg = new System.Windows.Forms.GroupBox();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.txt_hei = new System.Windows.Forms.TextBox();
            this.Material.SuspendLayout();
            this.Geometry.SuspendLayout();
            this.AmountOfShape.SuspendLayout();
            this.Msg.SuspendLayout();
            this.SuspendLayout();
            // 
            // Material
            // 
            this.Material.Controls.Add(this.txt_den);
            this.Material.Controls.Add(this.lbl_den);
            this.Material.Controls.Add(this.cbox_mat);
            this.Material.Controls.Add(this.lbl_mat);
            this.Material.Location = new System.Drawing.Point(38, 30);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(240, 100);
            this.Material.TabIndex = 0;
            this.Material.TabStop = false;
            this.Material.Text = "Material";
            // 
            // txt_den
            // 
            this.txt_den.Location = new System.Drawing.Point(71, 58);
            this.txt_den.Name = "txt_den";
            this.txt_den.Size = new System.Drawing.Size(121, 22);
            this.txt_den.TabIndex = 0;
            // 
            // lbl_den
            // 
            this.lbl_den.AutoSize = true;
            this.lbl_den.Location = new System.Drawing.Point(32, 61);
            this.lbl_den.Name = "lbl_den";
            this.lbl_den.Size = new System.Drawing.Size(29, 12);
            this.lbl_den.TabIndex = 6;
            this.lbl_den.Text = "密度";
            // 
            // cbox_mat
            // 
            this.cbox_mat.FormattingEnabled = true;
            this.cbox_mat.Items.AddRange(new object[] {
            "鋁",
            "鐵",
            "鉛"});
            this.cbox_mat.Location = new System.Drawing.Point(71, 32);
            this.cbox_mat.Name = "cbox_mat";
            this.cbox_mat.Size = new System.Drawing.Size(121, 20);
            this.cbox_mat.TabIndex = 4;
            this.cbox_mat.SelectedIndexChanged += new System.EventHandler(this.cbox_mat_SelectedIndexChanged);
            // 
            // lbl_mat
            // 
            this.lbl_mat.AutoSize = true;
            this.lbl_mat.Location = new System.Drawing.Point(32, 35);
            this.lbl_mat.Name = "lbl_mat";
            this.lbl_mat.Size = new System.Drawing.Size(29, 12);
            this.lbl_mat.TabIndex = 4;
            this.lbl_mat.Text = "材質";
            // 
            // Geometry
            // 
            this.Geometry.Controls.Add(this.txt_dia);
            this.Geometry.Controls.Add(this.lbl_hei);
            this.Geometry.Controls.Add(this.lbl_dia);
            this.Geometry.Controls.Add(this.txt_side);
            this.Geometry.Controls.Add(this.lbl_side);
            this.Geometry.Controls.Add(this.lbl_shape);
            this.Geometry.Controls.Add(this.cbox_shape);
            this.Geometry.Location = new System.Drawing.Point(38, 156);
            this.Geometry.Name = "Geometry";
            this.Geometry.Size = new System.Drawing.Size(240, 168);
            this.Geometry.TabIndex = 1;
            this.Geometry.TabStop = false;
            this.Geometry.Text = "Geometry";
            // 
            // txt_dia
            // 
            this.txt_dia.Location = new System.Drawing.Point(71, 72);
            this.txt_dia.Name = "txt_dia";
            this.txt_dia.Size = new System.Drawing.Size(121, 22);
            this.txt_dia.TabIndex = 7;
            // 
            // lbl_hei
            // 
            this.lbl_hei.AutoSize = true;
            this.lbl_hei.Location = new System.Drawing.Point(44, 131);
            this.lbl_hei.Name = "lbl_hei";
            this.lbl_hei.Size = new System.Drawing.Size(17, 12);
            this.lbl_hei.TabIndex = 12;
            this.lbl_hei.Text = "高";
            // 
            // lbl_dia
            // 
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.Location = new System.Drawing.Point(32, 75);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(29, 12);
            this.lbl_dia.TabIndex = 10;
            this.lbl_dia.Text = "半徑";
            // 
            // txt_side
            // 
            this.txt_side.Location = new System.Drawing.Point(69, 100);
            this.txt_side.Name = "txt_side";
            this.txt_side.Size = new System.Drawing.Size(121, 22);
            this.txt_side.TabIndex = 11;
            // 
            // lbl_side
            // 
            this.lbl_side.AutoSize = true;
            this.lbl_side.Location = new System.Drawing.Point(32, 103);
            this.lbl_side.Name = "lbl_side";
            this.lbl_side.Size = new System.Drawing.Size(29, 12);
            this.lbl_side.TabIndex = 12;
            this.lbl_side.Text = "邊長";
            // 
            // lbl_shape
            // 
            this.lbl_shape.AutoSize = true;
            this.lbl_shape.Location = new System.Drawing.Point(32, 37);
            this.lbl_shape.Name = "lbl_shape";
            this.lbl_shape.Size = new System.Drawing.Size(29, 12);
            this.lbl_shape.TabIndex = 9;
            this.lbl_shape.Text = "形狀";
            // 
            // cbox_shape
            // 
            this.cbox_shape.FormattingEnabled = true;
            this.cbox_shape.Items.AddRange(new object[] {
            "球",
            "立方體",
            "圓柱體",
            "金字塔"});
            this.cbox_shape.Location = new System.Drawing.Point(71, 34);
            this.cbox_shape.Name = "cbox_shape";
            this.cbox_shape.Size = new System.Drawing.Size(121, 20);
            this.cbox_shape.TabIndex = 8;
            this.cbox_shape.SelectedIndexChanged += new System.EventHandler(this.cbox_shape_SelectedIndexChanged);
            // 
            // AmountOfShape
            // 
            this.AmountOfShape.Controls.Add(this.lbl_pyr);
            this.AmountOfShape.Controls.Add(this.txt_pyr);
            this.AmountOfShape.Controls.Add(this.lbl_cyl);
            this.AmountOfShape.Controls.Add(this.txt_cyl);
            this.AmountOfShape.Controls.Add(this.lbl_cube);
            this.AmountOfShape.Controls.Add(this.txt_cube);
            this.AmountOfShape.Controls.Add(this.lbl_ball);
            this.AmountOfShape.Controls.Add(this.txt_ball);
            this.AmountOfShape.Controls.Add(this.lbl_amt);
            this.AmountOfShape.Controls.Add(this.txt_amt);
            this.AmountOfShape.Controls.Add(this.btn_add);
            this.AmountOfShape.Location = new System.Drawing.Point(38, 330);
            this.AmountOfShape.Name = "AmountOfShape";
            this.AmountOfShape.Size = new System.Drawing.Size(240, 128);
            this.AmountOfShape.TabIndex = 2;
            this.AmountOfShape.TabStop = false;
            this.AmountOfShape.Text = "Amount of Shape";
            // 
            // lbl_pyr
            // 
            this.lbl_pyr.AutoSize = true;
            this.lbl_pyr.Location = new System.Drawing.Point(184, 69);
            this.lbl_pyr.Name = "lbl_pyr";
            this.lbl_pyr.Size = new System.Drawing.Size(41, 12);
            this.lbl_pyr.TabIndex = 19;
            this.lbl_pyr.Text = "金字塔";
            // 
            // txt_pyr
            // 
            this.txt_pyr.Location = new System.Drawing.Point(184, 84);
            this.txt_pyr.Name = "txt_pyr";
            this.txt_pyr.Size = new System.Drawing.Size(40, 22);
            this.txt_pyr.TabIndex = 18;
            // 
            // lbl_cyl
            // 
            this.lbl_cyl.AutoSize = true;
            this.lbl_cyl.Location = new System.Drawing.Point(128, 69);
            this.lbl_cyl.Name = "lbl_cyl";
            this.lbl_cyl.Size = new System.Drawing.Size(41, 12);
            this.lbl_cyl.TabIndex = 17;
            this.lbl_cyl.Text = "圓柱體";
            // 
            // txt_cyl
            // 
            this.txt_cyl.Location = new System.Drawing.Point(128, 84);
            this.txt_cyl.Name = "txt_cyl";
            this.txt_cyl.Size = new System.Drawing.Size(40, 22);
            this.txt_cyl.TabIndex = 16;
            // 
            // lbl_cube
            // 
            this.lbl_cube.AutoSize = true;
            this.lbl_cube.Location = new System.Drawing.Point(69, 69);
            this.lbl_cube.Name = "lbl_cube";
            this.lbl_cube.Size = new System.Drawing.Size(41, 12);
            this.lbl_cube.TabIndex = 15;
            this.lbl_cube.Text = "立方體";
            // 
            // txt_cube
            // 
            this.txt_cube.Location = new System.Drawing.Point(69, 84);
            this.txt_cube.Name = "txt_cube";
            this.txt_cube.Size = new System.Drawing.Size(40, 22);
            this.txt_cube.TabIndex = 14;
            // 
            // lbl_ball
            // 
            this.lbl_ball.AutoSize = true;
            this.lbl_ball.Location = new System.Drawing.Point(6, 69);
            this.lbl_ball.Name = "lbl_ball";
            this.lbl_ball.Size = new System.Drawing.Size(17, 12);
            this.lbl_ball.TabIndex = 13;
            this.lbl_ball.Text = "球";
            // 
            // txt_ball
            // 
            this.txt_ball.Location = new System.Drawing.Point(6, 84);
            this.txt_ball.Name = "txt_ball";
            this.txt_ball.Size = new System.Drawing.Size(40, 22);
            this.txt_ball.TabIndex = 12;
            // 
            // lbl_amt
            // 
            this.lbl_amt.AutoSize = true;
            this.lbl_amt.Location = new System.Drawing.Point(111, 17);
            this.lbl_amt.Name = "lbl_amt";
            this.lbl_amt.Size = new System.Drawing.Size(29, 12);
            this.lbl_amt.TabIndex = 11;
            this.lbl_amt.Text = "總數";
            // 
            // txt_amt
            // 
            this.txt_amt.Location = new System.Drawing.Point(113, 32);
            this.txt_amt.Name = "txt_amt";
            this.txt_amt.Size = new System.Drawing.Size(121, 22);
            this.txt_amt.TabIndex = 8;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(6, 32);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Msg
            // 
            this.Msg.Controls.Add(this.txt_msg);
            this.Msg.Location = new System.Drawing.Point(312, 29);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(448, 380);
            this.Msg.TabIndex = 3;
            this.Msg.TabStop = false;
            this.Msg.Text = "Message";
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(17, 24);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(420, 333);
            this.txt_msg.TabIndex = 0;
            // 
            // txt_hei
            // 
            this.txt_hei.Location = new System.Drawing.Point(109, 284);
            this.txt_hei.Name = "txt_hei";
            this.txt_hei.Size = new System.Drawing.Size(121, 22);
            this.txt_hei.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.txt_hei);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.AmountOfShape);
            this.Controls.Add(this.Geometry);
            this.Controls.Add(this.Material);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Material.ResumeLayout(false);
            this.Material.PerformLayout();
            this.Geometry.ResumeLayout(false);
            this.Geometry.PerformLayout();
            this.AmountOfShape.ResumeLayout(false);
            this.AmountOfShape.PerformLayout();
            this.Msg.ResumeLayout(false);
            this.Msg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Material;
        private System.Windows.Forms.GroupBox Geometry;
        private System.Windows.Forms.GroupBox AmountOfShape;
        private System.Windows.Forms.GroupBox Msg;
        private System.Windows.Forms.ComboBox cbox_mat;
        private System.Windows.Forms.Label lbl_mat;
        private System.Windows.Forms.Label lbl_den;
        private System.Windows.Forms.TextBox txt_den;
        private System.Windows.Forms.TextBox txt_dia;
        private System.Windows.Forms.Label lbl_dia;
        private System.Windows.Forms.Label lbl_shape;
        private System.Windows.Forms.ComboBox cbox_shape;
        private System.Windows.Forms.Label lbl_amt;
        private System.Windows.Forms.TextBox txt_amt;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_pyr;
        private System.Windows.Forms.TextBox txt_pyr;
        private System.Windows.Forms.Label lbl_cyl;
        private System.Windows.Forms.TextBox txt_cyl;
        private System.Windows.Forms.Label lbl_cube;
        private System.Windows.Forms.TextBox txt_cube;
        private System.Windows.Forms.Label lbl_ball;
        private System.Windows.Forms.TextBox txt_ball;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.TextBox txt_side;
        private System.Windows.Forms.Label lbl_side;
        private System.Windows.Forms.TextBox txt_hei;
        private System.Windows.Forms.Label lbl_hei;
    }
}

