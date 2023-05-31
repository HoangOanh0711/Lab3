using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    
    internal static class Program
    {
        public static WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public static Boolean isPlay = true;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //player.URL = @"G:\\Oanhhh\\c#\\image\\lab3\\sound\\nhacgame01.mp3";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void dungNhac(Guna2CirclePictureBox guna2CirclePictureBox)
        {
            isPlay = false;
            player.controls.pause();
            guna2CirclePictureBox.Image = Image.FromFile("G:\\Oanhhh\\c#\\lab3\\lab3\\Resources\\volume-mute.png");

        }

        public static void moNhac(Guna2CirclePictureBox guna2CirclePictureBox)
        {
            isPlay = true;
            player.controls.play();
            guna2CirclePictureBox.Image = Image.FromFile("G:\\Oanhhh\\c#\\lab3\\lab3\\Resources\\volume.png");
        }

        public static void dungNhacKhongBam()
        {
            player.controls.stop();
        }
    }
}
