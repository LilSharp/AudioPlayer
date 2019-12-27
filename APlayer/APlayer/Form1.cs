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
        string ActionStr => isPlaying ? "Pause" : "Play";
        public void PlayOrPause()
        {
            if (isPlaying)
                wmp.controls.pause();
            else
                wmp.controls.play();
            isPlaying = !isPlaying;
            PlayandPause.Text = ActionStr;
        }

        public void ForcePlay()
        {
            if (isPlaying) 
                return;
            PlayOrPause();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayOrPause();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wmp.controls.stop();
        }

        HashSet<string> playlist = new HashSet<string>();
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
                playlist.UnionWith(oFD.FileNames);
                wmp.URL = oFD.FileNames[0];
                ShowPlaylist();
                ForcePlay();
            }
        }

        public void ForceStop()
        {
            if (!isPlaying)
                return;
            PlayOrPause();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            PlayList.Items.Clear();
            playlist.Clear();
            wmp.controls.stop();
            ForceStop();
            wmp = null;
            wmp = new WindowsMediaPlayer();
        }

        private void button5_Click(object sender, EventArgs e)
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