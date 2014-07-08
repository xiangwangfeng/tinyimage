using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageProc
{
    public delegate void AdjustLevelCallback(int black, int white, double gamma, TINYIMAGE_CHANNEL channel);
    public partial class LevelsForm : Form
    {
        private AdjustLevelCallback m_callback = null;
        private int m_blackThreshold = 0;
        private int m_whiteThreshold = 255;
        private double m_gamma = 1.0;
        private TINYIMAGE_CHANNEL m_channel = TINYIMAGE_CHANNEL.TINYIMAGE_CHANEL_RGB;
        public LevelsForm(AdjustLevelCallback callback)
        {
            InitializeComponent();
            m_callback = callback;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (!(m_blackThreshold == 0 && m_whiteThreshold != 255
                && m_gamma != 1.0))
            {
                this.DialogResult = DialogResult.OK;
            }
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BlackSlider_Scroll(object sender, EventArgs e)
        {
            m_blackThreshold = BlackSlider.Value;
            BlackText.Text = m_blackThreshold.ToString();
            WhiteSlider.Minimum = BlackSlider.Value + 1;
            AdjustLevels();
        }

        private void WhiteSlider_Scroll(object sender, EventArgs e)
        {
            m_whiteThreshold = WhiteSlider.Value;
            WhiteText.Text = m_whiteThreshold.ToString();
            BlackSlider.Maximum = WhiteSlider.Value - 1 ;
            AdjustLevels();
        }

        private void GammaSlider_Scroll(object sender, EventArgs e)
        {
            m_gamma = (double)(GammaSlider.Value) / GammaSlider.Maximum * 10.0;
            GammText.Text = m_gamma.ToString("f2");
            AdjustLevels();
        }

        private void AdjustLevels()
        {
            if (m_callback != null)
            {
                m_callback(m_blackThreshold, m_whiteThreshold, m_gamma, m_channel);
            }
        }

        private void AdjustLevelForm_Load(object sender, EventArgs e)
        {
            BlackText.Text = BlackSlider.Value.ToString();
            WhiteText.Text = WhiteSlider.Value.ToString();
            GammText.Text = ((double)(GammaSlider.Value) / GammaSlider.Maximum * 10.0).ToString("f2");
        }


        void CancelBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void ChannelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_channel = (TINYIMAGE_CHANNEL)ChannelBox.SelectedIndex;
            AdjustLevels();
        }

        public int BlackThreshold
        {
            get { return m_blackThreshold; }
        }

        public int WhiteThreshold
        {
            get { return m_whiteThreshold; }
        }

        public double Gamma
        {
            get { return m_gamma; }
        }

        public TINYIMAGE_CHANNEL Channel
        {
            get { return m_channel; }
        }


    }
}
