namespace ImageProc
{
    partial class BlendForm
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
            this.InvertCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChannelCombox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OpacityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ModeCombox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(68, 218);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 0;
            this.OKBtn.Text = "确定";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(199, 218);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InvertCheckBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ChannelCombox);
            this.groupBox1.Location = new System.Drawing.Point(31, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "源";
            // 
            // InvertCheckBox
            // 
            this.InvertCheckBox.AutoSize = true;
            this.InvertCheckBox.Location = new System.Drawing.Point(21, 57);
            this.InvertCheckBox.Name = "InvertCheckBox";
            this.InvertCheckBox.Size = new System.Drawing.Size(48, 16);
            this.InvertCheckBox.TabIndex = 2;
            this.InvertCheckBox.Text = "反相";
            this.InvertCheckBox.UseVisualStyleBackColor = true;
            this.InvertCheckBox.CheckedChanged += new System.EventHandler(this.InvertCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "通道：";
            // 
            // ChannelCombox
            // 
            this.ChannelCombox.FormattingEnabled = true;
            this.ChannelCombox.Items.AddRange(new object[] {
            "RGB",
            "红",
            "绿",
            "蓝"});
            this.ChannelCombox.Location = new System.Drawing.Point(76, 25);
            this.ChannelCombox.Name = "ChannelCombox";
            this.ChannelCombox.Size = new System.Drawing.Size(121, 20);
            this.ChannelCombox.TabIndex = 0;
            this.ChannelCombox.SelectedIndex = 0;
            this.ChannelCombox.SelectedIndexChanged += new System.EventHandler(this.ChannelCombox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OpacityTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ModeCombox);
            this.groupBox2.Location = new System.Drawing.Point(31, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "混合模式";
            // 
            // OpacityTextBox
            // 
            this.OpacityTextBox.Location = new System.Drawing.Point(79, 67);
            this.OpacityTextBox.Name = "OpacityTextBox";
            this.OpacityTextBox.Size = new System.Drawing.Size(54, 21);
            this.OpacityTextBox.TabIndex = 6;
            this.OpacityTextBox.Text = "100";
            this.OpacityTextBox.TextChanged += new System.EventHandler(this.OpacityTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "不透明度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "混合：";
            // 
            // ModeCombox
            // 
            this.ModeCombox.FormattingEnabled = true;
            this.ModeCombox.Items.AddRange(new object[] {
            "变暗",
            "变亮",
            "正片叠底",
            "滤色",
            "颜色减淡",
            "颜色加深",
            "线性减淡",
            "线性加深",
            "叠加",
            "柔光",
            "强光",
            "亮光",
            "线性光",
            "点光",
            "实色混合",
            "相加",
            "相减",
            "差值",
            "排除"});
            this.ModeCombox.Location = new System.Drawing.Point(76, 32);
            this.ModeCombox.Name = "ModeCombox";
            this.ModeCombox.Size = new System.Drawing.Size(121, 20);
            this.ModeCombox.TabIndex = 1;
            this.ModeCombox.SelectedIndex = 0;
            this.ModeCombox.SelectedIndexChanged += new System.EventHandler(this.ModeCombox_SelectedIndexChanged);
            // 
            // BlendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 250);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BlendForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图层混合";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox InvertCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChannelCombox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ModeCombox;
        private System.Windows.Forms.TextBox OpacityTextBox;
    }
}