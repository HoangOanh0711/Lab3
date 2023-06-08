using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Microsoft.Office.Interop.Excel;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel.Application;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Acheivement : Form
    {
        Excel excel = new Excel();
        Workbook wb;
        Worksheet ws;
        Range range;
        public Acheivement()
        {
            InitializeComponent();
        }

        private void Acheivement_Load(object sender, EventArgs e)
        {
            loadData("Easy");
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


        private void loadData(string level)
        {
            while (datagridview.Rows.Count > 0)
            {
                datagridview.Rows.Remove(datagridview.Rows[0]);
            }

            wb = excel.Workbooks.Open(Program.filePathExcel);
            ws = wb.Worksheets[$"{level}"];
            range = ws.UsedRange;

            label4.Text = $"Rankings level {level}";

            for (int row = 2; row <= range.Rows.Count; ++row)//đọc row hiện có trong Excel
            {
                datagridview.Rows.Add(range.Cells[row, 2].Text, Convert.ToInt32(range.Cells[row, 3].Text), range.Cells[row, 4].Text);
                datagridview.Sort(datagridview.Columns[1], ListSortDirection.Descending);
            }
            wb.Close();
            excel.Quit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            loadData("Easy");

        }

        private void label2_Click(object sender, EventArgs e)
        {
            loadData("Medium");

        }

        private void label3_Click(object sender, EventArgs e)
        {
            loadData("Hard");

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
    }
}
