namespace ImageProc
{
    partial class ColorBalanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BlueSlider = new System.Windows.Forms.TrackBar();
            this.GreenSlider = new System.Windows.Forms.TrackBar();
            this.RedSlider = new System.Windows.Forms.TrackBar();
            this.BlueBox = new System.Windows.Forms.TextBox();
            this.GreenBox = new System.Windows.Forms.TextBox();
            this.RedBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HighLightenRatioButton = new System.Windows.Forms.RadioButton();
            this.MidtoneRadioButton = new System.Windows.Forms.RadioButton();
            this.ShadowRadioButton = new System.Windows.Forms.RadioButton();
            this.PLCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSlider)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(325, 32);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(78, 24);
            this.OKBtn.TabIndex = 0;
            this.OKBtn.Text = "确定";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(325, 63);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(78, 25);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BlueSlider);
            this.groupBox1.Controls.Add(this.GreenSlider);
            this.groupBox1.Controls.Add(this.RedSlider);
            this.groupBox1.Controls.Add(this.BlueBox);
            this.groupBox1.Controls.Add(this.GreenBox);
            this.groupBox1.Controls.Add(this.RedBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 146);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "色彩平衡";
            // 
            // BlueSlider
            // 
            this.BlueSlider.Location = new System.Drawing.Point(57, 96);
            this.BlueSlider.Maximum = 100;
            this.BlueSlider.Minimum = -100;
            this.BlueSlider.Name = "BlueSlider";
            this.BlueSlider.Size = new System.Drawing.Size(171, 45);
            this.BlueSlider.TabIndex = 12;
            this.BlueSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BlueSlider.Scroll += new System.EventHandler(this.BlueSlider_Scroll);
            // 
            // GreenSlider
            // 
            this.GreenSlider.Location = new System.Drawing.Point(57, 70);
            this.GreenSlider.Maximum = 100;
            this.GreenSlider.Minimum = -100;
            this.GreenSlider.Name = "GreenSlider";
            this.GreenSlider.Size = new System.Drawing.Size(171, 45);
            this.GreenSlider.TabIndex = 11;
            this.GreenSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GreenSlider.Scroll += new System.EventHandler(this.GreenSlider_Scroll);
            // 
            // RedSlider
            // 
            this.RedSlider.Location = new System.Drawing.Point(57, 40);
            this.RedSlider.Maximum = 100;
            this.RedSlider.Minimum = -100;
            this.RedSlider.Name = "RedSlider";
            this.RedSlider.Size = new System.Drawing.Size(171, 45);
            this.RedSlider.TabIndex = 10;
            this.RedSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RedSlider.Scroll += new System.EventHandler(this.RedSlider_Scroll);
            // 
            // BlueBox
            // 
            this.BlueBox.Enabled = false;
            this.BlueBox.Location = new System.Drawing.Point(190, 13);
            this.BlueBox.Name = "BlueBox";
            this.BlueBox.Size = new System.Drawing.Size(38, 21);
            this.BlueBox.TabIndex = 9;
            // 
            // GreenBox
            // 
            this.GreenBox.Enabled = false;
            this.GreenBox.Location = new System.Drawing.Point(146, 13);
            this.GreenBox.Name = "GreenBox";
            this.GreenBox.Size = new System.Drawing.Size(38, 21);
            this.GreenBox.TabIndex = 8;
            // 
            // RedBox
            // 
            this.RedBox.Enabled = false;
            this.RedBox.Location = new System.Drawing.Point(102, 14);
            this.RedBox.Name = "RedBox";
            this.RedBox.Size = new System.Drawing.Size(38, 21);
            this.RedBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "蓝色";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "黄色";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "绿色";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "红色";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "洋红";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "青色";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "色阶：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HighLightenRatioButton);
            this.groupBox2.Controls.Add(this.MidtoneRadioButton);
            this.groupBox2.Controls.Add(this.ShadowRadioButton);
            this.groupBox2.Controls.Add(this.PLCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 56);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "色调平衡";
            // 
            // HighLightenRatioButton
            // 
            this.HighLightenRatioButton.AutoSize = true;
            this.HighLightenRatioButton.Location = new System.Drawing.Point(190, 20);
            this.HighLightenRatioButton.Name = "HighLightenRatioButton";
            this.HighLightenRatioButton.Size = new System.Drawing.Size(47, 16);
            this.HighLightenRatioButton.TabIndex = 3;
            this.HighLightenRatioButton.Text = "高光";
            this.HighLightenRatioButton.UseVisualStyleBackColor = true;
            this.HighLightenRatioButton.CheckedChanged += new System.EventHandler(this.HighLightenRatioButton_CheckedChanged);
            // 
            // MidtoneRadioButton
            // 
            this.MidtoneRadioButton.AutoSize = true;
            this.MidtoneRadioButton.Checked = true;
            this.MidtoneRadioButton.Location = new System.Drawing.Point(102, 20);
            this.MidtoneRadioButton.Name = "MidtoneRadioButton";
            this.MidtoneRadioButton.Size = new System.Drawing.Size(59, 16);
            this.MidtoneRadioButton.TabIndex = 2;
            this.MidtoneRadioButton.TabStop = true;
            this.MidtoneRadioButton.Text = "中间调";
            this.MidtoneRadioButton.UseVisualStyleBackColor = true;
            this.MidtoneRadioButton.CheckedChanged += new System.EventHandler(this.MidtoneRadioButton_CheckedChanged);
            // 
            // ShadowRadioButton
            // 
            this.ShadowRadioButton.AutoSize = true;
            this.ShadowRadioButton.Location = new System.Drawing.Point(6, 20);
            this.ShadowRadioButton.Name = "ShadowRadioButton";
            this.ShadowRadioButton.Size = new System.Drawing.Size(47, 16);
            this.ShadowRadioButton.TabIndex = 1;
            this.ShadowRadioButton.Text = "阴影";
            this.ShadowRadioButton.UseVisualStyleBackColor = true;
            this.ShadowRadioButton.CheckedChanged += new System.EventHandler(this.ShadowRadioButton_CheckedChanged);
            // 
            // PLCheckBox
            // 
            this.PLCheckBox.AutoSize = true;
            this.PLCheckBox.Checked = true;
            this.PLCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PLCheckBox.Location = new System.Drawing.Point(7, 38);
            this.PLCheckBox.Name = "PLCheckBox";
            this.PLCheckBox.Size = new System.Drawing.Size(72, 16);
            this.PLCheckBox.TabIndex = 0;
            this.PLCheckBox.Text = "保持明度";
            this.PLCheckBox.UseVisualStyleBackColor = true;
            this.PLCheckBox.CheckedChanged += new System.EventHandler(this.PLCheckBox_CheckedChanged);
            // 
            // ColorBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 235);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorBalanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "色彩平衡";
            this.Load += new System.EventHandler(this.ColorBalanceForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSlider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar BlueSlider;
        private System.Windows.Forms.TrackBar RedSlider;
        private System.Windows.Forms.TextBox BlueBox;
        private System.Windows.Forms.TextBox GreenBox;
        private System.Windows.Forms.TextBox RedBox;
        private System.Windows.Forms.TrackBar GreenSlider;
        private System.Windows.Forms.CheckBox PLCheckBox;
        private System.Windows.Forms.RadioButton HighLightenRatioButton;
        private System.Windows.Forms.RadioButton MidtoneRadioButton;
        private System.Windows.Forms.RadioButton ShadowRadioButton;
    }
}