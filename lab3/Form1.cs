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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Play play = new Play();
            play.ShowDialog();
            this.Close();
        }

        private void guna2CirclePictureBox6_Click(object sender, EventArgs e)
        {
            if (Program.isPlay == true)
            {
                Program.dungNhac(guna2CirclePictureBox6);
            }
            else if (Program.isPlay == false)
            {
                Program.moNhac(guna2CirclePictureBox6);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (Program.isPlay == true)
            {
                Program.moNhac(guna2CirclePictureBox6);
                guna2CirclePictureBox6.Image = Image.FromFile("G:\\Oanhhh\\c#\\lab3\\lab3\\Resources\\volume.png");
            }
            else if (Program.isPlay == false)
            {
                guna2CirclePictureBox6.Image = Image.FromFile("G:\\Oanhhh\\c#\\lab3\\lab3\\Resources\\volume-mute.png");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acheivement play = new Acheivement();
            play.ShowDialog();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dictionary play = new Dictionary();
            play.ShowDialog();
            this.Close();
        }
    }
}
