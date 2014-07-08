using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ImageProc
{   

    public enum Filter
    {
        Lomo,           //Lomo
        Sketch,         //素描
        GrayScale,      //灰度化
        OldPhoto,       //老照片
        Invert,         //反相
        NegativeFilm,   //反转负冲
        SoftGlow,       //柔光
    }

    public enum Rotate
    {
        ClockWise,
        AntiClockWise,
        HorMirror,
        VerMirror
    }


    public partial class MainForm : Form
    {
        private string m_filename;      //原图路径
        private Bitmap m_bitmap;        //原图Bitmap数据
        private Bitmap m_editBitmap = new Bitmap(1,1);    //编辑用Bitmap数据
        private Bitmap m_thumbBitmap = new Bitmap(1, 1);  //临时生成的缩略图提供编辑用
        private const int m_bpp = 4;    //暂时都解析成32位
        private OperationHistory m_history = new OperationHistory();//历史记录
        private int m_width  = 0;
        private int m_height = 0;
        private Stopwatch m_StopWatch = new Stopwatch();
        public MainForm()
        {
            InitializeComponent();
        }

        private void StartImageProcess()
        {
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            m_StopWatch.Reset();
            m_StopWatch.Start();
        }

        private void EndImageProcess()
        {
            this.Enabled = true;
            this.Cursor = Cursors.Arrow;
            PictureBox.Image = m_bitmap;
            m_StopWatch.Stop();
            TimeCostLabel.Text = m_StopWatch.ElapsedMilliseconds.ToString()
                                 + "毫秒";
            m_history.AddHistory(m_bitmap);
        }

        private void GenerateThumbBitmap()
        {
            const int width = 720;
            const int height = 480;
            const double ratio = 1.5;
            int bmpWidth = m_bitmap.Width;
            int bmpHeight = m_bitmap.Height;
            double bmpRatio = (double)bmpWidth / bmpHeight;
            int thumbWidth, thumbHeight;
            if (bmpRatio > ratio)
            {
                thumbWidth = width;
                thumbHeight = (int)(width / bmpRatio);
            }
            else
            {
                thumbHeight = height;
                thumbWidth = (int)(height * bmpRatio);
            }
            m_thumbBitmap.Dispose();
            m_thumbBitmap = new Bitmap(thumbWidth, thumbHeight, m_bitmap.PixelFormat);
            Graphics g = Graphics.FromImage(m_thumbBitmap);
            g.DrawImage(m_bitmap, 0, 0, thumbWidth, thumbHeight);
            g.Dispose();
        }

      
        
        #region 菜单响应事件
        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG Files(*.jpg,*.jpeg,*.jpe)|*.jpg;*.jpeg;*.jpe" + "|"
                                       + "PNG Files(*.png)|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFile(openFileDialog.FileName);
            }
        }

        private void    OpenFile(string filename)
        {
            m_filename = filename;
            try
            {
                m_bitmap.Dispose();
            }
            catch (System.Exception)
            {

            }
            m_bitmap = new Bitmap(m_filename);
            PictureBox.Image = m_bitmap;
            m_history.SetEditImage(m_filename);
        }

        private Bitmap GetEditBitmap()
        {
            if (m_thumbBitmap != null)
            {
                return (Bitmap)m_thumbBitmap.Clone();
            }
            return null;
        }
       

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
           
        }

        private void SaveFile()
        {
            try
            {
                if (m_bitmap != null)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.CheckPathExists = true;
                    saveFileDialog.Filter = "JPG Files(*.jpg,*.jpeg,*.jpe)|*.jpg;*.jpeg;*.jpe" + "|"
                                            + "PNG Files(*.png)|*.png";
                                             ;
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filename = saveFileDialog.FileName;
                        if (filename.EndsWith("png"))
                        {
                            m_bitmap.Save(filename, ImageFormat.Png);
                        }
                        else
                        {
                            m_bitmap.Save(filename, ImageFormat.Jpeg);
                        }
                    }

                }
            }
            catch (System.Exception)
            {

            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdjustBrightnessMenuItem_Click(object sender, EventArgs e)
        {
            if (m_bitmap == null)
            {
                return;
            }
            GenerateThumbBitmap();
            SingleSliderForm form = new SingleSliderForm("亮度调整", AdjustBrightnessCallback);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                double percent = form.Percent;
                StartImageProcess();
                try
                {
                    BitmapData bitmapData = m_bitmap.LockBits(new Rectangle(0, 0, m_bitmap.Width, m_bitmap.Height),
                                                                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                    NativeMethods.AdjustBrightness(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp, percent);
                    m_bitmap.UnlockBits(bitmapData);
                    
                }
                catch (System.Exception ex)
                {
                	Console.WriteLine(ex.Source.ToString());
                }
                EndImageProcess();
            }
            else
            {
                PictureBox.Image = m_bitmap;
            }
        }

        private void ContrastMenuItem_Click(object sender, EventArgs e)
        {
            if (m_bitmap == null)
            {
                return;
            }
            GenerateThumbBitmap();
            SingleSliderForm form = new SingleSliderForm("对比度调整", AdjustContrastCallback);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                double percent = form.Percent;
                StartImageProcess();
                try
                {
                    BitmapData bitmapData = m_bitmap.LockBits(new Rectangle(0, 0, m_bitmap.Width, m_bitmap.Height),
                                                                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                    NativeMethods.AdjustContrast(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp, percent);
                    m_bitmap.UnlockBits(bitmapData);
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Source.ToString());
                }
                EndImageProcess();

            }
            else
            {
                PictureBox.Image = m_bitmap;
            }
        }

        private void HueSaturationMenuItem_Click(object sender, EventArgs e)
        {
            if (m_bitmap == null)
            {
                return;
            }
            GenerateThumbBitmap();
            HueSaturationForm form = new HueSaturationForm(AdjustHueSaturationCallBack);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                int hue         = form.Hue;
                int saturation  = form.Saturation;
                int lightness = form.Lightness;
                TINYIMAGE_HUERANGE hueRange = form.HueRange;
                StartImageProcess();
                try
                {
                    BitmapData bitmapData = m_bitmap.LockBits(new Rectangle(0, 0, m_bitmap.Width, m_bitmap.Height),
                                                                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                    NativeMethods.AdjustHueSaturation(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp,
                                                        hue, saturation, lightness, hueRange);
                    m_bitmap.UnlockBits(bitmapData);

                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Source.ToString());
                }
                EndImageProcess();

            }
            else
            {
                PictureBox.Image = m_bitmap;
            }
        }

        private void AdjustLevelMenuItem_Click(object sender, EventArgs e)
        {
            if (m_bitmap == null)
            {
                return;
            }
            GenerateThumbBitmap();
            LevelsForm form = new LevelsForm(AdjustLevelCallback);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                int blackThreshold = form.BlackThreshold;
                int whiteThreshold = form.WhiteThreshold;
                double gamma = form.Gamma;
                TINYIMAGE_CHANNEL channel = form.Channel;

                StartImageProcess();
                try
                {
                    BitmapData bitmapData = m_bitmap.LockBits(new Rectangle(0, 0, m_bitmap.Width, m_bitmap.Height),
                                                                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                    NativeMethods.AdjustLevels(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp,
                                                blackThreshold, whiteThreshold, gamma, channel);
                    m_bitmap.UnlockBits(bitmapData);
                   
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Source.ToString());
                }
                EndImageProcess();

            }
            else
            {
                PictureBox.Image = m_bitmap;
            }

        }

        private void ColorMenuItem_Click(object sender, EventArgs e)
        {
            if (m_bitmap == null)
            {
                return;
            }
            GenerateThumbBitmap();
            ColorBalanceForm form = new ColorBalanceForm(ColorBalanceCallBack);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                int red = form.Red;
                int green = form.Green;
                int blue = form.Blue;
                TINYIMAGE_TRANSFERMODE mode = form.TransferMode;
                bool preserveLuminosity = form.PreserveLuminosity;

                StartImageProcess();
                try
                {
                    BitmapData bitmapData = m_bitmap.LockBits(new Rectangle(0, 0, m_bitmap.Width, m_bitmap.Height),
                                                                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                    NativeMethods.BalanceColor(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp,
                                               red,green,blue,mode,preserveLuminosity);
                    m_bitmap.UnlockBits(bitmapData);    
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Source.ToString());
                }
                EndImageProcess();

            }
            else
            {
                PictureBox.Image = m_bitmap;
            }
        }

        private void LomoMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(Filter.Lomo);
        }

        private void SketchMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(Filter.Sketch);
        }

        private void GrayMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(Filter.GrayScale);
        }

        private void OldPhotoMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(Filter.OldPhoto);
        }

        private void InvertMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(Filter.Invert);
        }

        private void NegativeMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(Filter.NegativeFilm);
        }

        private void SoftGlowMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(Filter.SoftGlow);
        }

#endregion

        #region 图片编辑回调函数
        private void AdjustBrightnessCallback(double percent)
        {
            try
            {
                m_editBitmap.Dispose();
                m_editBitmap = GetEditBitmap();
                BitmapData bitmapData = m_editBitmap.LockBits(new Rectangle(0, 0, m_editBitmap.Width, m_editBitmap.Height),
                                                            ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                NativeMethods.AdjustBrightness(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp, percent);
                m_editBitmap.UnlockBits(bitmapData);
                PictureBox.Image = m_editBitmap;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void AdjustContrastCallback(double percent)
        {
            try
            {
                m_editBitmap.Dispose();
                m_editBitmap = GetEditBitmap();
                BitmapData bitmapData = m_editBitmap.LockBits(new Rectangle(0, 0, m_editBitmap.Width, m_editBitmap.Height),
                                                            ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                NativeMethods.AdjustContrast(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp, percent);
                m_editBitmap.UnlockBits(bitmapData);
                PictureBox.Image = m_editBitmap;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }




        private void AdjustLevelCallback(int black,int white,double gamma,TINYIMAGE_CHANNEL channel)
        {

            try
            {
                m_editBitmap.Dispose();
                m_editBitmap = GetEditBitmap();
                BitmapData bitmapData = m_editBitmap.LockBits(new Rectangle(0, 0, m_editBitmap.Width, m_editBitmap.Height),
                                                            ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                NativeMethods.AdjustLevels(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp,
                                            black,white,gamma,channel);
                m_editBitmap.UnlockBits(bitmapData);
                PictureBox.Image = m_editBitmap;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void BlendModeCallback(TINYIMAGE_BLENDMODE mode,double opacity,TINYIMAGE_CHANNEL channel,bool invert)
        {
            try
            {
                m_editBitmap.Dispose();
                m_editBitmap = GetEditBitmap();
                Bitmap blendBitmap = (Bitmap)m_editBitmap.Clone();
                if (invert)
                {
                    InvertBitmap(blendBitmap);
                }

                BitmapData bitmapData = m_editBitmap.LockBits(new Rectangle(0, 0, m_editBitmap.Width, m_editBitmap.Height),
                                                            ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

                BitmapData blendBitmapData = blendBitmap.LockBits(new Rectangle(0, 0, blendBitmap.Width, blendBitmap.Height),
                                                           ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);


                NativeMethods.BlendMode(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp,TINYIMAGE_CHANNEL.TINYIMAGE_CHANEL_RGB,
                                        blendBitmapData.Scan0, blendBitmapData.Width, blendBitmapData.Height, blendBitmapData.Stride, m_bpp,channel,
                                        mode, opacity);

                blendBitmap.UnlockBits(blendBitmapData);
                m_editBitmap.UnlockBits(bitmapData);
                blendBitmap.Dispose();
                PictureBox.Image = m_editBitmap;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ColorBalanceCallBack(int cyan, int magenta, int yellow,TINYIMAGE_TRANSFERMODE mode,bool preserveLuminosity)
        {
            try
            {
                m_editBitmap.Dispose();
                m_editBitmap = GetEditBitmap();
                BitmapData bitmapData = m_editBitmap.LockBits(new Rectangle(0, 0, m_editBitmap.Width, m_editBitmap.Height),
                                                            ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                NativeMethods.BalanceColor(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp,
                                            cyan, magenta,yellow,mode,preserveLuminosity);
                m_editBitmap.UnlockBits(bitmapData);
                PictureBox.Image = m_editBitmap;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void AdjustHueSaturationCallBack(int hue,int saturation,int lightness,TINYIMAGE_HUERANGE hueRange)
        {
            try
            {
                m_editBitmap.Dispose();
                m_editBitmap = GetEditBitmap();
                BitmapData bitmapData = m_editBitmap.LockBits(new Rectangle(0, 0, m_editBitmap.Width, m_editBitmap.Height),
                                                            ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                NativeMethods.AdjustHueSaturation(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp,
                                                    hue, saturation, lightness, hueRange);
                m_editBitmap.UnlockBits(bitmapData);
                PictureBox.Image = m_editBitmap;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        #endregion




        private void ApplyFilter(Filter operation)
        {
            StartImageProcess();
            try
            {
                BitmapData bitmapData = m_bitmap.LockBits(new Rectangle(0, 0, m_bitmap.Width, m_bitmap.Height),
                                                            ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                OnApplyFilter(operation, bitmapData);
                m_bitmap.UnlockBits(bitmapData);
                
  
            }
            catch (System.Exception)
            {
            }
            EndImageProcess();
        }

        private void OnApplyFilter(Filter operation, BitmapData bitmapData)
        {
           switch (operation)
           {
           case Filter.Lomo:
                   NativeMethods.Lomo(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp);
           	       break;
           case Filter.Sketch:
                   NativeMethods.Sketch(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp);
                   break;
           case Filter.GrayScale:
                   NativeMethods.GrayScale(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp);
                   break;
           case Filter.OldPhoto:
                   NativeMethods.OldPhoto(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp);
                   break;
           case Filter.Invert:
                   NativeMethods.Invert(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp);
                   break;
           case Filter.NegativeFilm:
                   NativeMethods.NegativeFilm(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp);
                   break;
           case Filter.SoftGlow:
                   NativeMethods.SoftGlow(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp);
                   break;
           default:
                   break;
           }
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void Undo()
        {
            Bitmap bitmap = m_history.Undo();
            if (bitmap != null)
            {
                try
                {
                    m_bitmap.Dispose();
                    m_bitmap = (Bitmap)bitmap.Clone();
                    PictureBox.Image = m_bitmap;

                }
                catch (System.Exception)
                {

                }
            }
        }

        private void Redo()
        {
            Bitmap bitmap = m_history.Redo();
            if (bitmap != null)
            {
                try
                {
                    m_bitmap.Dispose();
                    m_bitmap = (Bitmap)bitmap.Clone();
                    bitmap.Dispose();
                    PictureBox.Image = m_bitmap;

                }
                catch (System.Exception)
                {

                }
            }
        }

        private void ClockWiseMenuItem_Click(object sender, EventArgs e)
        {
            StartImageProcess();
            DoRotateBitmap(Rotate.ClockWise);
            EndImageProcess();
        }

        private void AntiClockWiseMenuItem_Click(object sender, EventArgs e)
        {
            StartImageProcess();
            DoRotateBitmap(Rotate.AntiClockWise);
            EndImageProcess();
        }

        private void HorMirror_Click(object sender, EventArgs e)
        {
            StartImageProcess();
            DoRotateBitmap(Rotate.HorMirror);
            EndImageProcess();
        }

        private void VerMirror_Click(object sender, EventArgs e)
        {
            StartImageProcess();
            DoRotateBitmap(Rotate.VerMirror);
            EndImageProcess();
        }

        private void DoRotateBitmap(Rotate rotate)
        {
            try
            {
                switch (rotate)
                {
                case Rotate.ClockWise:
                        m_bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                	break;
                case Rotate.AntiClockWise:
                        m_bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                case Rotate.HorMirror:
                        m_bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    break;
                case Rotate.VerMirror:
                        m_bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    break;
                default:
                    Debug.Assert(false);
                    return;
                }
            }
            catch (System.Exception )
            {
            	
            }

        }



        void Mainform_Resize(object sender, System.EventArgs e)
        {
            ResizeAllControls();
        }


        private void Mainform_Load(object sender, EventArgs e)
        {
            ResizeAllControls();
        }

        private void ResizeAllControls()
        {
            m_width = this.Width;
            m_height = this.Height;
            PictureBox.Height = m_height - 125;
            PictureBox.Width = m_width - 40;
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void HistMenuItem_Click(object sender, EventArgs e)
        {
            if (m_bitmap == null)
            {
                return;
            }
            TiHistogram histogram = null;
            try
            {
                BitmapData bitmapData = m_bitmap.LockBits(new Rectangle(0, 0, m_bitmap.Width, m_bitmap.Height),
                                                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                IntPtr ptr = NativeMethods.GetImageHistogram(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp);
                if (ptr != null)
                {
                    histogram = (TiHistogram)Marshal.PtrToStructure(ptr, typeof(TiHistogram));
                    Marshal.DestroyStructure(ptr, typeof(TiHistogram)); //销毁非托管的内存
                }
                m_bitmap.UnlockBits(bitmapData);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (histogram != null)
            {
                HistogramForm form = new HistogramForm(histogram);
                form.ShowDialog();
            }

        }

        void MainForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Control)
            {
                Keys key = e.KeyCode;
                switch(key)
                {
                    case Keys.Z:
                        Undo();
                        break;
                    case Keys.Y:
                        Redo();
                        break;
                    default:
                        break;   
                }
            }
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }

        private void BlendMenuItem_Click(object sender, EventArgs e)
        {
            if (m_bitmap == null)
            {
                return;
            }
            GenerateThumbBitmap();
            BlendForm form = new BlendForm(BlendModeCallback);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                bool invert = form.Invert;
                TINYIMAGE_CHANNEL channel = form.Channel;
                TINYIMAGE_BLENDMODE mode = form.BlendMode;
                double blendOpacity = form.BlendOpacity;

                StartImageProcess();
                try
                {
                    Bitmap blendBitmap = (Bitmap)m_bitmap.Clone();
                    if (invert)
                    {
                        InvertBitmap(blendBitmap);
                    }
                    BitmapData bitmapData = m_bitmap.LockBits(new Rectangle(0, 0, m_bitmap.Width, m_bitmap.Height),
                                                                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                    BitmapData blendBitmapData = blendBitmap.LockBits(new Rectangle(0, 0, blendBitmap.Width, blendBitmap.Height),
                                                                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

                    NativeMethods.BlendMode(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp,TINYIMAGE_CHANNEL.TINYIMAGE_CHANEL_RGB,
                                            blendBitmapData.Scan0, blendBitmapData.Width, blendBitmapData.Height, blendBitmapData.Stride, m_bpp,channel,
                                            mode, blendOpacity);
                    blendBitmap.UnlockBits(blendBitmapData);
                    m_bitmap.UnlockBits(bitmapData);
                    blendBitmap.Dispose();

                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Source.ToString());
                }
                EndImageProcess();

            }
            else
            {
                PictureBox.Image = m_bitmap;
            }
        }

        private void InvertBitmap(Bitmap bitmap)
        {

            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                                                        ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            
            NativeMethods.Invert(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, m_bpp);
            bitmap.UnlockBits(bitmapData);
        }

        void MainForm_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string filename = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
                OpenFile(filename);
            }
        }

        void MainForm_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
      
    }
}
