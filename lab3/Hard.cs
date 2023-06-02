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
    public partial class Hard : Form
    {
        private WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private Boolean isPlay = true;

        int score = 0, correctQuestion, questionNumber = 1;

        List<int> randomNumbers;

        string topic;

        private void Hard_Load(object sender, EventArgs e)
        {
            moNhac();
        }

        Image check;
        public Hard(string topic)
        {
            InitializeComponent();
            this.topic = topic;
        }

        private void moNhac()
        {
            isPlay = true;
            player.controls.play();
            guna2CirclePictureBox6.Image = Image.FromFile("G:\\Oanhhh\\c#\\lab3\\lab3\\Resources\\volume.png");
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

        private void q_next_Click(object sender, EventArgs e)
        {
            if (questionNumber < 5)
            {
                questionNumber++;
                q_cau.Text = Convert.ToString(questionNumber);
                //boDe(randomNumbers[questionNumber - 1]);

            }
        }

        private void q_back_Click(object sender, EventArgs e)
        {
            if (questionNumber > 1)
            {
                questionNumber--;
                q_cau.Text = Convert.ToString(questionNumber);
                //boDe(randomNumbers[questionNumber - 1]);


            }
        }

        private void tatNhac()
        {
            isPlay = false;
            player.controls.stop();
            guna2CirclePictureBox6.Image = Image.FromFile("G:\\Oanhhh\\c#\\lab3\\lab3\\Resources\\volume-mute.png");
        }

        private void anhDungSai(Boolean isTrue)
        {
            if (isTrue == true)
            {
                check = Image.FromFile("Resources/check.png");
            }
            else if (isTrue == false)
            {
                check = Image.FromFile("Resources/cancel.png");
            }

            switch (questionNumber)
            {
                case 1:
                    s_check1.Image = check;
                    break;
                case 2:
                    s_check2.Image = check;
                    break;
                case 3:
                    s_check3.Image = check;
                    break;
                case 4:
                    s_check4.Image = check;
                    break;
                case 5:
                    s_check5.Image = check;
                    break;
            }
        }
    }
}
