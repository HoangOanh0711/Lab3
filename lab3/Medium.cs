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

        int score = 0, questionNumber = 1;
        string topic,correctAns;

        Image check;

        List<int> randomNumbers;

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
            //player.URL = @"G:\\Oanhhh\\c#\\image\\lab3\\sound\\nhacgame02.mp3";
            moNhac();

            var rnd = new Random();

            if (topic.Equals("color"))
            {
                randomNumbers = Enumerable.Range(1, 31).OrderBy(x => rnd.Next()).Take(5).ToList();
            }
            else if (topic.Equals("animals"))
            {
                randomNumbers = Enumerable.Range(1, 32).OrderBy(x => rnd.Next()).Take(5).ToList();
            }
            else if (topic.Equals("fruit"))
            {
                randomNumbers = Enumerable.Range(1, 32).OrderBy(x => rnd.Next()).Take(5).ToList();
            }
            else if (topic.Equals("job"))
            {
                randomNumbers = Enumerable.Range(1, 41).OrderBy(x => rnd.Next()).Take(5).ToList();
            }

            boDe(randomNumbers[questionNumber-1]);
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

        private void setQuestion(int so, string ans)
        {
            q_picture.Image = Image.FromFile("Resources/" + topic + " (" + so + ").png");
            correctAns = ans;
        }

        private void q_btncheck_Click(object sender, EventArgs e)
        {
            string text = q_text.Text.ToLower();

            if(text.Equals(correctAns))
            {
                anhDungSai(true);
                score += 2;
                s_score.Text = Convert.ToString(score);
            }
            else
            {
                anhDungSai(false);
                q_correctans.Text = "Correct answer: " + correctAns;
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            tatNhac();
            this.Hide();
            Play play = new Play();
            play.ShowDialog();
            this.Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            questionNumber++;
            q_question.Text = questionNumber.ToString();

            boDe(randomNumbers[questionNumber - 1]);

        }

        private void boDe(int soThuTu)
        {
            if (topic.Equals("fruit"))
            {
                switch (soThuTu)
                {
                    case 1:
                        setQuestion(1, "almond");
                        break;
                    case 2:
                        setQuestion(2, "apricot");
                        break;
                    case 3:
                        setQuestion(3, "avocado");
                        break;
                    case 4:
                        setQuestion(4, "bananas");
                        break;
                    case 5:
                        setQuestion(5, "capsicum");
                        break;
                    case 6:
                        setQuestion(6, "carambola");
                        break;
                    case 7:
                        setQuestion(7, "cashew");
                        break;
                    case 8:
                        setQuestion(8, "cherries");
                        break;
                    case 9:
                        setQuestion(9, "coconut");
                        break;
                    case 10:
                        setQuestion(10, "dragon-fruit");
                        break;


                    case 11:
                        setQuestion(11,   "durian");
                        break;
                    case 12:
                        setQuestion(12,  "grapes");
                        break;
                    case 13:
                        setQuestion(13,   "guava");
                        break;
                    case 14:
                        setQuestion(14,  "jackfruit");
                        break;
                    case 15:
                        setQuestion(15, "jalapeno");
                        break;
                    case 16:
                        setQuestion(16,   "lemon");
                        break;
                    case 17:
                        setQuestion(17,    "lime");
                        break;
                    case 18:
                        setQuestion(18,    "macadamia");
                        break;
                    case 19:
                        setQuestion(19,   "mango");
                        break;
                    case 20:
                        setQuestion(20,  "orange-juice");
                        break;


                    case 21:
                        setQuestion(21,   "passion-fruit");
                        break;
                    case 22:
                        setQuestion(22,  "peanut");
                        break;
                    case 23:
                        setQuestion(23,   "pear");
                        break;
                    case 24:
                        setQuestion(24,  "pineapple");
                        break;
                    case 25:
                        setQuestion(25, "plum");
                        break;
                    case 26:
                        setQuestion(26,   "pumpkin");
                        break;
                    case 27:
                        setQuestion(27,    "rambutan");
                        break;
                    case 28:
                        setQuestion(28,    "rose-apple");
                        break;
                    case 29:
                        setQuestion(29,   "sapodilla");
                        break;
                    case 30:
                        setQuestion(30,  "strawberry");
                        break;

                    case 31:
                        setQuestion(31,  "walnut");
                        break;
                    case 32:
                        setQuestion(32,  "watermelon");
                        break;

                }
            }
            //else if (topic.Equals("color"))
            //{

            //}
            //else if (topic.Equals("animals"))
            //{

            //}
            //else if (topic.Equals("job"))
            //{

            //}
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
                    pic_1.Image = check;
                    break;
                case 2:
                    pic_2.Image = check;
                    break;
                case 3:
                    pic_3.Image = check;
                    break;
                case 4:
                    pic_4.Image = check;
                    break;
                case 5:
                    pic_5.Image = check;
                    break;
            }
        }
    }
}
