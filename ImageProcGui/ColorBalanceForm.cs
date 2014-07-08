using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageProc
{
    public delegate void ColorBalanceCallBack(int cyan, int magenta, int yellow,TINYIMAGE_TRANSFERMODE mode,bool preserveLuminosity);
    public partial class ColorBalanceForm : Form
    {
        private ColorBalanceCallBack m_callback = null;
        private int m_red = 0;
        private int m_green = 0;
        private int m_blue = 0;
        private TINYIMAGE_TRANSFERMODE m_mode = 
            TINYIMAGE_TRANSFERMODE.TINYIMAGE_TRANSFERMODE_MIDTONES;
        private bool m_preserveLuminosity = true;
        public ColorBalanceForm(ColorBalanceCallBack callback)
        {
            InitializeComponent();
            m_callback = callback;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (!(m_red == 0 && m_green == 0 && m_blue == 0))
            {
                this.DialogResult = DialogResult.OK;
            }
            Close();
        }

        private void MidtoneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            m_mode = TINYIMAGE_TRANSFERMODE.TINYIMAGE_TRANSFERMODE_MIDTONES;
            ResetSliders();
        }

        private void HighLightenRatioButton_CheckedChanged(object sender, EventArgs e)
        {
            m_mode = TINYIMAGE_TRANSFERMODE.TINYIMAGE_TRANSFERMODE_HIGHLIGHTS;
            ResetSliders();
        }

        private void ShadowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            m_mode = TINYIMAGE_TRANSFERMODE.TINYIMAGE_TRANSFERMODE_SHADOWS;
            ResetSliders();
        }

        private void ResetSliders()
        {
            RedSlider.Value = 0;
            GreenSlider.Value = 0;
            BlueSlider.Value = 0;
            InitTextBlocks();
        }

        private void InitTextBlocks()
        {
            m_red = RedSlider.Value;
            m_green = GreenSlider.Value;
            m_blue = BlueSlider.Value;
            RedBox.Text = m_red.ToString();
            GreenBox.Text = m_green.ToString();
            BlueBox.Text = m_blue.ToString();
        }

        private void ColorBalanceForm_Load(object sender, EventArgs e)
        {
            InitTextBlocks();
            m_preserveLuminosity = (bool)PLCheckBox.Checked;
        }

        private void RedSlider_Scroll(object sender, EventArgs e)
        {
            m_red = RedSlider.Value;
            RedBox.Text = m_red.ToString();
            RaiseBalanceColorEvent();
        }

        private void GreenSlider_Scroll(object sender, EventArgs e)
        {
            m_green = GreenSlider.Value;
            GreenBox.Text = m_green.ToString();
            RaiseBalanceColorEvent();
        }

        private void BlueSlider_Scroll(object sender, EventArgs e)
        {
            m_blue = BlueSlider.Value;
            BlueBox.Text = m_blue.ToString();
            RaiseBalanceColorEvent();
        }

        private void RaiseBalanceColorEvent()
        {
            if (m_callback != null)
            {
                int cyan = m_red;
                int magenta = m_green;
                int yellow = m_blue;
                TINYIMAGE_TRANSFERMODE mode = m_mode;
                bool preserveLuminosity = m_preserveLuminosity;

                m_callback(cyan, magenta, yellow, mode, preserveLuminosity);
            }
        }

        private void PLCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            m_preserveLuminosity = (bool)PLCheckBox.Checked;
        }

        public int Red
        {
            get { return m_red; }
        }

        public int Green
        {
            get { return m_green; }
        }

        public int Blue
        {
            get { return m_blue; }
        }

        public bool PreserveLuminosity 
        {
            get { return m_preserveLuminosity; }
        }

        public TINYIMAGE_TRANSFERMODE TransferMode
        {
            get { return m_mode; }
        }



    }
}
