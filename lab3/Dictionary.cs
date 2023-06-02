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
    public partial class Dictionary : Form
    {
        public Dictionary()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
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

        private void Dictionary_Load(object sender, EventArgs e)
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
    }
}
