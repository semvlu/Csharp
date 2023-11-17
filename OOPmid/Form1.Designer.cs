namespace WindowsFormsApp2
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_den = new System.Windows.Forms.TextBox();
            this.cbox_mat = new System.Windows.Forms.ComboBox();
            this.gbx_shape = new System.Windows.Forms.GroupBox();
            this.lbl_prm2 = new System.Windows.Forms.Label();
            this.lbl_prm1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_prm2 = new System.Windows.Forms.TextBox();
            this.txt_prm1 = new System.Windows.Forms.TextBox();
            this.cbox_shape = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_pyr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cyl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cube = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ball = new System.Windows.Forms.TextBox();
            this.lbl_ball = new System.Windows.Forms.Label();
            this.txt_amt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_roll = new System.Windows.Forms.TextBox();
            this.btn_roll = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.txt_sort = new System.Windows.Forms.TextBox();
            this.rbt_dsc = new System.Windows.Forms.RadioButton();
            this.cbox_sort = new System.Windows.Forms.ComboBox();
            this.rbt_asc = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbx_shape.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_den);
            this.groupBox1.Controls.Add(this.cbox_mat);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(274, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "密度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "材質";
            // 
            // txt_den
            // 
            this.txt_den.Location = new System.Drawing.Point(134, 59);
            this.txt_den.Margin = new System.Windows.Forms.Padding(2);
            this.txt_den.Name = "txt_den";
            this.txt_den.Size = new System.Drawing.Size(76, 22);
            this.txt_den.TabIndex = 1;
            // 
            // cbox_mat
            // 
            this.cbox_mat.FormattingEnabled = true;
            this.cbox_mat.Items.AddRange(new object[] {
            "鋁",
            "鐵",
            "鉛"});
            this.cbox_mat.Location = new System.Drawing.Point(134, 19);
            this.cbox_mat.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_mat.Name = "cbox_mat";
            this.cbox_mat.Size = new System.Drawing.Size(92, 20);
            this.cbox_mat.TabIndex = 0;
            this.cbox_mat.SelectedIndexChanged += new System.EventHandler(this.cbox_mat_SelectedIndexChanged);
            // 
            // gbx_shape
            // 
            this.gbx_shape.Controls.Add(this.lbl_prm2);
            this.gbx_shape.Controls.Add(this.lbl_prm1);
            this.gbx_shape.Controls.Add(this.label8);
            this.gbx_shape.Controls.Add(this.txt_prm2);
            this.gbx_shape.Controls.Add(this.txt_prm1);
            this.gbx_shape.Controls.Add(this.cbox_shape);
            this.gbx_shape.Location = new System.Drawing.Point(9, 108);
            this.gbx_shape.Margin = new System.Windows.Forms.Padding(2);
            this.gbx_shape.Name = "gbx_shape";
            this.gbx_shape.Padding = new System.Windows.Forms.Padding(2);
            this.gbx_shape.Size = new System.Drawing.Size(274, 111);
            this.gbx_shape.TabIndex = 1;
            this.gbx_shape.TabStop = false;
            this.gbx_shape.Text = "Shape";
            // 
            // lbl_prm2
            // 
            this.lbl_prm2.AutoSize = true;
            this.lbl_prm2.Location = new System.Drawing.Point(41, 78);
            this.lbl_prm2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_prm2.Name = "lbl_prm2";
            this.lbl_prm2.Size = new System.Drawing.Size(35, 12);
            this.lbl_prm2.TabIndex = 6;
            this.lbl_prm2.Text = "參數2";
            // 
            // lbl_prm1
            // 
            this.lbl_prm1.AutoSize = true;
            this.lbl_prm1.Location = new System.Drawing.Point(41, 50);
            this.lbl_prm1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_prm1.Name = "lbl_prm1";
            this.lbl_prm1.Size = new System.Drawing.Size(35, 12);
            this.lbl_prm1.TabIndex = 5;
            this.lbl_prm1.Text = "參數1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "形狀";
            // 
            // txt_prm2
            // 
            this.txt_prm2.Location = new System.Drawing.Point(134, 75);
            this.txt_prm2.Margin = new System.Windows.Forms.Padding(2);
            this.txt_prm2.Name = "txt_prm2";
            this.txt_prm2.Size = new System.Drawing.Size(76, 22);
            this.txt_prm2.TabIndex = 4;
            // 
            // txt_prm1
            // 
            this.txt_prm1.Location = new System.Drawing.Point(134, 42);
            this.txt_prm1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_prm1.Name = "txt_prm1";
            this.txt_prm1.Size = new System.Drawing.Size(76, 22);
            this.txt_prm1.TabIndex = 3;
            // 
            // cbox_shape
            // 
            this.cbox_shape.FormattingEnabled = true;
            this.cbox_shape.Items.AddRange(new object[] {
            "球",
            "立方體",
            "圓柱體",
            "金字塔"});
            this.cbox_shape.Location = new System.Drawing.Point(134, 19);
            this.cbox_shape.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_shape.Name = "cbox_shape";
            this.cbox_shape.Size = new System.Drawing.Size(92, 20);
            this.cbox_shape.TabIndex = 2;
            this.cbox_shape.SelectedIndexChanged += new System.EventHandler(this.cbox_shape_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_pyr);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_cyl);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_cube);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_ball);
            this.groupBox3.Controls.Add(this.lbl_ball);
            this.groupBox3.Controls.Add(this.txt_amt);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Location = new System.Drawing.Point(9, 224);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(274, 142);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Amount of Shape";
            // 
            // txt_pyr
            // 
            this.txt_pyr.Location = new System.Drawing.Point(201, 91);
            this.txt_pyr.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pyr.Name = "txt_pyr";
            this.txt_pyr.Size = new System.Drawing.Size(48, 22);
            this.txt_pyr.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "金字塔";
            // 
            // txt_cyl
            // 
            this.txt_cyl.Location = new System.Drawing.Point(138, 91);
            this.txt_cyl.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cyl.Name = "txt_cyl";
            this.txt_cyl.Size = new System.Drawing.Size(48, 22);
            this.txt_cyl.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "圓柱體";
            // 
            // txt_cube
            // 
            this.txt_cube.Location = new System.Drawing.Point(70, 91);
            this.txt_cube.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cube.Name = "txt_cube";
            this.txt_cube.Size = new System.Drawing.Size(48, 22);
            this.txt_cube.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "立方體";
            // 
            // txt_ball
            // 
            this.txt_ball.Location = new System.Drawing.Point(5, 91);
            this.txt_ball.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ball.Name = "txt_ball";
            this.txt_ball.Size = new System.Drawing.Size(48, 22);
            this.txt_ball.TabIndex = 4;
            // 
            // lbl_ball
            // 
            this.lbl_ball.AutoSize = true;
            this.lbl_ball.Location = new System.Drawing.Point(3, 76);
            this.lbl_ball.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ball.Name = "lbl_ball";
            this.lbl_ball.Size = new System.Drawing.Size(17, 12);
            this.lbl_ball.TabIndex = 3;
            this.lbl_ball.Text = "球";
            // 
            // txt_amt
            // 
            this.txt_amt.Location = new System.Drawing.Point(110, 27);
            this.txt_amt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_amt.Name = "txt_amt";
            this.txt_amt.Size = new System.Drawing.Size(76, 22);
            this.txt_amt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "總數";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(5, 20);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(56, 18);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_msg);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(297, 10);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(421, 414);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Message";
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(9, 19);
            this.txt_msg.Margin = new System.Windows.Forms.Padding(2);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(408, 142);
            this.txt_msg.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_roll);
            this.groupBox5.Controls.Add(this.btn_roll);
            this.groupBox5.Controls.Add(this.btn_sort);
            this.groupBox5.Controls.Add(this.txt_sort);
            this.groupBox5.Controls.Add(this.rbt_dsc);
            this.groupBox5.Controls.Add(this.cbox_sort);
            this.groupBox5.Controls.Add(this.rbt_asc);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(9, 165);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(412, 233);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sort";
            // 
            // txt_roll
            // 
            this.txt_roll.Location = new System.Drawing.Point(7, 157);
            this.txt_roll.Margin = new System.Windows.Forms.Padding(2);
            this.txt_roll.Multiline = true;
            this.txt_roll.Name = "txt_roll";
            this.txt_roll.Size = new System.Drawing.Size(402, 72);
            this.txt_roll.TabIndex = 7;
            // 
            // btn_roll
            // 
            this.btn_roll.Location = new System.Drawing.Point(7, 133);
            this.btn_roll.Margin = new System.Windows.Forms.Padding(2);
            this.btn_roll.Name = "btn_roll";
            this.btn_roll.Size = new System.Drawing.Size(64, 20);
            this.btn_roll.TabIndex = 6;
            this.btn_roll.Text = "滾球大賽";
            this.btn_roll.UseVisualStyleBackColor = true;
            this.btn_roll.Click += new System.EventHandler(this.btn_roll_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(315, 10);
            this.btn_sort.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(56, 27);
            this.btn_sort.TabIndex = 5;
            this.btn_sort.Text = "確認";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // txt_sort
            // 
            this.txt_sort.Location = new System.Drawing.Point(7, 41);
            this.txt_sort.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sort.Multiline = true;
            this.txt_sort.Name = "txt_sort";
            this.txt_sort.Size = new System.Drawing.Size(402, 87);
            this.txt_sort.TabIndex = 4;
            // 
            // rbt_dsc
            // 
            this.rbt_dsc.AutoSize = true;
            this.rbt_dsc.Location = new System.Drawing.Point(244, 15);
            this.rbt_dsc.Margin = new System.Windows.Forms.Padding(2);
            this.rbt_dsc.Name = "rbt_dsc";
            this.rbt_dsc.Size = new System.Drawing.Size(47, 16);
            this.rbt_dsc.TabIndex = 3;
            this.rbt_dsc.TabStop = true;
            this.rbt_dsc.Text = "遞減";
            this.rbt_dsc.UseVisualStyleBackColor = true;
            // 
            // cbox_sort
            // 
            this.cbox_sort.FormattingEnabled = true;
            this.cbox_sort.Items.AddRange(new object[] {
            "形狀",
            "材料",
            "體積",
            "重量"});
            this.cbox_sort.Location = new System.Drawing.Point(60, 13);
            this.cbox_sort.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_sort.Name = "cbox_sort";
            this.cbox_sort.Size = new System.Drawing.Size(92, 20);
            this.cbox_sort.TabIndex = 2;
            // 
            // rbt_asc
            // 
            this.rbt_asc.AutoSize = true;
            this.rbt_asc.Location = new System.Drawing.Point(163, 14);
            this.rbt_asc.Margin = new System.Windows.Forms.Padding(2);
            this.rbt_asc.Name = "rbt_asc";
            this.rbt_asc.Size = new System.Drawing.Size(47, 16);
            this.rbt_asc.TabIndex = 1;
            this.rbt_asc.TabStop = true;
            this.rbt_asc.Text = "遞增";
            this.rbt_asc.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "排序方式";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 459);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbx_shape);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbx_shape.ResumeLayout(false);
            this.gbx_shape.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbx_shape;
        private System.Windows.Forms.TextBox txt_prm1;
        private System.Windows.Forms.ComboBox cbox_shape;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_prm2;
        private System.Windows.Forms.TextBox txt_pyr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cyl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cube;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ball;
        private System.Windows.Forms.Label lbl_ball;
        private System.Windows.Forms.TextBox txt_amt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.TextBox txt_roll;
        private System.Windows.Forms.Button btn_roll;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.TextBox txt_sort;
        private System.Windows.Forms.RadioButton rbt_dsc;
        private System.Windows.Forms.ComboBox cbox_sort;
        private System.Windows.Forms.RadioButton rbt_asc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_prm2;
        private System.Windows.Forms.Label lbl_prm1;
        private System.Windows.Forms.Label label8;
    }
}

