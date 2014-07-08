using System.Windows.Forms;
namespace ImageProc
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HistMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorAjustMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdjustBrightnessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContrastMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.HueSaturationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdjustLevelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlendMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.RotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClockWiseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AntiClockWiseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HorMirror = new System.Windows.Forms.ToolStripMenuItem();
            this.VerMirror = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OldPhotoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InvertMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SoftGlowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LomoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NegativeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SketchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenFileButton = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.UndoButton = new System.Windows.Forms.ToolStripButton();
            this.RedoButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeCostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.Silver;
            this.PictureBox.Location = new System.Drawing.Point(12, 53);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(760, 475);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
 
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.toolStripMenuItem1,
            this.ColorAjustMenuItem,
            this.FilterMenuItem,
            this.HelpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(784, 25);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileMenuItem,
            this.SaveMenuItem,
            this.toolStripSeparator1,
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(44, 21);
            this.FileMenuItem.Text = "文件";
            // 
            // OpenFileMenuItem
            // 
            this.OpenFileMenuItem.Name = "OpenFileMenuItem";
            this.OpenFileMenuItem.Size = new System.Drawing.Size(124, 22);
            this.OpenFileMenuItem.Text = "打开文件";
            this.OpenFileMenuItem.Click += new System.EventHandler(this.OpenFileMenuItem_Click);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(124, 22);
            this.SaveMenuItem.Text = "保存";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ExitMenuItem.Text = "退出";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HistMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem1.Text = "查看";
            // 
            // HistMenuItem
            // 
            this.HistMenuItem.Name = "HistMenuItem";
            this.HistMenuItem.Size = new System.Drawing.Size(152, 22);
            this.HistMenuItem.Text = "直方图";
            this.HistMenuItem.Click += new System.EventHandler(this.HistMenuItem_Click);
            // 
            // ColorAjustMenuItem
            // 
            this.ColorAjustMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdjustBrightnessMenuItem,
            this.ContrastMenuItem,
            this.toolStripSeparator2,
            this.HueSaturationMenuItem,
            this.AdjustLevelMenuItem,
            this.ColorMenuItem,
            this.BlendMenuItem,
            this.toolStripSeparator3,
            this.RotateToolStripMenuItem});
            this.ColorAjustMenuItem.Name = "ColorAjustMenuItem";
            this.ColorAjustMenuItem.Size = new System.Drawing.Size(44, 21);
            this.ColorAjustMenuItem.Text = "颜色";
            // 
            // AdjustBrightnessMenuItem
            // 
            this.AdjustBrightnessMenuItem.Name = "AdjustBrightnessMenuItem";
            this.AdjustBrightnessMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AdjustBrightnessMenuItem.Text = "亮度";
            this.AdjustBrightnessMenuItem.Click += new System.EventHandler(this.AdjustBrightnessMenuItem_Click);
            // 
            // ContrastMenuItem
            // 
            this.ContrastMenuItem.Name = "ContrastMenuItem";
            this.ContrastMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ContrastMenuItem.Text = "对比度";
            this.ContrastMenuItem.Click += new System.EventHandler(this.ContrastMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // HueSaturationMenuItem
            // 
            this.HueSaturationMenuItem.Name = "HueSaturationMenuItem";
            this.HueSaturationMenuItem.Size = new System.Drawing.Size(152, 22);
            this.HueSaturationMenuItem.Text = "色相/饱和度";
            this.HueSaturationMenuItem.Click += new System.EventHandler(this.HueSaturationMenuItem_Click);
            // 
            // AdjustLevelMenuItem
            // 
            this.AdjustLevelMenuItem.Name = "AdjustLevelMenuItem";
            this.AdjustLevelMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AdjustLevelMenuItem.Text = "色阶调整";
            this.AdjustLevelMenuItem.Click += new System.EventHandler(this.AdjustLevelMenuItem_Click);
            // 
            // ColorMenuItem
            // 
            this.ColorMenuItem.Name = "ColorMenuItem";
            this.ColorMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ColorMenuItem.Text = "色彩平衡";
            this.ColorMenuItem.Click += new System.EventHandler(this.ColorMenuItem_Click);
            // 
            // BlendMenuItem
            // 
            this.BlendMenuItem.Name = "BlendMenuItem";
            this.BlendMenuItem.Size = new System.Drawing.Size(152, 22);
            this.BlendMenuItem.Text = "图层混合";
            this.BlendMenuItem.Click += new System.EventHandler(this.BlendMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // RotateToolStripMenuItem
            // 
            this.RotateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClockWiseMenuItem,
            this.AntiClockWiseMenuItem,
            this.HorMirror,
            this.VerMirror});
            this.RotateToolStripMenuItem.Name = "RotateToolStripMenuItem";
            this.RotateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.RotateToolStripMenuItem.Text = "旋转";
            // 
            // ClockWiseMenuItem
            // 
            this.ClockWiseMenuItem.Name = "ClockWiseMenuItem";
            this.ClockWiseMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ClockWiseMenuItem.Text = "顺时针旋转";
            this.ClockWiseMenuItem.Click += new System.EventHandler(this.ClockWiseMenuItem_Click);
            // 
            // AntiClockWiseMenuItem
            // 
            this.AntiClockWiseMenuItem.Name = "AntiClockWiseMenuItem";
            this.AntiClockWiseMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AntiClockWiseMenuItem.Text = "逆时针旋转";
            this.AntiClockWiseMenuItem.Click += new System.EventHandler(this.AntiClockWiseMenuItem_Click);
            // 
            // HorMirror
            // 
            this.HorMirror.Name = "HorMirror";
            this.HorMirror.Size = new System.Drawing.Size(152, 22);
            this.HorMirror.Text = "水平镜像";
            this.HorMirror.Click += new System.EventHandler(this.HorMirror_Click);
            // 
            // VerMirror
            // 
            this.VerMirror.Name = "VerMirror";
            this.VerMirror.Size = new System.Drawing.Size(152, 22);
            this.VerMirror.Text = "垂直镜像";
            this.VerMirror.Click += new System.EventHandler(this.VerMirror_Click);
            // 
            // FilterMenuItem
            // 
            this.FilterMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GrayMenuItem,
            this.OldPhotoMenuItem,
            this.InvertMenuItem,
            this.SoftGlowMenuItem,
            this.LomoMenuItem,
            this.NegativeMenuItem,
            this.SketchMenuItem});
            this.FilterMenuItem.Name = "FilterMenuItem";
            this.FilterMenuItem.Size = new System.Drawing.Size(68, 21);
            this.FilterMenuItem.Text = "一键特效";
            // 
            // GrayMenuItem
            // 
            this.GrayMenuItem.Name = "GrayMenuItem";
            this.GrayMenuItem.Size = new System.Drawing.Size(144, 22);
            this.GrayMenuItem.Text = "黑白照片";
            this.GrayMenuItem.Click += new System.EventHandler(this.GrayMenuItem_Click);
            // 
            // OldPhotoMenuItem
            // 
            this.OldPhotoMenuItem.Name = "OldPhotoMenuItem";
            this.OldPhotoMenuItem.Size = new System.Drawing.Size(144, 22);
            this.OldPhotoMenuItem.Text = "旧照片";
            this.OldPhotoMenuItem.Click += new System.EventHandler(this.OldPhotoMenuItem_Click);
            // 
            // InvertMenuItem
            // 
            this.InvertMenuItem.Name = "InvertMenuItem";
            this.InvertMenuItem.Size = new System.Drawing.Size(144, 22);
            this.InvertMenuItem.Text = "反相";
            this.InvertMenuItem.Click += new System.EventHandler(this.InvertMenuItem_Click);
            // 
            // SoftGlowMenuItem
            // 
            this.SoftGlowMenuItem.Name = "SoftGlowMenuItem";
            this.SoftGlowMenuItem.Size = new System.Drawing.Size(144, 22);
            this.SoftGlowMenuItem.Text = "柔光";
            this.SoftGlowMenuItem.Click += new System.EventHandler(this.SoftGlowMenuItem_Click);
            // 
            // LomoMenuItem
            // 
            this.LomoMenuItem.Name = "LomoMenuItem";
            this.LomoMenuItem.Size = new System.Drawing.Size(144, 22);
            this.LomoMenuItem.Text = "LOMO";
            this.LomoMenuItem.Click += new System.EventHandler(this.LomoMenuItem_Click);
            // 
            // NegativeMenuItem
            // 
            this.NegativeMenuItem.Name = "NegativeMenuItem";
            this.NegativeMenuItem.Size = new System.Drawing.Size(144, 22);
            this.NegativeMenuItem.Text = "反转负冲";
            this.NegativeMenuItem.Click += new System.EventHandler(this.NegativeMenuItem_Click);
            // 
            // SketchMenuItem
            // 
            this.SketchMenuItem.Name = "SketchMenuItem";
            this.SketchMenuItem.Size = new System.Drawing.Size(144, 22);
            this.SketchMenuItem.Text = "素描(半成品)";
            this.SketchMenuItem.Click += new System.EventHandler(this.SketchMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.HelpToolStripMenuItem.Text = "帮助";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(100, 22);
            this.AboutMenuItem.Text = "关于";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileButton,
            this.SaveButton,
            this.toolStripSeparator4,
            this.UndoButton,
            this.RedoButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileButton.Image")));
            this.OpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(23, 22);
            this.OpenFileButton.Text = "打开";
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(23, 22);
            this.SaveButton.Text = "保存";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // UndoButton
            // 
            this.UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoButton.Image = ((System.Drawing.Image)(resources.GetObject("UndoButton.Image")));
            this.UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(23, 22);
            this.UndoButton.Text = "Undo";
            this.UndoButton.ToolTipText = "撤销";
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedoButton.Image = ((System.Drawing.Image)(resources.GetObject("RedoButton.Image")));
            this.RedoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(23, 22);
            this.RedoButton.Text = "Redo";
            this.RedoButton.ToolTipText = "恢复";
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "处理时间:";
            // 
            // TimeCostLabel
            // 
            this.TimeCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TimeCostLabel.AutoSize = true;
            this.TimeCostLabel.Location = new System.Drawing.Point(77, 541);
            this.TimeCostLabel.Name = "TimeCostLabel";
            this.TimeCostLabel.Size = new System.Drawing.Size(0, 12);
            this.TimeCostLabel.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.TimeCostLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片编辑";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.Resize += new System.EventHandler(this.Mainform_Resize);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(MainForm_DragEnter);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(MainForm_DragDrop);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



      


        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorAjustMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdjustBrightnessMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdjustLevelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HueSaturationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContrastMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FilterMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem LomoMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenFileButton;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripButton UndoButton;
        private System.Windows.Forms.ToolStripButton RedoButton;
        private System.Windows.Forms.ToolStripMenuItem SketchMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem RotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClockWiseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AntiClockWiseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HorMirror;
        private System.Windows.Forms.ToolStripMenuItem VerMirror;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimeCostLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem HistMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GrayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OldPhotoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BlendMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InvertMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NegativeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SoftGlowMenuItem;
    }
}

