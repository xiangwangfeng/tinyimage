namespace ImageProc
{
    partial class HueSaturationForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HueRangeCombox = new System.Windows.Forms.ComboBox();
            this.BriTextBox = new System.Windows.Forms.TextBox();
            this.SatTextBox = new System.Windows.Forms.TextBox();
            this.HueTextBox = new System.Windows.Forms.TextBox();
            this.BriSlider = new System.Windows.Forms.TrackBar();
            this.SatSlider = new System.Windows.Forms.TrackBar();
            this.HueSlider = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BriSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(113, 227);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "确定";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(259, 227);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HueRangeCombox);
            this.groupBox1.Controls.Add(this.BriTextBox);
            this.groupBox1.Controls.Add(this.SatTextBox);
            this.groupBox1.Controls.Add(this.HueTextBox);
            this.groupBox1.Controls.Add(this.BriSlider);
            this.groupBox1.Controls.Add(this.SatSlider);
            this.groupBox1.Controls.Add(this.HueSlider);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 209);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // HueRangeCombox
            // 
            this.HueRangeCombox.FormattingEnabled = true;
            this.HueRangeCombox.Items.AddRange(new object[] {
            "全图",
            "红色",
            "黄色",
            "绿色",
            "青色",
            "蓝色",
            "洋红"});
            this.HueRangeCombox.Location = new System.Drawing.Point(18, 0);
            this.HueRangeCombox.Name = "HueRangeCombox";
            this.HueRangeCombox.Size = new System.Drawing.Size(84, 20);
            this.HueRangeCombox.TabIndex = 9;
            this.HueRangeCombox.SelectedIndex = 0;
            this.HueRangeCombox.SelectedIndexChanged += new System.EventHandler(this.HueRangeCombox_SelectedIndexChanged);
            // 
            // BriTextBox
            // 
            this.BriTextBox.Enabled = false;
            this.BriTextBox.Location = new System.Drawing.Point(311, 165);
            this.BriTextBox.Name = "BriTextBox";
            this.BriTextBox.Size = new System.Drawing.Size(53, 21);
            this.BriTextBox.TabIndex = 8;
            // 
            // SatTextBox
            // 
            this.SatTextBox.Enabled = false;
            this.SatTextBox.Location = new System.Drawing.Point(311, 103);
            this.SatTextBox.Name = "SatTextBox";
            this.SatTextBox.Size = new System.Drawing.Size(53, 21);
            this.SatTextBox.TabIndex = 7;
            // 
            // HueTextBox
            // 
            this.HueTextBox.Enabled = false;
            this.HueTextBox.Location = new System.Drawing.Point(311, 50);
            this.HueTextBox.Name = "HueTextBox";
            this.HueTextBox.Size = new System.Drawing.Size(53, 21);
            this.HueTextBox.TabIndex = 6;
            // 
            // BriSlider
            // 
            this.BriSlider.Location = new System.Drawing.Point(55, 158);
            this.BriSlider.Maximum = 100;
            this.BriSlider.Minimum = -100;
            this.BriSlider.Name = "BriSlider";
            this.BriSlider.Size = new System.Drawing.Size(250, 45);
            this.BriSlider.TabIndex = 5;
            this.BriSlider.Scroll += new System.EventHandler(this.BriSlider_Scroll);
            // 
            // SatSlider
            // 
            this.SatSlider.Location = new System.Drawing.Point(55, 92);
            this.SatSlider.Maximum = 100;
            this.SatSlider.Minimum = -100;
            this.SatSlider.Name = "SatSlider";
            this.SatSlider.Size = new System.Drawing.Size(250, 45);
            this.SatSlider.TabIndex = 4;
            this.SatSlider.Scroll += new System.EventHandler(this.SatSlider_Scroll);
            // 
            // HueSlider
            // 
            this.HueSlider.Location = new System.Drawing.Point(55, 41);
            this.HueSlider.Maximum = 180;
            this.HueSlider.Minimum = -180;
            this.HueSlider.Name = "HueSlider";
            this.HueSlider.Size = new System.Drawing.Size(250, 45);
            this.HueSlider.TabIndex = 3;
            this.HueSlider.Scroll += new System.EventHandler(this.HueSlider_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "明度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "饱和度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "色相";
            // 
            // HueSaturationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HueSaturationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "色相/饱和度";
            this.Load += new System.EventHandler(this.HueSaturationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BriSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox BriTextBox;
        private System.Windows.Forms.TextBox SatTextBox;
        private System.Windows.Forms.TextBox HueTextBox;
        private System.Windows.Forms.TrackBar BriSlider;
        private System.Windows.Forms.TrackBar SatSlider;
        private System.Windows.Forms.TrackBar HueSlider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HueRangeCombox;
    }
}