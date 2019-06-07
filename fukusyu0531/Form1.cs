using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0531
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -5;
        int iTime = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Text = MousePosition.X + "," + MousePosition.Y;
            Point p = PointToClient(MousePosition);

            label2.Left = p.X-label2.Width/2;
            label2.Top = p.Y-label2.Height/2;

            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left <= 0)
            {
                vx = -vx;
            }
            if (label1.Top <= 0)
            {
                vy = -vy;
            }
            if (label1.Left >= ClientSize.Width-label1.Width)
            {
                vx = -Math.Abs(-vx);
            }
            if (label1.Top >= ClientSize.Height-label1.Height)
            {
                vy = -Math.Abs(-vy);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("" + ClientSize.Width + "," + ClientSize.Height);
           //MessageBox.Show("" + label1.Width + "," + label1.Height);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
