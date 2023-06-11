using Guna.UI2.WinForms;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel.Application;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace lab3
{
    public partial class Easy : Form
    {
        private WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private Boolean isPlay = true;

        int score = 0,correctQuestion,questionNumber = 1;

        List<int> randomNumbers;

        string topic, topic2;

        Image check;

        Excel excel = new Excel();
        Workbook wb;
        Worksheet ws;
        Range range;
        bool ticked = false;

        public Easy(string topic)
        {
            InitializeComponent();
            this.topic = topic;
        }

        private void setQuestion(int so, string btn1, string btn2, string btn3, string btn4,int correct)
        {
            q_picturre.Image = Image.FromFile("Resources/" + topic + " (" + so + ").png");
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

        private void boDe(int soThuTuCauHoi)
        {
            if (topic.Equals("fruit"))
            {
                switch (soThuTuCauHoi)
                {
                    case 1:
                        setQuestion(1, "almond", "watermelon", "sapodilla", "pumpkin", 1);
                        break;
                    case 2:
                        setQuestion(2, "macadamia", "apricot", "rambutan", "sapodilla", 2);
                        break;
                    case 3:
                        setQuestion(3, "pumpkin", "sapodilla", "rambutan", "avocado", 4);
                        break;
                    case 4:
                        setQuestion(4, "bananas", "macadamia", "watermelon", "rambutan", 1);
                        break;
                    case 5:
                        setQuestion(5, "rambutan", "walnut", "pumpkin", "capsicum", 4);
                        break;
                    case 6:
                        setQuestion(6, "sapodilla", "carambola", "watermelon", "macadamia", 2);
                        break;
                    case 7:
                        setQuestion(7, "cashew", "walnut", "pumpkin", "rambutan", 1);
                        break;
                    case 8:
                        setQuestion(8, "macadamia", "watermelon", "cherries", "rambutan", 3);
                        break;
                    case 9:
                        setQuestion(9, "walnut", "pumpkin", "sapodilla", "coconut", 4);
                        break;
                    case 10:
                        setQuestion(10, "pumpkin", "macadamia", "watermelon", "dragon-fruit", 4);
                        break;


                    case 11:
                        setQuestion(11, "almond", "capsicum", "durian", "cashew", 3);
                        break;
                    case 12:
                        setQuestion(12, "coconut", "grapes", "capsicum", "bananas", 2);
                        break;
                    case 13:
                        setQuestion(13, "cashew", "coconut", "guava", "almond", 3);
                        break;
                    case 14:
                        setQuestion(14, "capsicum", "jackfruit", "bananas", "coconut", 2);
                        break;
                    case 15:
                        setQuestion(15, "jalapeno", "cashew", "almond", "bananas", 1);
                        break;
                    case 16:
                        setQuestion(16, "almond", "capsicum", "lemon", "coconut", 3);
                        break;
                    case 17:
                        setQuestion(17, "carambola", "bananas", "coconut", "lime", 4);
                        break;
                    case 18:
                        setQuestion(18, "capsicum", "almond", "cashew", "macadamia", 4);
                        break;
                    case 19:
                        setQuestion(19, "coconut", "bananas", "mango", "capsicum", 3);
                        break;
                    case 20:
                        setQuestion(20, "cashew", "orange-juice", "capsicum", "almond", 2);
                        break;


                    case 21:
                        setQuestion(21, "grapes", "jackfruit", "passion-fruit", "macadamia", 3);
                        break;
                    case 22:
                        setQuestion(22, "jackfruit", "peanut", "avocado", "dragon-fruit", 2);
                        break;
                    case 23:
                        setQuestion(23, "macadamia", "dragon-fruit", "pear", "carambola", 3);
                        break;
                    case 24:
                        setQuestion(24, "carambola", "pineapple", "jackfruit", "grapes", 2);
                        break;
                    case 25:
                        setQuestion(25, "plum", "avocado", "macadamia", "jackfruit", 1);
                        break;
                    case 26:
                        setQuestion(26, "dragon-fruit", "grapes", "pumpkin", "carambola", 3);
                        break;
                    case 27:
                        setQuestion(27, "jalapeno ", "macadamia", "carambola", "rambutan", 4);
                        break;
                    case 28:
                        setQuestion(28, "avocado", "jackfruit", "grapes", "rose-apple", 4);
                        break;
                    case 29:
                        setQuestion(29, "carambola", "macadamia", "sapodilla", "grapes", 3);
                        break;
                    case 30:
                        setQuestion(30, "carambola", "strawberry", "dragon-fruit", "jackfruit", 2);
                        break;

                    case 31:
                        setQuestion(31, "grapes", "walnut", "avocado", "dragon-fruit", 2);
                        break;
                    case 32:
                        setQuestion(32, "macadamia", "watermelon", "jackfruit", "grapes", 2);
                        break;

                }
            }
            else if (topic.Equals("color"))
            {
                switch (soThuTuCauHoi)
                {
                    case 1:
                        setQuestion(1, "babyblue", "yellow", "rose", "seafoam", 1);
                        break;
                    case 2:
                        setQuestion(2, "seafoam", "berry", "red", "rose", 2);
                        break;
                    case 3:
                        setQuestion(3, "red", "navy", "yellow", "black", 4);
                        break;
                    case 4:
                        setQuestion(4, "brick", "plum", "navy", "seafoam", 1);
                        break;
                    case 5:
                        setQuestion(5, "yellow", "rose", "plum", "brown", 4);
                        break;
                    case 6:
                        setQuestion(6, "seafoam", "caramel", "navy", "red", 2);
                        break;
                    case 7:
                        setQuestion(7, "carrot", "rose", "yellow", "gray", 1);
                        break;
                    case 8:
                        setQuestion(8, "navy", "yellow", "darkgreen", "red", 3);
                        break;
                    case 9:
                        setQuestion(9, "rose", "seafoam", "red", "darkred", 4);
                        break;
                    case 10:
                        setQuestion(10, "rose", "seafoam", "yellow", "flamingo", 4);
                        break;


                    case 11:
                        setQuestion(11, "brown", "darkred", "forest", "salmon", 3);
                        break;
                    case 12:
                        setQuestion(12, "salmon", "gray", "darkred", "brick", 2);
                        break;
                    case 13:
                        setQuestion(13, "brick", "skyblue", "green", "brown", 3);
                        break;
                    case 14:
                        setQuestion(14, "darkred", "indigo", "salmon", "skyblue", 2);
                        break;
                    case 15:
                        setQuestion(15, "lavender", "salmon", "darkred", "brick", 1);
                        break;
                    case 16:
                        setQuestion(16, "brown", "darkred", "lightgray", "skyblue", 3);
                        break;
                    case 17:
                        setQuestion(17, "darkred", "brick", "salmon", "lime", 4);
                        break;
                    case 18:
                        setQuestion(18, "skyblue", "brown", "darkred", "navy", 4);
                        break;
                    case 19:
                        setQuestion(19, "brown", "skyblue", "neonpink", "darkred", 3);
                        break;
                    case 20:
                        setQuestion(20, "darkred", "orange", "salmon", "brown", 2);
                        break;


                    case 21:
                        setQuestion(21, "babyblue", "berry", "pink", "navy", 3);
                        break;
                    case 22:
                        setQuestion(22, "flamingo", "plum", "navy", "lavender", 2);
                        break;
                    case 23:
                        setQuestion(23, "forest", "berry", "purple", "orange", 3);
                        break;
                    case 24:
                        setQuestion(24, "lavender", "red", "navy", "flamingo", 2);
                        break;
                    case 25:
                        setQuestion(25, "rose", "berry", "flamingo", "babyblue", 1);
                        break;
                    case 26:
                        setQuestion(26, "lavender", "babyblue", "salmon", "berry", 3);
                        break;
                    case 27:
                        setQuestion(27, "navy", "lavender", "flamingo", "seafoam", 4);
                        break;
                    case 28:
                        setQuestion(28, "navy", "berry", "babyblue", "skyblue", 4);
                        break;
                    case 29:
                        setQuestion(29, "babyblue", "flamingo", "white", "lavender", 3);
                        break;
                    case 30:
                        setQuestion(30, "flamingo", "wine", "berry", "babyblue", 2);
                        break;

                    case 31:
                        setQuestion(31, "lime ", "yellow", "indigo", "gray", 2);
                        break;


                }
            }
            else if (topic.Equals("animals"))
            {
                switch (soThuTuCauHoi)
                {
                    case 1:
                        setQuestion(1, "bee", "turtle", "snake", "squirrel", 1);
                        break;
                    case 2:
                        setQuestion(2, "snake", "butterfly", "whale", "rat", 2);
                        break;
                    case 3:
                        setQuestion(3, "turtle", "squirrel", "whale", "cat", 4);
                        break;
                    case 4:
                        setQuestion(4, "chameleon", "snake", "squirrel", "whale", 1);
                        break;
                    case 5:
                        setQuestion(5, "pig", "rat", "turtle", "crab", 4);
                        break;
                    case 6:
                        setQuestion(6, "whale", "dog", "snake", "squirrel", 2);
                        break;
                    case 7:
                        setQuestion(7, "dolphin", "turtle", "whale", "rat", 1);
                        break;
                    case 8:
                        setQuestion(8, "squirrel", "snake", "duck", "pig", 3);
                        break;
                    case 9:
                        setQuestion(9, "rat", "turtle", "whale", "ducky", 4);
                        break;
                    case 10:
                        setQuestion(10, "whale", "squirrel", "snake", "elephant", 4);
                        break;


                    case 11:
                        setQuestion(11, "crab", "bee", "fish", "rabbit", 3);
                        break;
                    case 12:
                        setQuestion(12, "duck", "frog", "crab", "snail", 2);
                        break;
                    case 13:
                        setQuestion(13, "rabbit", "bee", "giraffe", "snail", 3);
                        break;
                    case 14:
                        setQuestion(14, "bee", "hedgehog", "duck", "tiger", 2);
                        break;
                    case 15:
                        setQuestion(15, "hen", "crab", "rabbit", "tiger", 1);
                        break;
                    case 16:
                        setQuestion(16, "rabbit", "duck", "kangaroo", "bee", 3);
                        break;
                    case 17:
                        setQuestion(17, "crab", "snail", "rabbit", "lion", 4);
                        break;
                    case 18:
                        setQuestion(18, "snail", "bee", "duck", "octopus", 4);
                        break;
                    case 19:
                        setQuestion(19, "crab", "rabbit", "parrot", "tiger", 3);
                        break;
                    case 20:
                        setQuestion(20, "bee", "penguin", "duck", "crab", 2);
                        break;


                    case 21:
                        setQuestion(21, "elephant", "hen", "pig", "frog", 3);
                        break;
                    case 22:
                        setQuestion(22, "dolphin", "rabbit", "parrot", "cat", 2);
                        break;
                    case 23:
                        setQuestion(23, "frog", "cat", "rat", "dolphin", 3);
                        break;
                    case 24:
                        setQuestion(24, "hen", "seahorse", "elephant", "parrot", 2);
                        break;
                    case 25:
                        setQuestion(25, "shrimp", "dolphin", "frog", "hen", 1);
                        break;
                    case 26:
                        setQuestion(26, "parrot", "elephant", "snail", "lion", 3);
                        break;
                    case 27:
                        setQuestion(27, "hen", "elephant", "frog", "snake", 4);
                        break;
                    case 28:
                        setQuestion(28, "dolphin", "frog", "parrot", "squirrel", 4);
                        break;
                    case 29:
                        setQuestion(29, "lion", "cat", "tiger", "elephant", 3);
                        break;
                    case 30:
                        setQuestion(30, "frog", "turtle", "hen", "dolphin", 2);
                        break;

                    case 31:
                        setQuestion(31, "elephant", "whale", "hen", "parrot", 2);
                        break;

                }
            }
            else if (topic.Equals("job"))
            {
                switch (soThuTuCauHoi)
                {
                    case 1:
                        setQuestion(1, "academic", "sheriff", "surgeon", "worker", 1);
                        break;
                    case 2:
                        setQuestion(2, "worker", "astronaut", "thief", "swat", 2);
                        break;
                    case 3:
                        setQuestion(3, "thief", "sheriff", "surgeon", "builder", 4);
                        break;
                    case 4:
                        setQuestion(4, "businessman", "thief", "worker", "sheriff", 1);
                        break;
                    case 5:
                        setQuestion(5, "surgeon", "swat", "sheriff", "captain", 4);
                        break;
                    case 6:
                        setQuestion(6, "swat", "chef", "worker", "sheriff", 2);
                        break;
                    case 7:
                        setQuestion(7, "concierge", "surgeon", "thief", "astronaut", 1);
                        break;
                    case 8:
                        setQuestion(8, "sheriff", "worker", "courier", "thief", 3);
                        break;
                    case 9:
                        setQuestion(9, "sheriff", "surgeon", "worker", "croupier", 4);
                        break;
                    case 10:
                        setQuestion(10, "worker", "sheriff", "surgeon", "detective", 4);
                        break;


                    case 11:
                        setQuestion(11, "academic", "captain", "doctor", "courier", 3);
                        break;
                    case 12:
                        setQuestion(12, "captain", "electrician", "courier", "detective", 2);
                        break;
                    case 13:
                        setQuestion(13, "detective", "teacher", "farmer", "academic", 3);
                        break;
                    case 14:
                        setQuestion(14, "captain", "firefighter", "courier", "reporter", 2);
                        break;
                    case 15:
                        setQuestion(15, "flight-attendant", "academic", "detective", "teacher", 1);
                        break;
                    case 16:
                        setQuestion(16, "captain", "reporter", "hacker", "academic", 3);
                        break;
                    case 17:
                        setQuestion(17, "detective", "courier", "captain", "hairdresser", 4);
                        break;
                    case 18:
                        setQuestion(18, "reporter", "academic", "courier", "hostess", 4);
                        break;
                    case 19:
                        setQuestion(19, "reporter", "captain", "lab-technician", "detective", 3);
                        break;
                    case 20:
                        setQuestion(20, "courier", "loader", "captain", "academic", 2);
                        break;


                    case 21:
                        setQuestion(21, "soldier", "welder", "magician", "hairdresser", 3);
                        break;
                    case 22:
                        setQuestion(22, "surgeon", "miner", "hairdresser", "loader", 2);
                        break;
                    case 23:
                        setQuestion(23, "welder", "hairdresser", "musician", "soldier", 3);
                        break;
                    case 24:
                        setQuestion(24, "welder", "painter", "soldier", "surgeon", 2);
                        break;
                    case 25:
                        setQuestion(25, "pilot", "soldier", "loader", "hairdresser", 1);
                        break;
                    case 26:
                        setQuestion(26, "loader", "welder", "policeman", "surgeon", 3);
                        break;
                    case 27:
                        setQuestion(27, "businessman", "surgeon", "concierge", "postman", 4);
                        break;
                    case 28:
                        setQuestion(28, "welder", "surgeon", "soldier", "programmer", 4);
                        break;
                    case 29:
                        setQuestion(29, "concierge", "hairdresser", "reporter", "loader", 3);
                        break;
                    case 30:
                        setQuestion(30, "surgeon", "salesman", "welder", "soldier", 2);
                        break;


                    case 31:
                        setQuestion(31, "detective", "scientist", "doctor", "farmer", 2);
                        break;
                    case 32:
                        setQuestion(32, "miner", "sheriff", "doctor", "hairdresser", 2);
                        break;
                    case 33:
                        setQuestion(33, "doctor", "farmer", "soldier", "detective", 3);
                        break;
                    case 34:
                        setQuestion(34, "detective", "student", "doctor", "magician", 2);
                        break;
                    case 35:
                        setQuestion(35, "surgeon", "farmer", "hairdresser", "magician", 1);
                        break;
                    case 36:
                        setQuestion(36, "hairdresser", "doctor", "swat", "detective", 3);
                        break;
                    case 37:
                        setQuestion(37, "miner", "detective", "farmer", "teacher", 4);
                        break;
                    case 38:
                        setQuestion(38, "magician", "hairdresser", "doctor", "thief", 4);
                        break;
                    case 39:
                        setQuestion(39, "miner", "detective", "veterinarian", "builder", 3);
                        break;
                    case 40:
                        setQuestion(40, "doctor", "welder", "farmer", "magician", 2);
                        break;
                    case 41:
                        setQuestion(41, "farmer", "worker", "detective", "hairdresser", 2);
                        break;
                }
            }

        }

        private void clickBtn(object sender, EventArgs e)
        {
            if (ticked == false)
            {
                var senderObject = (Guna2Button)sender;
                int buttonTag = Convert.ToInt32(senderObject.Tag);

                checkAns(buttonTag, senderObject);
                ticked = true;
            }
        }

        private void checkAns(int buttonTag, Guna2Button senderObject)
        {
            if (questionNumber < 6)
            {
                if (buttonTag == correctQuestion)
                {
                    score += 2;
                    s_score.Text = Convert.ToString(score);
                    anhDungSai(true);
                    senderObject.FillColor = Color.FromArgb(71, 169, 146);

                }
                else
                {
                    anhDungSai(false);
                    senderObject.FillColor = Color.IndianRed;
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

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            string message = "Do you want to exit game?";
            string title = "Exit game";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                wb = excel.Workbooks.Open(Program.filePathExcel);
                ws = wb.Worksheets["Easy"];
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
            

        }

        private void q_next_Click(object sender, EventArgs e)
        {
            if (questionNumber < 5)
            {
                questionNumber++;
                q_cau.Text = Convert.ToString(questionNumber);
                boDe(randomNumbers[questionNumber - 1]);

                q_btn1.FillColor = Color.Transparent;
                q_btn2.FillColor = Color.Transparent;
                q_btn3.FillColor = Color.Transparent;
                q_btn4.FillColor = Color.Transparent;
                ticked = false;
            }
        }
    }
}
