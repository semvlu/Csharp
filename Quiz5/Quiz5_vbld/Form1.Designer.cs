namespace _106_Quiz5
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.lbl_Point1 = new System.Windows.Forms.Label();
            this.lbl_Point2 = new System.Windows.Forms.Label();
            this.lbl_Point3 = new System.Windows.Forms.Label();
            this.txtPoint1X = new System.Windows.Forms.TextBox();
            this.txtPoint1Y = new System.Windows.Forms.TextBox();
            this.txtPoint2X = new System.Windows.Forms.TextBox();
            this.txtPoint2Y = new System.Windows.Forms.TextBox();
            this.txtPoint3X = new System.Windows.Forms.TextBox();
            this.txtPoint3Y = new System.Windows.Forms.TextBox();
            this.lbl_XCoord = new System.Windows.Forms.Label();
            this.lbl_YCoord = new System.Windows.Forms.Label();
            this.grb_Input = new System.Windows.Forms.GroupBox();
            this.grb_Select = new System.Windows.Forms.GroupBox();
            this.cbx_Area = new System.Windows.Forms.CheckBox();
            this.cbx_Perimeter = new System.Windows.Forms.CheckBox();
            this.cbx_ShapeType = new System.Windows.Forms.CheckBox();
            this.grp_Output = new System.Windows.Forms.GroupBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.txt_Display = new System.Windows.Forms.TextBox();
            this.grb_Input.SuspendLayout();
            this.grb_Select.SuspendLayout();
            this.grp_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Point1
            // 
            this.lbl_Point1.AutoSize = true;
            this.lbl_Point1.Location = new System.Drawing.Point(28, 56);
            this.lbl_Point1.Name = "lbl_Point1";
            this.lbl_Point1.Size = new System.Drawing.Size(44, 15);
            this.lbl_Point1.TabIndex = 0;
            this.lbl_Point1.Text = "Point1";
            // 
            // lbl_Point2
            // 
            this.lbl_Point2.AutoSize = true;
            this.lbl_Point2.Location = new System.Drawing.Point(28, 101);
            this.lbl_Point2.Name = "lbl_Point2";
            this.lbl_Point2.Size = new System.Drawing.Size(44, 15);
            this.lbl_Point2.TabIndex = 1;
            this.lbl_Point2.Text = "Point2";
            // 
            // lbl_Point3
            // 
            this.lbl_Point3.AutoSize = true;
            this.lbl_Point3.Location = new System.Drawing.Point(28, 139);
            this.lbl_Point3.Name = "lbl_Point3";
            this.lbl_Point3.Size = new System.Drawing.Size(44, 15);
            this.lbl_Point3.TabIndex = 2;
            this.lbl_Point3.Text = "Point3";
            // 
            // txtPoint1X
            // 
            this.txtPoint1X.Location = new System.Drawing.Point(122, 46);
            this.txtPoint1X.Name = "txtPoint1X";
            this.txtPoint1X.Size = new System.Drawing.Size(100, 25);
            this.txtPoint1X.TabIndex = 3;
            // 
            // txtPoint1Y
            // 
            this.txtPoint1Y.Location = new System.Drawing.Point(259, 46);
            this.txtPoint1Y.Name = "txtPoint1Y";
            this.txtPoint1Y.Size = new System.Drawing.Size(100, 25);
            this.txtPoint1Y.TabIndex = 4;
            // 
            // txtPoint2X
            // 
            this.txtPoint2X.Location = new System.Drawing.Point(122, 91);
            this.txtPoint2X.Name = "txtPoint2X";
            this.txtPoint2X.Size = new System.Drawing.Size(100, 25);
            this.txtPoint2X.TabIndex = 5;
            // 
            // txtPoint2Y
            // 
            this.txtPoint2Y.Location = new System.Drawing.Point(259, 91);
            this.txtPoint2Y.Name = "txtPoint2Y";
            this.txtPoint2Y.Size = new System.Drawing.Size(100, 25);
            this.txtPoint2Y.TabIndex = 6;
            // 
            // txtPoint3X
            // 
            this.txtPoint3X.Location = new System.Drawing.Point(122, 129);
            this.txtPoint3X.Name = "txtPoint3X";
            this.txtPoint3X.Size = new System.Drawing.Size(100, 25);
            this.txtPoint3X.TabIndex = 7;
            // 
            // txtPoint3Y
            // 
            this.txtPoint3Y.Location = new System.Drawing.Point(259, 129);
            this.txtPoint3Y.Name = "txtPoint3Y";
            this.txtPoint3Y.Size = new System.Drawing.Size(100, 25);
            this.txtPoint3Y.TabIndex = 8;
            // 
            // lbl_XCoord
            // 
            this.lbl_XCoord.AutoSize = true;
            this.lbl_XCoord.Location = new System.Drawing.Point(158, 21);
            this.lbl_XCoord.Name = "lbl_XCoord";
            this.lbl_XCoord.Size = new System.Drawing.Size(17, 15);
            this.lbl_XCoord.TabIndex = 9;
            this.lbl_XCoord.Text = "X";
            // 
            // lbl_YCoord
            // 
            this.lbl_YCoord.AutoSize = true;
            this.lbl_YCoord.Location = new System.Drawing.Point(299, 21);
            this.lbl_YCoord.Name = "lbl_YCoord";
            this.lbl_YCoord.Size = new System.Drawing.Size(17, 15);
            this.lbl_YCoord.TabIndex = 10;
            this.lbl_YCoord.Text = "Y";
            // 
            // grb_Input
            // 
            this.grb_Input.Controls.Add(this.lbl_Point1);
            this.grb_Input.Controls.Add(this.lbl_YCoord);
            this.grb_Input.Controls.Add(this.lbl_Point2);
            this.grb_Input.Controls.Add(this.lbl_XCoord);
            this.grb_Input.Controls.Add(this.lbl_Point3);
            this.grb_Input.Controls.Add(this.txtPoint3Y);
            this.grb_Input.Controls.Add(this.txtPoint1X);
            this.grb_Input.Controls.Add(this.txtPoint3X);
            this.grb_Input.Controls.Add(this.txtPoint1Y);
            this.grb_Input.Controls.Add(this.txtPoint2Y);
            this.grb_Input.Controls.Add(this.txtPoint2X);
            this.grb_Input.Location = new System.Drawing.Point(12, 12);
            this.grb_Input.Name = "grb_Input";
            this.grb_Input.Size = new System.Drawing.Size(478, 172);
            this.grb_Input.TabIndex = 11;
            this.grb_Input.TabStop = false;
            this.grb_Input.Text = "座標輸入";
            // 
            // grb_Select
            // 
            this.grb_Select.Controls.Add(this.cbx_ShapeType);
            this.grb_Select.Controls.Add(this.cbx_Perimeter);
            this.grb_Select.Controls.Add(this.cbx_Area);
            this.grb_Select.Location = new System.Drawing.Point(13, 191);
            this.grb_Select.Name = "grb_Select";
            this.grb_Select.Size = new System.Drawing.Size(477, 78);
            this.grb_Select.TabIndex = 12;
            this.grb_Select.TabStop = false;
            this.grb_Select.Text = "選項";
            // 
            // cbx_Area
            // 
            this.cbx_Area.AutoSize = true;
            this.cbx_Area.Location = new System.Drawing.Point(16, 38);
            this.cbx_Area.Name = "cbx_Area";
            this.cbx_Area.Size = new System.Drawing.Size(89, 19);
            this.cbx_Area.TabIndex = 0;
            this.cbx_Area.Text = "計算面積";
            this.cbx_Area.UseVisualStyleBackColor = true;
            // 
            // cbx_Perimeter
            // 
            this.cbx_Perimeter.AutoSize = true;
            this.cbx_Perimeter.Location = new System.Drawing.Point(130, 38);
            this.cbx_Perimeter.Name = "cbx_Perimeter";
            this.cbx_Perimeter.Size = new System.Drawing.Size(89, 19);
            this.cbx_Perimeter.TabIndex = 1;
            this.cbx_Perimeter.Text = "計算周長";
            this.cbx_Perimeter.UseVisualStyleBackColor = true;
            // 
            // cbx_ShapeType
            // 
            this.cbx_ShapeType.AutoSize = true;
            this.cbx_ShapeType.Location = new System.Drawing.Point(258, 38);
            this.cbx_ShapeType.Name = "cbx_ShapeType";
            this.cbx_ShapeType.Size = new System.Drawing.Size(134, 19);
            this.cbx_ShapeType.TabIndex = 13;
            this.cbx_ShapeType.Text = "輸出三角形類別";
            this.cbx_ShapeType.UseVisualStyleBackColor = true;
            // 
            // grp_Output
            // 
            this.grp_Output.Controls.Add(this.txt_Display);
            this.grp_Output.Controls.Add(this.btn_Calculate);
            this.grp_Output.Location = new System.Drawing.Point(12, 300);
            this.grp_Output.Name = "grp_Output";
            this.grp_Output.Size = new System.Drawing.Size(478, 424);
            this.grp_Output.TabIndex = 13;
            this.grp_Output.TabStop = false;
            this.grp_Output.Text = "功能鍵與輸出";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(386, 24);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 30);
            this.btn_Calculate.TabIndex = 0;
            this.btn_Calculate.Text = "計算";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // txt_Display
            // 
            this.txt_Display.Location = new System.Drawing.Point(17, 73);
            this.txt_Display.Multiline = true;
            this.txt_Display.Name = "txt_Display";
            this.txt_Display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Display.Size = new System.Drawing.Size(444, 327);
            this.txt_Display.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 773);
            this.Controls.Add(this.grp_Output);
            this.Controls.Add(this.grb_Select);
            this.Controls.Add(this.grb_Input);
            this.Name = "Form1";
            this.Text = "106 Quiz5";
            this.grb_Input.ResumeLayout(false);
            this.grb_Input.PerformLayout();
            this.grb_Select.ResumeLayout(false);
            this.grb_Select.PerformLayout();
            this.grp_Output.ResumeLayout(false);
            this.grp_Output.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Point1;
        private System.Windows.Forms.Label lbl_Point2;
        private System.Windows.Forms.Label lbl_Point3;
        private System.Windows.Forms.TextBox txtPoint1X;
        private System.Windows.Forms.TextBox txtPoint1Y;
        private System.Windows.Forms.TextBox txtPoint2X;
        private System.Windows.Forms.TextBox txtPoint2Y;
        private System.Windows.Forms.TextBox txtPoint3X;
        private System.Windows.Forms.TextBox txtPoint3Y;
        private System.Windows.Forms.Label lbl_XCoord;
        private System.Windows.Forms.Label lbl_YCoord;
        private System.Windows.Forms.GroupBox grb_Input;
        private System.Windows.Forms.GroupBox grb_Select;
        private System.Windows.Forms.CheckBox cbx_ShapeType;
        private System.Windows.Forms.CheckBox cbx_Perimeter;
        private System.Windows.Forms.CheckBox cbx_Area;
        private System.Windows.Forms.GroupBox grp_Output;
        private System.Windows.Forms.TextBox txt_Display;
        private System.Windows.Forms.Button btn_Calculate;
    }
}

