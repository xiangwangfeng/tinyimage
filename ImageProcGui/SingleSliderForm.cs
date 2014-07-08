using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageProc
{
    public delegate void SliderChangedCallback(double percent);
    public partial class SingleSliderForm : Form
    {
        private SliderChangedCallback m_callback = null;
        private double m_percent = 0.0;
        public SingleSliderForm(string caption,SliderChangedCallback callback)
        {
            InitializeComponent();
            m_callback = callback;
            this.Text = caption;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (m_percent != 0.0)
            {
                this.DialogResult = DialogResult.OK;
            }
            Close();
        }


        private void Slider_Scroll(object sender, EventArgs e)
        {
            m_percent = (double)(Slider.Value) / Slider.Maximum;
            UpdateSliderText();
            if (m_callback!= null)
            {
                m_callback(m_percent);
            }
        }

        private void UpdateSliderText()
        {
            SliderText.Text = m_percent.ToString("f2");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SingleSliderForm_Load(object sender, EventArgs e)
        {
            UpdateSliderText();
        }

        public double Percent
        {
            get {return m_percent; }
        }


    }
}
