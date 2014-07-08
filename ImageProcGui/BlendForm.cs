using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageProc
{
    public delegate void BlendModeCallBack(TINYIMAGE_BLENDMODE mode,double opacity,TINYIMAGE_CHANNEL channel,bool invert);
    public partial class BlendForm : Form
    {
        private BlendModeCallBack m_callback = null;
        private TINYIMAGE_BLENDMODE m_blendMode = TINYIMAGE_BLENDMODE.TINYIMAGE_BLENDMODE_DARKEN;
        private double m_opacity = 1.00;
        private TINYIMAGE_CHANNEL m_channel = TINYIMAGE_CHANNEL.TINYIMAGE_CHANEL_RGB;
        private bool m_bInvert = false;
        public BlendForm(BlendModeCallBack callback)
        {
            InitializeComponent();
            m_callback = callback;
            RaiseBlendEvent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }


        private void RaiseBlendEvent()
        {
            if (m_callback != null)
            {
                m_callback(m_blendMode, m_opacity, m_channel,m_bInvert);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


        public TINYIMAGE_BLENDMODE BlendMode
        {
            get { return m_blendMode; }
        }

        public double BlendOpacity
        {
            get { return m_opacity; }
        }

        public TINYIMAGE_CHANNEL Channel
        {
            get { return m_channel; }
        }

        public bool Invert
        {
            get { return m_bInvert; }
        }

        private void InvertCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            m_bInvert = InvertCheckBox.Checked;
            RaiseBlendEvent();
        }

        private void ChannelCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_channel = (TINYIMAGE_CHANNEL)ChannelCombox.SelectedIndex;
            RaiseBlendEvent();
        }

        private void ModeCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_blendMode = (TINYIMAGE_BLENDMODE)ModeCombox.SelectedIndex;
            RaiseBlendEvent();
        }


        private void OpacityTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = OpacityTextBox.Text;
            int opacity;
            if (Int32.TryParse(text,out opacity))
            {
                if (opacity > 100)
                {
                    opacity = 100;
                }
                else if (opacity < 0)
                {
                    opacity = 0;
                }
                else
                {
                    m_opacity = opacity / 100.0;
                    RaiseBlendEvent();
                    return;
                }
            }
            else
            {
                opacity = 100;
            }
            OpacityTextBox.Text = opacity.ToString();

        }


      
    }
}
