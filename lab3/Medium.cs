using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Medium : Form
    {
        private WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private Boolean isPlay = true;

        int score = 0;
        string topic;

        public Medium(string topic)
        {
            InitializeComponent();
            this.topic = topic;
        }

        private void guna2CirclePictureBox6_Click(object sender, EventArgs e)
        {
            if (isPlay == true)
            {
                tatNhac();
            }
            else if (isPlay == false)
            {
                moNhac();
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            player.URL = @"G:\\Oanhhh\\c#\\image\\lab3\\sound\\nhacgame02.mp3";
            moNhac();
        }

        private void tatNhac()
        {
            isPlay = false;
            player.controls.stop();
            guna2CirclePictureBox6.Image = Image.FromFile("G:\\Oanhhh\\c#\\lab3\\lab3\\Resources\\volume-mute.png");

        }

        private void moNhac()
        {
            isPlay = true;
            player.controls.play();
            guna2CirclePictureBox6.Image = Image.FromFile("G:\\Oanhhh\\c#\\lab3\\lab3\\Resources\\volume.png");
        }
    }
}
