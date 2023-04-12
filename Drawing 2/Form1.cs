using System;
using System.Drawing;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using Pen = System.Drawing.Pen;

namespace Drawing_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Paint += Form1_Paint;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Random r = new Random();
            for (int i = 0, coordinate = 0, j = 10, b = 20, h = 400, w = 12; i < 10; i++, j += 20, b += 20, h -= 10, w += 12)
            {
                coordinate = r.Next(10, 200);
                Pen blackPen = new Pen(Color.Black, 1);
                Pen pen = new Pen(Color.FromArgb(r.Next(0, 254), r.Next(0, 254), r.Next(0, 254)));
                e.Graphics.DrawEllipse(pen, r.Next(0, 700), r.Next(0, 300), coordinate, coordinate);

                e.Graphics.DrawLine(blackPen, 50, 250, 50, 75);
                e.Graphics.DrawLine(blackPen, 250, 250, 250, 75);
                e.Graphics.DrawEllipse(blackPen, 50, j, 200, 125);

                e.Graphics.DrawLine(blackPen, 309, 250, 405, 2);
                e.Graphics.DrawLine(blackPen, 510, 250, 415, 2);
                e.Graphics.DrawEllipse(blackPen, h, j, b, w);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}