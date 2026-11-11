using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewPaint
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen = new Pen(Color.FromArgb(10, 200, 200), 20);
        bool isDraiving = false;
        Point fromP;
        Point toP;

        public Form1()
        {
            InitializeComponent();
        
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel8_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            g = panel8.CreateGraphics();

            Pen pen = new Pen(Color.FromArgb(10, 200, 200), 20);
            Point fromP = new Point(100, 100);
            Point toP = new Point(500, 500);

            g.DrawLine(pen, fromP, toP);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
