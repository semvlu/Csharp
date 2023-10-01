namespace Quiz5
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
            this.lbl_pt1 = new System.Windows.Forms.Label();
            this.lbl_pt2 = new System.Windows.Forms.Label();
            this.lbl_pt3 = new System.Windows.Forms.Label();
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.txt_x1 = new System.Windows.Forms.TextBox();
            this.txt_x2 = new System.Windows.Forms.TextBox();
            this.txt_y1 = new System.Windows.Forms.TextBox();
            this.txt_y2 = new System.Windows.Forms.TextBox();
            this.txt_x3 = new System.Windows.Forms.TextBox();
            this.txt_y3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbox_area = new System.Windows.Forms.CheckBox();
            this.cbox_peri = new System.Windows.Forms.CheckBox();
            this.cbox_type = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_cal = new System.Windows.Forms.Button();
            this.txt_exp = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_y3);
            this.groupBox1.Controls.Add(this.txt_x3);
            this.groupBox1.Controls.Add(this.txt_y2);
            this.groupBox1.Controls.Add(this.txt_y1);
            this.groupBox1.Controls.Add(this.txt_x2);
            this.groupBox1.Controls.Add(this.txt_x1);
            this.groupBox1.Controls.Add(this.lbl_y);
            this.groupBox1.Controls.Add(this.lbl_x);
            this.groupBox1.Controls.Add(this.lbl_pt3);
            this.groupBox1.Controls.Add(this.lbl_pt2);
            this.groupBox1.Controls.Add(this.lbl_pt1);
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "座標輸入";
            // 
            // lbl_pt1
            // 
            this.lbl_pt1.AutoSize = true;
            this.lbl_pt1.Location = new System.Drawing.Point(20, 40);
            this.lbl_pt1.Name = "lbl_pt1";
            this.lbl_pt1.Size = new System.Drawing.Size(35, 12);
            this.lbl_pt1.TabIndex = 0;
            this.lbl_pt1.Text = "Point1";
            // 
            // lbl_pt2
            // 
            this.lbl_pt2.AutoSize = true;
            this.lbl_pt2.Location = new System.Drawing.Point(20, 78);
            this.lbl_pt2.Name = "lbl_pt2";
            this.lbl_pt2.Size = new System.Drawing.Size(35, 12);
            this.lbl_pt2.TabIndex = 1;
            this.lbl_pt2.Text = "Point2";
            // 
            // lbl_pt3
            // 
            this.lbl_pt3.AutoSize = true;
            this.lbl_pt3.Location = new System.Drawing.Point(20, 113);
            this.lbl_pt3.Name = "lbl_pt3";
            this.lbl_pt3.Size = new System.Drawing.Size(35, 12);
            this.lbl_pt3.TabIndex = 2;
            this.lbl_pt3.Text = "Point3";
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Location = new System.Drawing.Point(143, 18);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(13, 12);
            this.lbl_x.TabIndex = 3;
            this.lbl_x.Text = "X";
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Location = new System.Drawing.Point(296, 18);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(13, 12);
            this.lbl_y.TabIndex = 4;
            this.lbl_y.Text = "Y";
            // 
            // txt_x1
            // 
            this.txt_x1.Location = new System.Drawing.Point(97, 37);
            this.txt_x1.Name = "txt_x1";
            this.txt_x1.Size = new System.Drawing.Size(100, 22);
            this.txt_x1.TabIndex = 5;
            // 
            // txt_x2
            // 
            this.txt_x2.Location = new System.Drawing.Point(97, 75);
            this.txt_x2.Name = "txt_x2";
            this.txt_x2.Size = new System.Drawing.Size(100, 22);
            this.txt_x2.TabIndex = 6;
            // 
            // txt_y1
            // 
            this.txt_y1.Location = new System.Drawing.Point(261, 37);
            this.txt_y1.Name = "txt_y1";
            this.txt_y1.Size = new System.Drawing.Size(100, 22);
            this.txt_y1.TabIndex = 7;
            // 
            // txt_y2
            // 
            this.txt_y2.Location = new System.Drawing.Point(261, 75);
            this.txt_y2.Name = "txt_y2";
            this.txt_y2.Size = new System.Drawing.Size(100, 22);
            this.txt_y2.TabIndex = 8;
            // 
            // txt_x3
            // 
            this.txt_x3.Location = new System.Drawing.Point(97, 110);
            this.txt_x3.Name = "txt_x3";
            this.txt_x3.Size = new System.Drawing.Size(100, 22);
            this.txt_x3.TabIndex = 9;
            // 
            // txt_y3
            // 
            this.txt_y3.Location = new System.Drawing.Point(261, 110);
            this.txt_y3.Name = "txt_y3";
            this.txt_y3.Size = new System.Drawing.Size(100, 22);
            this.txt_y3.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbox_type);
            this.groupBox2.Controls.Add(this.cbox_peri);
            this.groupBox2.Controls.Add(this.cbox_area);
            this.groupBox2.Location = new System.Drawing.Point(22, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 60);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "選項";
            // 
            // cbox_area
            // 
            this.cbox_area.AutoSize = true;
            this.cbox_area.Location = new System.Drawing.Point(46, 22);
            this.cbox_area.Name = "cbox_area";
            this.cbox_area.Size = new System.Drawing.Size(72, 16);
            this.cbox_area.TabIndex = 0;
            this.cbox_area.Text = "計算面積";
            this.cbox_area.UseVisualStyleBackColor = true;
            // 
            // cbox_peri
            // 
            this.cbox_peri.AutoSize = true;
            this.cbox_peri.Location = new System.Drawing.Point(145, 21);
            this.cbox_peri.Name = "cbox_peri";
            this.cbox_peri.Size = new System.Drawing.Size(72, 16);
            this.cbox_peri.TabIndex = 1;
            this.cbox_peri.Text = "計算周長";
            this.cbox_peri.UseVisualStyleBackColor = true;
            // 
            // cbox_type
            // 
            this.cbox_type.AutoSize = true;
            this.cbox_type.Location = new System.Drawing.Point(253, 21);
            this.cbox_type.Name = "cbox_type";
            this.cbox_type.Size = new System.Drawing.Size(108, 16);
            this.cbox_type.TabIndex = 2;
            this.cbox_type.Text = "輸出三角形類別";
            this.cbox_type.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_exp);
            this.groupBox3.Controls.Add(this.btn_cal);
            this.groupBox3.Location = new System.Drawing.Point(22, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 365);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "功能鍵與輸出";
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(339, 21);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(75, 23);
            this.btn_cal.TabIndex = 0;
            this.btn_cal.Text = "計算";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.exp);
            // 
            // txt_exp
            // 
            this.txt_exp.Location = new System.Drawing.Point(10, 51);
            this.txt_exp.Multiline = true;
            this.txt_exp.Name = "txt_exp";
            this.txt_exp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_exp.Size = new System.Drawing.Size(396, 300);
            this.txt_exp.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 877);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_pt2;
        private System.Windows.Forms.Label lbl_pt1;
        private System.Windows.Forms.Label lbl_pt3;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.TextBox txt_y3;
        private System.Windows.Forms.TextBox txt_x3;
        private System.Windows.Forms.TextBox txt_y2;
        private System.Windows.Forms.TextBox txt_y1;
        private System.Windows.Forms.TextBox txt_x2;
        private System.Windows.Forms.TextBox txt_x1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbox_type;
        private System.Windows.Forms.CheckBox cbox_peri;
        private System.Windows.Forms.CheckBox cbox_area;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_exp;
        private System.Windows.Forms.Button btn_cal;
    }
}

