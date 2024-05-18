using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp54
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                hiperbola();
            }
            if(radioButton2.Checked == true)
            {
               parabola();
            }

        }
        
        public void parabola()
        {
            int ky = 30;
            int kx = 30;
            int dy = pictureBox1.Height / 2;
            int dx = pictureBox1.Width / 2;
            Bitmap privet = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = privet;
            Graphics cute = Graphics.FromImage(privet);
            Pen obwodka = new Pen(Color.Pink);
            obwodka.Width = 3;
            SolidBrush solidBrush = new SolidBrush(Color.White);
            cute.FillRectangle(solidBrush, 0, 0, pictureBox1.Width, pictureBox1.Height);
            Point[] mas = new Point[0];
            int i = 0;
            for (double x = -10; x <= 10; x = x + 0.1)
            {
                Array.Resize(ref mas, i + 1);
                double y = -x*x;
                mas[i] = new Point(Convert.ToInt32(x * kx) + dx, (Convert.ToInt32(y * ky) + dy));
                i++;
            }

            Pen pl = new Pen(Color.Black);
            pl.Width = 2;
            cute.DrawLine(pl, 0, dy, pictureBox1.Width, dy);
            cute.DrawLine(pl, dx, 0, dx, pictureBox1.Height);
            cute.DrawLines(obwodka, mas);
            pictureBox1.Refresh();
        }

        private void hiperbola()
        {
            int a = Convert.ToInt32(numericUpDown1.Value);
            int ky = 30;
            int kx = 30;
            int dy = pictureBox1.Height / 2;
            int dx = pictureBox1.Width / 2;
            Bitmap privet = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = privet;
            Graphics cute = Graphics.FromImage(privet);
            Pen obwodka = new Pen(Color.Pink);
            obwodka.Width = 3;
            SolidBrush solidBrush = new SolidBrush(Color.White);
            cute.FillRectangle(solidBrush, 0, 0, pictureBox1.Width, pictureBox1.Height);
            Point[] mas = new Point[0];
            int i = 0;
            for (double x = 0.1; x <= 10; x = x + 0.1)
            {
                Array.Resize(ref mas, i + 1);
                double y = -a / x;
                mas[i] = new Point(Convert.ToInt32(x * kx) + dx, (Convert.ToInt32(y * ky) + dy));
                i++;
            }

            Pen pl = new Pen(Color.Black);
            pl.Width = 2;
            cute.DrawLine(pl, 0, dy, pictureBox1.Width, dy);
            cute.DrawLine(pl, dx, 0, dx, pictureBox1.Height);
            cute.DrawLines(obwodka, mas);
            pictureBox1.Refresh();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                hiperbola();
            }
        }
    }
}
