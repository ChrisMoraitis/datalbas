using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;


namespace TTS_Eng_text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //make speech synthesis
        SpeechSynthesizer speaker = new SpeechSynthesizer();

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (richTextBoxTTS.Text != "")
            {
                speaker.Dispose();
                speaker = new SpeechSynthesizer();
                speaker.SpeakAsync(richTextBoxTTS.Text);
            }
            else
            {
                MessageBox.Show("Please enter a text first!");
            }
        }
    }
}
