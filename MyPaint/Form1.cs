using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }
        
        Point p;
        private Color culoare = Color.Empty ;

        private void Form1_Load(object sender, EventArgs e)
        {
             panel1.BackColor = Color.White;
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
                culoare = colorDialog1.Color;
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
           
            Graphics g = panel1.CreateGraphics();
            g.Clear(Color.White);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked)
            {
                int x0 = p.X;
                int y0 = p.Y;
                int w0 = e.X;
                int h0 = e.Y;
                Graphics g = panel1.CreateGraphics();
                Pen pen = new Pen(culoare, trackBar1.Value);
                int x = Math.Min(w0, x0);
                int y = Math.Min(h0, y0);
                int w = Math.Abs(w0 - x0);
                int h = Math.Abs(h0 - y0);
                g.DrawEllipse(pen, x, y, w, h);
            }
            else if (radioButton2.Checked)
            {
                int x0 = p.X;
                int y0 = p.Y;
                int w0 = e.X;
                int h0 = e.Y;
                Graphics g = panel1.CreateGraphics();
                Pen pen = new Pen(culoare, trackBar1.Value);
                int x = Math.Min(w0, x0);
                int y = Math.Min(h0, y0);
                int w = Math.Abs(w0 - x0);
                int h = Math.Abs(h0 - y0);
                g.DrawRectangle(pen, x, y, w, h);

            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
             p = new Point(e.X, e.Y);
        }
    }
}
