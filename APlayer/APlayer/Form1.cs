using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        string ActionStr => isPlaying ? "Play" : "Pause";
        private void button1_Click(object sender, EventArgs e)
        {
            if (isPlaying)
                wmp.controls.play();
            else
                wmp.controls.pause();
            isPlaying = !isPlaying;
            PlayandPause.Text = ActionStr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wmp.controls.stop();
        }

        List<string> playlist = new List<string>();
        public void ShowPlaylist()
        {
            var names = playlist.Select(path => Path.GetFileNameWithoutExtension(path));
            PlayList.Items.Clear();
            PlayList.Items.AddRange(names.ToArray());
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Multiselect = true;
            oFD.Filter = "MP3|*.mp3";
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                playlist.AddRange(oFD.FileNames);
                wmp.URL = playlist[0];
                ShowPlaylist();
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
