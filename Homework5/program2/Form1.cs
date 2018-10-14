using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(10, 200, 310, 100, -Math.PI / 2);
        }
        private Graphics graphics;
        void drawCayleyTree(int n,
            double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double angle1 = double.Parse(textBox1.Text);
            double angle2 = double.Parse(textBox2.Text);
            double th1 = angle1 * Math.PI / 180;
            double th2 = angle2 * Math.PI / 180;
            double per1 = double.Parse(textBox3.Text);
            double per2 = double.Parse(textBox4.Text);
            double k = double.Parse(textBox5.Text);
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            double x2 = x0 + leng * k *Math.Cos(th);
            double y2 = y0 + leng * k* Math.Sin(th);
            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            Color clr = ColorTranslator.FromHtml(textBox6.Text);
            float width = float.Parse(textBox7.Text);
            Pen p = new Pen(clr,width);
            graphics.DrawLine(
                p,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random angle1 = new Random();
            textBox1.Text = angle1.Next(0, 180).ToString();
            Random angle2 = new Random();
            textBox2.Text = angle2.Next(0, 180).ToString();
            Random per1 = new Random();
            double a = per1.Next(0, 10) * 0.1;
            textBox3.Text = a.ToString();
            Random per2 = new Random();
            double c = per2.Next(0, 10) * 0.1;
            textBox4.Text = c.ToString();
            Random k = new Random();
            double d = k.Next(0, 10) * 0.1;
            textBox5.Text = d.ToString();
            int r, g, b;
            Random random = new Random();
            r = random.Next(0, 256);
            g = random.Next(0, 256);
            b = random.Next(0, 256);
            Color color = Color.FromArgb(r, g,b);
            string R = Convert.ToString(color.R, 16);
            if (R == "0")
                R = "00";
            string G = Convert.ToString(color.G, 16);
            if (G == "0")
                G = "00";
            string B = Convert.ToString(color.B, 16);
            if (B == "0")
                B = "00";
            string HexColor = "#" + R + G + B;
            textBox6.Text = HexColor;
            Random width = new Random();
            double f = width.Next(0, 10) * 0.1;
            textBox7.Text = f.ToString();
        }
    }
}
