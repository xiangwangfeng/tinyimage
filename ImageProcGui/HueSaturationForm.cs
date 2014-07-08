using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageProc
{
    public delegate void AdjustHueSatCallBack(int hue,int sat,int lightness,TINYIMAGE_HUERANGE hueRange);
    public partial class HueSaturationForm : Form
    {
        private int m_hue = 0;
        private int m_sat = 0;
        private int m_lightness = 0;
        private TINYIMAGE_HUERANGE m_hueRange = TINYIMAGE_HUERANGE.TINYIMAGE_HUERANGE_ALLHUES;
        private AdjustHueSatCallBack m_callback = null;
        public HueSaturationForm(AdjustHueSatCallBack callback)
        {
            InitializeComponent();
            m_callback = callback;
        }

        private void HueSaturationForm_Load(object sender, EventArgs e)
        {
            UpdateTextContent();
        }

        private void HueSlider_Scroll(object sender, EventArgs e)
        {
            m_hue = HueSlider.Value;
            UpdateTextContent();
            AdjustHueSaturation();
        }

        private void SatSlider_Scroll(object sender, EventArgs e)
        {
            m_sat = SatSlider.Value;
            UpdateTextContent();
            AdjustHueSaturation();
        }

        private void BriSlider_Scroll(object sender, EventArgs e)
        {
            m_lightness = BriSlider.Value;
            UpdateTextContent();
            AdjustHueSaturation();
        }

        private void UpdateTextContent()
        {
            HueTextBox.Text = m_hue.ToString();
            SatTextBox.Text = m_sat.ToString();
            BriTextBox.Text = m_lightness.ToString();
        }
        private void AdjustHueSaturation()
        {
            if (m_callback != null)
            {
                m_callback(m_hue,m_sat,m_lightness,m_hueRange);
            }
        }



        public int Hue
        {
            get { return m_hue; }
        }

        public int Saturation
        {
            get { return m_sat; }
        }

        public int Lightness
        {
            get { return m_lightness; }
        }

        public TINYIMAGE_HUERANGE HueRange
        {
            get { return m_hueRange; }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (!(m_hue == 0 && m_lightness ==0 && m_sat == 0))
            {
                this.DialogResult = DialogResult.OK;
            }
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HueRangeCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_hueRange = (TINYIMAGE_HUERANGE)HueRangeCombox.SelectedIndex;
            AdjustHueSaturation();
        }


    }
}
