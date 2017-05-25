using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace спираль1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double t = 0, step=0.1 ;
        float xOld, yOld;
        Graphics gr;
        

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            xOld = pictureBox1.Width/2;
            yOld = pictureBox1.Height/2;
            gr = pictureBox1.CreateGraphics();
            gr.SmoothingMode = SmoothingMode.HighQuality;
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LinearGradientBrush gB = new LinearGradientBrush(new Point(pictureBox1.Width / 2, pictureBox1.Height), new Point(40, 40), Color.Red, Color.Yellow);
            Pen p1 = new Pen(gB, 5);
            t += step;
            float x = Convert.ToSingle(pictureBox1.Width / 2 + t * Math.Cos(t));
            float y = Convert.ToSingle(pictureBox1.Height / 2 + t * Math.Sin(t));
            gr.DrawLine(p1, xOld, yOld, x, y);
            xOld = x;
            yOld = y;
        }
    }
}

