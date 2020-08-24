//usings//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace
namespace Design1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //load//
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
        }
        //paint//
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        //first panel//
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.FromArgb(199, 24, 143), ButtonBorderStyle.Solid);
        }
        //second panel//
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(33, 33, 33);
        }
        //third panel//
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(199, 24, 143);
        }
        //fourth panel//
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.BackColor = Color.FromArgb(33, 33, 33);
        }
        //fifth panel//
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            panel4.BackColor = Color.FromArgb(45, 45, 45);
        }
        //Fade-In//
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .2;
        }
        //Fade-Out//
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                Application.Exit();
            }
            Opacity -= .2;
        }
        //Fade-Out test
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.Visible = true;
            button1.BackColor = Color.FromArgb(45, 45, 45);
            timer2.Start();
        }
    }
}
/*Shorter description
I will show you the simpliest but the coolesst one animations
1:Fade-In/Out
Its workin on our form opacity,The window will rendering depending on how many interval in timer we have 
Best Interval:40/50
---------------------------------------------------------------------------------------------------------
*/