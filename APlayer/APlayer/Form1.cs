using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace APlayer
{
    public partial class Form1 : Form
    {

        WindowsMediaPlayer wmp = null;

        public Form1()
        {
            InitializeComponent();
        }

        bool isPlaying;
        string ActionStr => isPlaying ? "Pause" : "Play";
        private void button1_Click(object sender, EventArgs e)
        {
            if (isPlaying)
                wmp.controls.stop();
            else
                wmp.controls.play();
            isPlaying = !isPlaying;
            PlayandPause.Text = ActionStr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wmp.controls.stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                oFD.Filter = "MP3|*.mp3";
                wmp.URL = oFD.FileNames[0];
                PlayList.Items.AddRange(oFD.FileNames);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlayList.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
 
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            wmp.controls.previous();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            wmp.controls.next();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            wmp.settings.volume = trackBarVolume.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            wmp.controls.currentPosition = trackBarAudio.Value;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wmp = new WindowsMediaPlayer();
        }
    }
}
