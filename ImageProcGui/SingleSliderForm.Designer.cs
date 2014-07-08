namespace ImageProc
{
    partial class SingleSliderForm
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
            this.Slider = new System.Windows.Forms.TrackBar();
            this.OKBtn = new System.Windows.Forms.Button();
            this.SliderText = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            this.SuspendLayout();
            // 
            // Slider
            // 
            this.Slider.Location = new System.Drawing.Point(46, 22);
            this.Slider.Maximum = 100;
            this.Slider.Minimum = -100;
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(253, 45);
            this.Slider.TabIndex = 50;
            this.Slider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Slider.Scroll += new System.EventHandler(this.Slider_Scroll);
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(112, 73);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 51;
            this.OKBtn.Text = "确定";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // SliderText
            // 
            this.SliderText.Enabled = false;
            this.SliderText.Location = new System.Drawing.Point(305, 22);
            this.SliderText.Name = "SliderText";
            this.SliderText.Size = new System.Drawing.Size(45, 21);
            this.SliderText.TabIndex = 53;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(214, 73);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 54;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SingleSliderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 104);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SliderText);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.Slider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SingleSliderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.SingleSliderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar Slider;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.TextBox SliderText;
        private System.Windows.Forms.Button CancelBtn;
    }
}