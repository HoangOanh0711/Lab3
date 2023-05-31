using Guna.UI2.WinForms;
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
    public partial class Easy : Form
    {
        private WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private Boolean isPlay = true;

        int score = 0;
        int correctQuestion;
        int questionNumber = 0;

        List<int> randomNumbers;

        string topic;

        public Easy(string topic)
        {
            InitializeComponent();
            this.topic = topic;
        }

        private void setQuestion(int so, string btn1, string btn2, string btn3, string btn4,int correct)
        {
            q_picturre.Image = Image.FromFile("Resources/" + topic + " (" + so + ").png"); ;
            q_btn1.Text = btn1;
            q_btn2.Text = btn2;
            q_btn3.Text = btn3;
            q_btn4.Text = btn4;
            correctQuestion = correct;
        }

        private void Easy_Load(object sender, EventArgs e)
        {
            player.URL = @"G:\\Oanhhh\\c#\\image\\lab3\\sound\\nhacgame02.mp3";
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

            boDe(randomNumbers[questionNumber]);
        }

        private void boDe(int soThuTuCauHoi)
        {
            if (topic.Equals("fruit"))
            {
                switch (soThuTuCauHoi)
                {
                    case 1:
                        setQuestion(1, "almond", "", "", "", 1);
                        break;
                    case 2:
                        setQuestion(2, "", "apricot", "", "", 2);
                        break;
                    case 3:
                        setQuestion(3, "", "", "", "avocado", 4);
                        break;
                    case 4:
                        setQuestion(4, "bananas", "", "", "", 1);
                        break;
                    case 5:
                        setQuestion(5, "", "", "", "capsicum", 4);
                        break;
                    case 6:
                        setQuestion(6, "", "carambola", "", "", 2);
                        break;
                    case 7:
                        setQuestion(7, "cashew", "", "", "", 1);
                        break;
                    case 8:
                        setQuestion(8, "", "", "cherries", "", 3);
                        break;
                    case 9:
                        setQuestion(9, "", "", "", "coconut", 4);
                        break;
                    case 10:
                        setQuestion(10, "", "", "", "dragon-fruit", 4);
                        break;


                    case 11:
                        setQuestion(11, "", "", "durian", "", 3);
                        break;
                    case 12:
                        setQuestion(12, "", "grapes", "", "", 2);
                        break;
                    case 13:
                        setQuestion(13, "", "", "guava", "", 3);
                        break;
                    case 14:
                        setQuestion(14, "", "jackfruit", "", "", 2);
                        break;
                    case 15:
                        setQuestion(15, "jalapeno", "", "", "", 1);
                        break;
                    case 16:
                        setQuestion(16, "", "", "lemon", "", 3);
                        break;
                    case 17:
                        setQuestion(17, "", "", "", "lime", 4);
                        break;
                    case 18:
                        setQuestion(18, "", "", "", "macadamia", 4);
                        break;
                    case 19:
                        setQuestion(19, "", "", "mango", "", 3);
                        break;
                    case 20:
                        setQuestion(20, "", "orange-juice", "", "", 2);
                        break;


                    case 21:
                        setQuestion(21, "", "", "passion-fruit", "", 3);
                        break;
                    case 22:
                        setQuestion(22, "", "peanut", "", "", 2);
                        break;
                    case 23:
                        setQuestion(23, "", "", "pear", "", 3);
                        break;
                    case 24:
                        setQuestion(24, "", "pineapple", "", "", 2);
                        break;
                    case 25:
                        setQuestion(25, "plum", "", "", "", 1);
                        break;
                    case 26:
                        setQuestion(26, "", "", "pumpkin", "", 3);
                        break;
                    case 27:
                        setQuestion(27, "", "", "", "rambutan", 4);
                        break;
                    case 28:
                        setQuestion(28, "", "", "", "rose-apple", 4);
                        break;
                    case 29:
                        setQuestion(29, "", "", "sapodilla", "", 3);
                        break;
                    case 30:
                        setQuestion(30, "", "strawberry", "", "", 2);
                        break;

                    case 31:
                        setQuestion(31, "", "walnut", "", "", 2);
                        break;
                    case 32:
                        setQuestion(32, "", "watermelon", "", "", 2);
                        break;

                }
            }
            else if (topic.Equals("color"))
            {
                switch (soThuTuCauHoi)
                {
                    case 1:
                        setQuestion(1, "almond", "", "", "", 1);
                        break;
                    case 2:
                        setQuestion(2, "", "apricot", "", "", 2);
                        break;
                    case 3:
                        setQuestion(3, "", "", "", "avocado", 4);
                        break;
                    case 4:
                        setQuestion(4, "bananas", "", "", "", 1);
                        break;
                    case 5:
                        setQuestion(5, "", "", "", "capsicum", 4);
                        break;
                    case 6:
                        setQuestion(6, "", "carambola", "", "", 2);
                        break;
                    case 7:
                        setQuestion(7, "cashew", "", "", "", 1);
                        break;
                    case 8:
                        setQuestion(8, "", "", "cherries", "", 3);
                        break;
                    case 9:
                        setQuestion(9, "", "", "", "coconut", 4);
                        break;
                    case 10:
                        setQuestion(10, "", "", "", "dragon-fruit", 4);
                        break;


                    case 11:
                        setQuestion(11, "", "", "durian", "", 3);
                        break;
                    case 12:
                        setQuestion(12, "", "grapes", "", "", 2);
                        break;
                    case 13:
                        setQuestion(13, "", "", "guava", "", 3);
                        break;
                    case 14:
                        setQuestion(14, "", "jackfruit", "", "", 2);
                        break;
                    case 15:
                        setQuestion(15, "jalapeno", "", "", "", 1);
                        break;
                    case 16:
                        setQuestion(16, "", "", "lemon", "", 3);
                        break;
                    case 17:
                        setQuestion(17, "", "", "", "lime", 4);
                        break;
                    case 18:
                        setQuestion(18, "", "", "", "macadamia", 4);
                        break;
                    case 19:
                        setQuestion(19, "", "", "mango", "", 3);
                        break;
                    case 20:
                        setQuestion(20, "", "orange-juice", "", "", 2);
                        break;


                    case 21:
                        setQuestion(21, "", "", "passion-fruit", "", 3);
                        break;
                    case 22:
                        setQuestion(22, "", "peanut", "", "", 2);
                        break;
                    case 23:
                        setQuestion(23, "", "", "pear", "", 3);
                        break;
                    case 24:
                        setQuestion(24, "", "pineapple", "", "", 2);
                        break;
                    case 25:
                        setQuestion(25, "plum", "", "", "", 1);
                        break;
                    case 26:
                        setQuestion(26, "", "", "pumpkin", "", 3);
                        break;
                    case 27:
                        setQuestion(27, "", "", "", "rambutan", 4);
                        break;
                    case 28:
                        setQuestion(28, "", "", "", "rose-apple", 4);
                        break;
                    case 29:
                        setQuestion(29, "", "", "sapodilla", "", 3);
                        break;
                    case 30:
                        setQuestion(30, "", "strawberry", "", "", 2);
                        break;

                    case 31:
                        setQuestion(31, "", "walnut", "", "", 2);
                        break;
                    case 32:
                        setQuestion(32, "", "watermelon", "", "", 2);
                        break;

                }
            }
            else if (topic.Equals("animals"))
            {
                switch (soThuTuCauHoi)
                {
                    case 1:
                        setQuestion(1, "almond", "", "", "", 1);
                        break;
                    case 2:
                        setQuestion(2, "", "apricot", "", "", 2);
                        break;
                    case 3:
                        setQuestion(3, "", "", "", "avocado", 4);
                        break;
                    case 4:
                        setQuestion(4, "bananas", "", "", "", 1);
                        break;
                    case 5:
                        setQuestion(5, "", "", "", "capsicum", 4);
                        break;
                    case 6:
                        setQuestion(6, "", "carambola", "", "", 2);
                        break;
                    case 7:
                        setQuestion(7, "cashew", "", "", "", 1);
                        break;
                    case 8:
                        setQuestion(8, "", "", "cherries", "", 3);
                        break;
                    case 9:
                        setQuestion(9, "", "", "", "coconut", 4);
                        break;
                    case 10:
                        setQuestion(10, "", "", "", "dragon-fruit", 4);
                        break;


                    case 11:
                        setQuestion(11, "", "", "durian", "", 3);
                        break;
                    case 12:
                        setQuestion(12, "", "grapes", "", "", 2);
                        break;
                    case 13:
                        setQuestion(13, "", "", "guava", "", 3);
                        break;
                    case 14:
                        setQuestion(14, "", "jackfruit", "", "", 2);
                        break;
                    case 15:
                        setQuestion(15, "jalapeno", "", "", "", 1);
                        break;
                    case 16:
                        setQuestion(16, "", "", "lemon", "", 3);
                        break;
                    case 17:
                        setQuestion(17, "", "", "", "lime", 4);
                        break;
                    case 18:
                        setQuestion(18, "", "", "", "macadamia", 4);
                        break;
                    case 19:
                        setQuestion(19, "", "", "mango", "", 3);
                        break;
                    case 20:
                        setQuestion(20, "", "orange-juice", "", "", 2);
                        break;


                    case 21:
                        setQuestion(21, "", "", "passion-fruit", "", 3);
                        break;
                    case 22:
                        setQuestion(22, "", "peanut", "", "", 2);
                        break;
                    case 23:
                        setQuestion(23, "", "", "pear", "", 3);
                        break;
                    case 24:
                        setQuestion(24, "", "pineapple", "", "", 2);
                        break;
                    case 25:
                        setQuestion(25, "plum", "", "", "", 1);
                        break;
                    case 26:
                        setQuestion(26, "", "", "pumpkin", "", 3);
                        break;
                    case 27:
                        setQuestion(27, "", "", "", "rambutan", 4);
                        break;
                    case 28:
                        setQuestion(28, "", "", "", "rose-apple", 4);
                        break;
                    case 29:
                        setQuestion(29, "", "", "sapodilla", "", 3);
                        break;
                    case 30:
                        setQuestion(30, "", "strawberry", "", "", 2);
                        break;

                    case 31:
                        setQuestion(31, "", "walnut", "", "", 2);
                        break;
                    case 32:
                        setQuestion(32, "", "watermelon", "", "", 2);
                        break;

                }
            }
            else if (topic.Equals("job"))
            {
                switch (soThuTuCauHoi)
                {
                    case 1:
                        setQuestion(1, "almond", "", "", "", 1);
                        break;
                    case 2:
                        setQuestion(2, "", "apricot", "", "", 2);
                        break;
                    case 3:
                        setQuestion(3, "", "", "", "avocado", 4);
                        break;
                    case 4:
                        setQuestion(4, "bananas", "", "", "", 1);
                        break;
                    case 5:
                        setQuestion(5, "", "", "", "capsicum", 4);
                        break;
                    case 6:
                        setQuestion(6, "", "carambola", "", "", 2);
                        break;
                    case 7:
                        setQuestion(7, "cashew", "", "", "", 1);
                        break;
                    case 8:
                        setQuestion(8, "", "", "cherries", "", 3);
                        break;
                    case 9:
                        setQuestion(9, "", "", "", "coconut", 4);
                        break;
                    case 10:
                        setQuestion(10, "", "", "", "dragon-fruit", 4);
                        break;


                    case 11:
                        setQuestion(11, "", "", "durian", "", 3);
                        break;
                    case 12:
                        setQuestion(12, "", "grapes", "", "", 2);
                        break;
                    case 13:
                        setQuestion(13, "", "", "guava", "", 3);
                        break;
                    case 14:
                        setQuestion(14, "", "jackfruit", "", "", 2);
                        break;
                    case 15:
                        setQuestion(15, "jalapeno", "", "", "", 1);
                        break;
                    case 16:
                        setQuestion(16, "", "", "lemon", "", 3);
                        break;
                    case 17:
                        setQuestion(17, "", "", "", "lime", 4);
                        break;
                    case 18:
                        setQuestion(18, "", "", "", "macadamia", 4);
                        break;
                    case 19:
                        setQuestion(19, "", "", "mango", "", 3);
                        break;
                    case 20:
                        setQuestion(20, "", "orange-juice", "", "", 2);
                        break;


                    case 21:
                        setQuestion(21, "", "", "passion-fruit", "", 3);
                        break;
                    case 22:
                        setQuestion(22, "", "peanut", "", "", 2);
                        break;
                    case 23:
                        setQuestion(23, "", "", "pear", "", 3);
                        break;
                    case 24:
                        setQuestion(24, "", "pineapple", "", "", 2);
                        break;
                    case 25:
                        setQuestion(25, "plum", "", "", "", 1);
                        break;
                    case 26:
                        setQuestion(26, "", "", "pumpkin", "", 3);
                        break;
                    case 27:
                        setQuestion(27, "", "", "", "rambutan", 4);
                        break;
                    case 28:
                        setQuestion(28, "", "", "", "rose-apple", 4);
                        break;
                    case 29:
                        setQuestion(29, "", "", "sapodilla", "", 3);
                        break;
                    case 30:
                        setQuestion(30, "", "strawberry", "", "", 2);
                        break;

                    case 31:
                        setQuestion(31, "", "walnut", "", "", 2);
                        break;
                    case 32:
                        setQuestion(32, "", "watermelon", "", "", 2);
                        break;

                }
            }

        }

        private void checkAns(object sender, EventArgs e)
        {
            var senderObject = (Guna2Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (questionNumber < 3)
            {
                if (buttonTag == correctQuestion)
                {
                    score += 2;
                    s_score.Text = Convert.ToString(score);

                }
                questionNumber++;
                q_cau.Text = Convert.ToString(score + 1);
                boDe(randomNumbers[questionNumber]);
            }

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
