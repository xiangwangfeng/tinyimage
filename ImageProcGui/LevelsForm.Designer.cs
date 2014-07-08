namespace ImageProc
{
    partial class LevelsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GammText = new System.Windows.Forms.TextBox();
            this.WhiteText = new System.Windows.Forms.TextBox();
            this.BlackText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChannelBox = new System.Windows.Forms.ComboBox();
            this.GammaSlider = new System.Windows.Forms.TrackBar();
            this.WhiteSlider = new System.Windows.Forms.TrackBar();
            this.BlackSlider = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GammaSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(108, 231);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 0;
            this.OKBtn.Text = "确定";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GammText);
            this.groupBox1.Controls.Add(this.WhiteText);
            this.groupBox1.Controls.Add(this.BlackText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ChannelBox);
            this.groupBox1.Controls.Add(this.GammaSlider);
            this.groupBox1.Controls.Add(this.WhiteSlider);
            this.groupBox1.Controls.Add(this.BlackSlider);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 213);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数调整";
            // 
            // GammText
            // 
            this.GammText.Enabled = false;
            this.GammText.Location = new System.Drawing.Point(338, 154);
            this.GammText.Name = "GammText";
            this.GammText.Size = new System.Drawing.Size(47, 21);
            this.GammText.TabIndex = 10;
            // 
            // WhiteText
            // 
            this.WhiteText.Enabled = false;
            this.WhiteText.Location = new System.Drawing.Point(338, 103);
            this.WhiteText.Name = "WhiteText";
            this.WhiteText.Size = new System.Drawing.Size(47, 21);
            this.WhiteText.TabIndex = 9;
            // 
            // BlackText
            // 
            this.BlackText.Enabled = false;
            this.BlackText.Location = new System.Drawing.Point(338, 56);
            this.BlackText.Name = "BlackText";
            this.BlackText.Size = new System.Drawing.Size(47, 21);
            this.BlackText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "通道：";
            // 
            // ChannelBox
            // 
            this.ChannelBox.FormattingEnabled = true;
            this.ChannelBox.Items.AddRange(new object[] {
            "RGB通道",
            "红",
            "绿",
            "蓝"});
            this.ChannelBox.Location = new System.Drawing.Point(96, 20);
            this.ChannelBox.Name = "ChannelBox";
            this.ChannelBox.Size = new System.Drawing.Size(121, 20);
            this.ChannelBox.TabIndex = 6;
            this.ChannelBox.SelectedIndex = 0;
            this.ChannelBox.SelectedIndexChanged += new System.EventHandler(this.ChannelBox_SelectedIndexChanged);
            // 
            // GammaSlider
            // 
            this.GammaSlider.Location = new System.Drawing.Point(96, 151);
            this.GammaSlider.Maximum = 1000;
            this.GammaSlider.Name = "GammaSlider";
            this.GammaSlider.Size = new System.Drawing.Size(236, 45);
            this.GammaSlider.TabIndex = 5;
            this.GammaSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GammaSlider.Value = 100;
            this.GammaSlider.Scroll += new System.EventHandler(this.GammaSlider_Scroll);
            // 
            // WhiteSlider
            // 
            this.WhiteSlider.Location = new System.Drawing.Point(96, 103);
            this.WhiteSlider.Maximum = 255;
            this.WhiteSlider.Minimum = 1;
            this.WhiteSlider.Name = "WhiteSlider";
            this.WhiteSlider.Size = new System.Drawing.Size(236, 45);
            this.WhiteSlider.TabIndex = 4;
            this.WhiteSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.WhiteSlider.Value = 255;
            this.WhiteSlider.Scroll += new System.EventHandler(this.WhiteSlider_Scroll);
            // 
            // BlackSlider
            // 
            this.BlackSlider.Location = new System.Drawing.Point(96, 59);
            this.BlackSlider.Maximum = 254;
            this.BlackSlider.Name = "BlackSlider";
            this.BlackSlider.Size = new System.Drawing.Size(236, 45);
            this.BlackSlider.TabIndex = 3;
            this.BlackSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BlackSlider.Scroll += new System.EventHandler(this.BlackSlider_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gamma：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "白场：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "黑场：";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(243, 231);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // LevelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 266);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OKBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LevelsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "色阶调整";
            this.Load += new System.EventHandler(this.AdjustLevelForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GammaSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackSlider)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ChannelBox;
        private System.Windows.Forms.TrackBar GammaSlider;
        private System.Windows.Forms.TrackBar WhiteSlider;
        private System.Windows.Forms.TrackBar BlackSlider;
        private System.Windows.Forms.TextBox GammText;
        private System.Windows.Forms.TextBox WhiteText;
        private System.Windows.Forms.TextBox BlackText;
        private System.Windows.Forms.Button CancelBtn;
    }
}