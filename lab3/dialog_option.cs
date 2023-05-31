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
    public partial class dialog_option : Form
    {
        private String topic;
        public dialog_option(String topic)
        {
            InitializeComponent();
            this.topic = topic;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            chuyenForm();
            Easy easy = new Easy(topic);
            easy.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
          
            chuyenForm();
            Medium easy = new Medium(topic);
            easy.ShowDialog();
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            chuyenForm();
            Hard easy = new Hard(topic);
            easy.ShowDialog();
        }

        private void chuyenForm()
        {
            Play.play1Instance.Hide();
            Play.play1Instance.Close();

            Program.player.controls.stop();

            this.Hide();
            this.Close();
        }
    }
}
