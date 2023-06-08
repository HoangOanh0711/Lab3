using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel.Application;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Medium : Form
    {
        private WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private Boolean isPlay = true;

        int score = 0, questionNumber = 1;
        string topic,correctAns,topic2;

        Image check;

        List<int> randomNumbers;

        Excel excel = new Excel();
        Workbook wb;
        Worksheet ws;
        Range range;

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

            var rnd = new Random();

            if (topic.Equals("color"))
            {
                topic2 = "Color";
                randomNumbers = Enumerable.Range(1, 31).OrderBy(x => rnd.Next()).Take(5).ToList();
            }
            else if (topic.Equals("animals"))
            {
                topic2 = "Animal";
                randomNumbers = Enumerable.Range(1, 32).OrderBy(x => rnd.Next()).Take(5).ToList();
            }
            else if (topic.Equals("fruit"))
            {
                topic2 = "Fruit";
                randomNumbers = Enumerable.Range(1, 32).OrderBy(x => rnd.Next()).Take(5).ToList();
            }
            else if (topic.Equals("job"))
            {
                topic2 = "Job";
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
            checkAns();
        }

        private void checkAns()
        {
            string text = q_text.Text.ToLower();

            if (text.Equals(correctAns))
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
            wb = excel.Workbooks.Open(Program.filePathExcel);
            ws = wb.Worksheets["Medium"];
            range = ws.UsedRange;

            int id = ws.UsedRange.Rows.Count + 1;
            Range cells = ws.Range[$"A{id}:D{id}"];
            string[] things = { $"{id}", topic2, Convert.ToString(score), DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") };
            cells.set_Value(XlRangeValueDataType.xlRangeValueDefault, things);

            wb.Save();
            wb.Close();
            excel.Quit();


            tatNhac();
            this.Hide();
            Play play = new Play();
            play.ShowDialog();
            this.Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (questionNumber < 5)
            {
                questionNumber++;
                q_question.Text = Convert.ToString(questionNumber);
                boDe(randomNumbers[questionNumber - 1]);
                q_correctans.Text = "";
                q_text.Text = "";
            }

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
                        setQuestion(11, "durian");
                        break;
                    case 12:
                        setQuestion(12, "grapes");
                        break;
                    case 13:
                        setQuestion(13, "guava");
                        break;
                    case 14:
                        setQuestion(14, "jackfruit");
                        break;
                    case 15:
                        setQuestion(15, "jalapeno");
                        break;
                    case 16:
                        setQuestion(16, "lemon");
                        break;
                    case 17:
                        setQuestion(17, "lime");
                        break;
                    case 18:
                        setQuestion(18, "macadamia");
                        break;
                    case 19:
                        setQuestion(19, "mango");
                        break;
                    case 20:
                        setQuestion(20, "orange-juice");
                        break;


                    case 21:
                        setQuestion(21, "passion-fruit");
                        break;
                    case 22:
                        setQuestion(22, "peanut");
                        break;
                    case 23:
                        setQuestion(23, "pear");
                        break;
                    case 24:
                        setQuestion(24, "pineapple");
                        break;
                    case 25:
                        setQuestion(25, "plum");
                        break;
                    case 26:
                        setQuestion(26, "pumpkin");
                        break;
                    case 27:
                        setQuestion(27, "rambutan");
                        break;
                    case 28:
                        setQuestion(28, "rose-apple");
                        break;
                    case 29:
                        setQuestion(29, "sapodilla");
                        break;
                    case 30:
                        setQuestion(30, "strawberry");
                        break;

                    case 31:
                        setQuestion(31, "walnut");
                        break;
                    case 32:
                        setQuestion(32, "watermelon");
                        break;

                }
            }
            else if (topic.Equals("color"))
            {
                switch (soThuTu)
                {
                    case 1:
                        setQuestion(1, "babyblue");
                        break;
                    case 2:
                        setQuestion(2, "berry");
                        break;
                    case 3:
                        setQuestion(3, "black");
                        break;
                    case 4:
                        setQuestion(4, "brick");
                        break;
                    case 5:
                        setQuestion(5, "brown");
                        break;
                    case 6:
                        setQuestion(6, "caramel");
                        break;
                    case 7:
                        setQuestion(7, "carrot ");
                        break;
                    case 8:
                        setQuestion(8, "darkgreen");
                        break;
                    case 9:
                        setQuestion(9, "darkred");
                        break;
                    case 10:
                        setQuestion(10, "flamingo");
                        break;
                    case 11:
                        setQuestion(11, "forest");
                        break;
                    case 12:
                        setQuestion(12, "gray");
                        break;
                    case 13:
                        setQuestion(13, "green");
                        break;
                    case 14:
                        setQuestion(14, "indigo");
                        break;
                    case 15:
                        setQuestion(15, "lavender");
                        break;
                    case 16:
                        setQuestion(16, "lightgray");
                        break;
                    case 17:
                        setQuestion(17, "lime");
                        break;
                    case 18:
                        setQuestion(18, "navy");
                        break;
                    case 19:
                        setQuestion(19, "neonpink");
                        break;
                    case 20:
                        setQuestion(20, "orange");
                        break;
                    case 21:
                        setQuestion(21, "pink");
                        break;
                    case 22:
                        setQuestion(22, "plum");
                        break;
                    case 23:
                        setQuestion(23, "purple");
                        break;
                    case 24:
                        setQuestion(24, "red");
                        break;
                    case 25:
                        setQuestion(25, "rose");
                        break;
                    case 26:
                        setQuestion(26, "salmon");
                        break;
                    case 27:
                        setQuestion(27, "seafoam");
                        break;
                    case 28:
                        setQuestion(28, "skyblue");
                        break;
                    case 29:
                        setQuestion(29, "white");
                        break;
                    case 30:
                        setQuestion(30, "wine");
                        break;
                    case 31:
                        setQuestion(31, "yellow");
                        break;

                }
            }
            else if (topic.Equals("animals"))
            {
                switch (soThuTu)
                {
                    case 1:
                        setQuestion(1, "bee");
                        break;
                    case 2:
                        setQuestion(2, "butterfly");
                        break;
                    case 3:
                        setQuestion(3, "cat");
                        break;
                    case 4:
                        setQuestion(4, "chameleon");
                        break;
                    case 5:
                        setQuestion(5, "crab");
                        break;
                    case 6:
                        setQuestion(6, "dog");
                        break;
                    case 7:
                        setQuestion(7, "dolphin");
                        break;
                    case 8:
                        setQuestion(8, "duck");
                        break;
                    case 9:
                        setQuestion(9, "ducky");
                        break;
                    case 10:
                        setQuestion(10, "elephant");
                        break;
                    case 11:
                        setQuestion(11, "fish");
                        break;
                    case 12:
                        setQuestion(12, "frog");
                        break;
                    case 13:
                        setQuestion(13, "giraffe");
                        break;
                    case 14:
                        setQuestion(14, "hedgehog");
                        break;
                    case 15:
                        setQuestion(15, "hen");
                        break;
                    case 16:
                        setQuestion(16, "kangaroo");
                        break;
                    case 17:
                        setQuestion(17, "lion");
                        break;
                    case 18:
                        setQuestion(18, "octopus");
                        break;
                    case 19:
                        setQuestion(19, "parrot");
                        break;
                    case 20:
                        setQuestion(20, "penguin");
                        break;
                    case 21:
                        setQuestion(21, "pig");
                        break;
                    case 22:
                        setQuestion(22, "rabbit");
                        break;
                    case 23:
                        setQuestion(23, "rat");
                        break;
                    case 24:
                        setQuestion(24, "seahorse");
                        break;
                    case 25:
                        setQuestion(25, "shrimp");
                        break;
                    case 26:
                        setQuestion(26, "snail");
                        break;
                    case 27:
                        setQuestion(27, "snake");
                        break;
                    case 28:
                        setQuestion(28, "squirrel");
                        break;
                    case 29:
                        setQuestion(29, "tiger");
                        break;
                    case 30:
                        setQuestion(30, "turtle");
                        break;
                    case 31:
                        setQuestion(31, "whale");
                        break;
                }
            }
            else if (topic.Equals("job"))
            {
                switch (soThuTu)
                {
                    case 1:
                        setQuestion(1, "academic");
                        break;
                    case 2:
                        setQuestion(2, "astronaut");
                        break;
                    case 3:
                        setQuestion(3, "builder");
                        break;
                    case 4:
                        setQuestion(4, "businessman");
                        break;
                    case 5:
                        setQuestion(5, "captain");
                        break;
                    case 6:
                        setQuestion(6, "chef");
                        break;
                    case 7:
                        setQuestion(7, "concierge");
                        break;
                    case 8:
                        setQuestion(8, "courier");
                        break;
                    case 9:
                        setQuestion(9, "croupier");
                        break;
                    case 10:
                        setQuestion(10, "detective");
                        break;
                    case 11:
                        setQuestion(11, "doctor");
                        break;
                    case 12:
                        setQuestion(12, "electrician");
                        break;
                    case 13:
                        setQuestion(13, "farmer");
                        break;
                    case 14:
                        setQuestion(14, "firefighter");
                        break;
                    case 15:
                        setQuestion(15, "flight-attendant");
                        break;
                    case 16:
                        setQuestion(16, "hacker");
                        break;
                    case 17:
                        setQuestion(17, "hairdresser");
                        break;
                    case 18:
                        setQuestion(18, "hostess");
                        break;
                    case 19:
                        setQuestion(19, "lab-technician");
                        break;
                    case 20:
                        setQuestion(20, "loader");
                        break;
                    case 21:
                        setQuestion(21, "magician");
                        break;
                    case 22:
                        setQuestion(22, "miner");
                        break;
                    case 23:
                        setQuestion(23, "musician");
                        break;
                    case 24:
                        setQuestion(24, "painter");
                        break;
                    case 25:
                        setQuestion(25, "pilot");
                        break;
                    case 26:
                        setQuestion(26, "policeman");
                        break;
                    case 27:
                        setQuestion(27, "postman");
                        break;
                    case 28:
                        setQuestion(28, "programmer");
                        break;
                    case 29:
                        setQuestion(29, "reporter");
                        break;
                    case 30:
                        setQuestion(30, "salesman");
                        break;
                    case 31:
                        setQuestion(31, "scientist");
                        break;
                    case 32:
                        setQuestion(32, "sheriff");
                        break;
                    case 33:
                        setQuestion(33, "soldier");
                        break;
                    case 34:
                        setQuestion(34, "student");
                        break;
                    case 35:
                        setQuestion(35, "surgeon");
                        break;
                    case 36:
                        setQuestion(36, "swat");
                        break;
                    case 37:
                        setQuestion(37, "teacher");
                        break;
                    case 38:
                        setQuestion(38, "thief");
                        break;
                    case 39:
                        setQuestion(39, "veterinarian");
                        break;
                    case 40:
                        setQuestion(40, "welder");
                        break;
                    case 41:
                        setQuestion(41, "worker");
                        break;
                }
            }
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
