namespace uB10933001_Mid
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Geometry = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_mat = new System.Windows.Forms.ComboBox();
            this.txt_den = new System.Windows.Forms.TextBox();
            this.lbl_shape = new System.Windows.Forms.Label();
            this.lbl_prm1 = new System.Windows.Forms.Label();
            this.lbl_prm2 = new System.Windows.Forms.Label();
            this.cbox_shape = new System.Windows.Forms.ComboBox();
            this.txt_prm1 = new System.Windows.Forms.TextBox();
            this.txt_prm2 = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_amt = new System.Windows.Forms.TextBox();
            this.txt_ball = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cube = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cyl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pyr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbox_sort = new System.Windows.Forms.ComboBox();
            this.rbt_asc = new System.Windows.Forms.RadioButton();
            this.rbt_dsc = new System.Windows.Forms.RadioButton();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_roll = new System.Windows.Forms.Button();
            this.txt_sort = new System.Windows.Forms.TextBox();
            this.txt_roll = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.Geometry.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_den);
            this.groupBox1.Controls.Add(this.cbox_mat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material";
            // 
            // Geometry
            // 
            this.Geometry.Controls.Add(this.txt_prm2);
            this.Geometry.Controls.Add(this.txt_prm1);
            this.Geometry.Controls.Add(this.cbox_shape);
            this.Geometry.Controls.Add(this.lbl_prm2);
            this.Geometry.Controls.Add(this.lbl_prm1);
            this.Geometry.Controls.Add(this.lbl_shape);
            this.Geometry.Location = new System.Drawing.Point(14, 218);
            this.Geometry.Name = "Geometry";
            this.Geometry.Size = new System.Drawing.Size(417, 179);
            this.Geometry.TabIndex = 1;
            this.Geometry.TabStop = false;
            this.Geometry.Text = "Geometry";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_pyr);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_cyl);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_cube);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_ball);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_amt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Location = new System.Drawing.Point(13, 403);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 179);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Amount of Shape";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_msg);
            this.groupBox4.Location = new System.Drawing.Point(451, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(700, 288);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Message";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_roll);
            this.groupBox5.Controls.Add(this.txt_sort);
            this.groupBox5.Controls.Add(this.btn_roll);
            this.groupBox5.Controls.Add(this.btn_sort);
            this.groupBox5.Controls.Add(this.rbt_dsc);
            this.groupBox5.Controls.Add(this.rbt_asc);
            this.groupBox5.Controls.Add(this.cbox_sort);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(451, 318);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(700, 314);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "材質";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密度";
            // 
            // cbox_mat
            // 
            this.cbox_mat.FormattingEnabled = true;
            this.cbox_mat.Items.AddRange(new object[] {
            "鋁",
            "鐵",
            "鉛"});
            this.cbox_mat.Location = new System.Drawing.Point(129, 48);
            this.cbox_mat.Name = "cbox_mat";
            this.cbox_mat.Size = new System.Drawing.Size(121, 23);
            this.cbox_mat.TabIndex = 2;
            this.cbox_mat.SelectedIndexChanged += new System.EventHandler(this.cbox_mat_SelectedIndexChanged);
            // 
            // txt_den
            // 
            this.txt_den.Location = new System.Drawing.Point(129, 91);
            this.txt_den.Name = "txt_den";
            this.txt_den.Size = new System.Drawing.Size(100, 25);
            this.txt_den.TabIndex = 3;
            // 
            // lbl_shape
            // 
            this.lbl_shape.AutoSize = true;
            this.lbl_shape.Location = new System.Drawing.Point(23, 37);
            this.lbl_shape.Name = "lbl_shape";
            this.lbl_shape.Size = new System.Drawing.Size(37, 15);
            this.lbl_shape.TabIndex = 4;
            this.lbl_shape.Text = "形狀";
            // 
            // lbl_prm1
            // 
            this.lbl_prm1.AutoSize = true;
            this.lbl_prm1.Location = new System.Drawing.Point(23, 68);
            this.lbl_prm1.Name = "lbl_prm1";
            this.lbl_prm1.Size = new System.Drawing.Size(44, 15);
            this.lbl_prm1.TabIndex = 5;
            this.lbl_prm1.Text = "參數1";
            // 
            // lbl_prm2
            // 
            this.lbl_prm2.AutoSize = true;
            this.lbl_prm2.Location = new System.Drawing.Point(23, 114);
            this.lbl_prm2.Name = "lbl_prm2";
            this.lbl_prm2.Size = new System.Drawing.Size(44, 15);
            this.lbl_prm2.TabIndex = 6;
            this.lbl_prm2.Text = "參數2";
            // 
            // cbox_shape
            // 
            this.cbox_shape.FormattingEnabled = true;
            this.cbox_shape.Items.AddRange(new object[] {
            "球",
            "立方體",
            "圓柱體",
            "金字塔"});
            this.cbox_shape.Location = new System.Drawing.Point(108, 29);
            this.cbox_shape.Name = "cbox_shape";
            this.cbox_shape.Size = new System.Drawing.Size(121, 23);
            this.cbox_shape.TabIndex = 4;
            this.cbox_shape.SelectedIndexChanged += new System.EventHandler(this.cbox_shape_SelectedIndexChanged);
            // 
            // txt_prm1
            // 
            this.txt_prm1.Location = new System.Drawing.Point(129, 68);
            this.txt_prm1.Name = "txt_prm1";
            this.txt_prm1.Size = new System.Drawing.Size(100, 25);
            this.txt_prm1.TabIndex = 7;
            // 
            // txt_prm2
            // 
            this.txt_prm2.Location = new System.Drawing.Point(129, 104);
            this.txt_prm2.Name = "txt_prm2";
            this.txt_prm2.Size = new System.Drawing.Size(100, 25);
            this.txt_prm2.TabIndex = 8;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(18, 25);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "總數";
            // 
            // txt_amt
            // 
            this.txt_amt.Location = new System.Drawing.Point(171, 31);
            this.txt_amt.Name = "txt_amt";
            this.txt_amt.Size = new System.Drawing.Size(100, 25);
            this.txt_amt.TabIndex = 9;
            // 
            // txt_ball
            // 
            this.txt_ball.Location = new System.Drawing.Point(18, 116);
            this.txt_ball.Name = "txt_ball";
            this.txt_ball.Size = new System.Drawing.Size(50, 25);
            this.txt_ball.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "球";
            // 
            // txt_cube
            // 
            this.txt_cube.Location = new System.Drawing.Point(109, 116);
            this.txt_cube.Name = "txt_cube";
            this.txt_cube.Size = new System.Drawing.Size(50, 25);
            this.txt_cube.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "立方體";
            // 
            // txt_cyl
            // 
            this.txt_cyl.Location = new System.Drawing.Point(180, 116);
            this.txt_cyl.Name = "txt_cyl";
            this.txt_cyl.Size = new System.Drawing.Size(50, 25);
            this.txt_cyl.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "圓柱體";
            // 
            // txt_pyr
            // 
            this.txt_pyr.Location = new System.Drawing.Point(263, 116);
            this.txt_pyr.Name = "txt_pyr";
            this.txt_pyr.Size = new System.Drawing.Size(50, 25);
            this.txt_pyr.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "金字塔";
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(6, 24);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(674, 258);
            this.txt_msg.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "排序方式";
            // 
            // cbox_sort
            // 
            this.cbox_sort.FormattingEnabled = true;
            this.cbox_sort.Items.AddRange(new object[] {
            "形狀",
            "材質",
            "體積",
            "重量"});
            this.cbox_sort.Location = new System.Drawing.Point(76, 21);
            this.cbox_sort.Name = "cbox_sort";
            this.cbox_sort.Size = new System.Drawing.Size(121, 23);
            this.cbox_sort.TabIndex = 9;
            // 
            // rbt_asc
            // 
            this.rbt_asc.AutoSize = true;
            this.rbt_asc.Location = new System.Drawing.Point(204, 21);
            this.rbt_asc.Name = "rbt_asc";
            this.rbt_asc.Size = new System.Drawing.Size(58, 19);
            this.rbt_asc.TabIndex = 19;
            this.rbt_asc.TabStop = true;
            this.rbt_asc.Text = "遞增";
            this.rbt_asc.UseVisualStyleBackColor = true;
            // 
            // rbt_dsc
            // 
            this.rbt_dsc.AutoSize = true;
            this.rbt_dsc.Location = new System.Drawing.Point(268, 21);
            this.rbt_dsc.Name = "rbt_dsc";
            this.rbt_dsc.Size = new System.Drawing.Size(58, 19);
            this.rbt_dsc.TabIndex = 20;
            this.rbt_dsc.TabStop = true;
            this.rbt_dsc.Text = "遞減";
            this.rbt_dsc.UseVisualStyleBackColor = true;
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(366, 16);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_sort.TabIndex = 21;
            this.btn_sort.Text = "確認";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_roll
            // 
            this.btn_roll.Location = new System.Drawing.Point(6, 179);
            this.btn_roll.Name = "btn_roll";
            this.btn_roll.Size = new System.Drawing.Size(98, 23);
            this.btn_roll.TabIndex = 22;
            this.btn_roll.Text = "滾球大賽";
            this.btn_roll.UseVisualStyleBackColor = true;
            this.btn_roll.Click += new System.EventHandler(this.btn_roll_Click);
            // 
            // txt_sort
            // 
            this.txt_sort.Location = new System.Drawing.Point(-1, 46);
            this.txt_sort.Multiline = true;
            this.txt_sort.Name = "txt_sort";
            this.txt_sort.Size = new System.Drawing.Size(674, 127);
            this.txt_sort.TabIndex = 19;
            // 
            // txt_roll
            // 
            this.txt_roll.Location = new System.Drawing.Point(-1, 208);
            this.txt_roll.Multiline = true;
            this.txt_roll.Name = "txt_roll";
            this.txt_roll.Size = new System.Drawing.Size(674, 100);
            this.txt_roll.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 644);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Geometry);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Geometry.ResumeLayout(false);
            this.Geometry.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_den;
        private System.Windows.Forms.ComboBox cbox_mat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Geometry;
        private System.Windows.Forms.TextBox txt_prm2;
        private System.Windows.Forms.TextBox txt_prm1;
        private System.Windows.Forms.ComboBox cbox_shape;
        private System.Windows.Forms.Label lbl_prm2;
        private System.Windows.Forms.Label lbl_prm1;
        private System.Windows.Forms.Label lbl_shape;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_pyr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cyl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cube;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ball;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_amt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_roll;
        private System.Windows.Forms.TextBox txt_sort;
        private System.Windows.Forms.Button btn_roll;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.RadioButton rbt_dsc;
        private System.Windows.Forms.RadioButton rbt_asc;
        private System.Windows.Forms.ComboBox cbox_sort;
        private System.Windows.Forms.Label label8;
    }
}

