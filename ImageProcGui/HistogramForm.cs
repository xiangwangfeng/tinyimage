using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageProc
{
    public partial class HistogramForm : Form
    {
        private TiHistogram m_histogram = null;
        private int[] m_currentValues = null;
        private Bitmap m_histBitmap = null;
        private Color m_color;
        public HistogramForm(TiHistogram histogram)
        {
            InitializeComponent();
            m_histogram = histogram;
            m_currentValues = m_histogram.rgbValues;
            m_color = Color.Gray;
        }

        private void HistogramForm_Load(object sender, EventArgs e)
        {
            RedrawHistorgram();
        }

        private void RedrawHistorgram()
        {
            if (m_currentValues != null)
            {
                if (m_histBitmap != null)
                {
                    m_histBitmap.Dispose();
                }
                int width = HistogramPictureBox.Width;
                int height = HistogramPictureBox.Height;
                m_histBitmap = new Bitmap(width, height);
                int maxY = 0;
                for (int i = 0; i < 256; i++)
                {
                    if (maxY <= m_currentValues[i])
                    {
                        maxY = m_currentValues[i];
                    }
                }
                float unitX = (float)width / 256;
                float unitY = (float)height / maxY;
                Graphics g = Graphics.FromImage(m_histBitmap);
                g.DrawRectangle(new Pen(Color.Black), 0, 0, width-1, height-1);
                Brush brush = new SolidBrush(m_color);
                for (int i = 0; i < 256; i++ )
                {
                    g.FillRectangle(brush, i * unitX, height - 1 - unitY * m_currentValues[i], unitX, unitY * m_currentValues[i]);
                    Console.WriteLine((height - 1 - unitY * m_currentValues[i]).ToString());
                }

                g.Dispose();

                HistogramPictureBox.Image = m_histBitmap;

                  
            }
        }

        private void ChannelComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectIndex = ChannelComBox.SelectedIndex;
            switch (selectIndex)
            {
            case 0:
                    m_currentValues = m_histogram.rgbValues;
                    m_color = Color.Gray;
            	break;
            case 1:
                    m_currentValues = m_histogram.rValues;
                    m_color = Color.Red;
            	break;
            case 2:
                    m_currentValues = m_histogram.gValues;
                    m_color = Color.Green;
            	break;
            case 3:
                    m_currentValues = m_histogram.bValues;
                    m_color = Color.Blue;
            	break;
            default:
                return;
            }
            RedrawHistorgram();
        }


    }
}
