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
    public partial class Play : Form
    {
        
        public static Play play1Instance;

        public Play()
        {
            InitializeComponent();
            play1Instance = this;
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

        private void panel_shape_Click(object sender, EventArgs e)
        {
            openDialog("job");
        }

        private void Play_Load(object sender, EventArgs e)
        {
            if (Program.isPlay == true)
            {
                guna2CirclePictureBox6.Image = Image.FromFile("G:\\Oanhhh\\c#\\lab3\\lab3\\Resources\\volume.png");
            }
            else if (Program.isPlay == false)
            {
                guna2CirclePictureBox6.Image = Image.FromFile("G:\\Oanhhh\\c#\\lab3\\lab3\\Resources\\volume-mute.png");
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void openDialog(String topic)
        {
            dialog_option play = new dialog_option(topic);
            play.ShowDialog();
        }

        private void panel_color_Click(object sender, EventArgs e)
        {
            openDialog("color");
        }

        private void panel_animal_Click(object sender, EventArgs e)
        {
            openDialog("animals");
        }

        private void panel_fruits_Click(object sender, EventArgs e)
        {
            openDialog("fruit");
        }
    }
}
