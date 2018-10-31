using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using program1;

namespace WindowsForms1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            string Number = textBox1.Text;
            string Name = textBox2.Text;
            string Client = textBox3.Text;
            double Price = Double.Parse(textBox4.Text);
            Order order = new Order(Number, Name, Client, Price);
            f.list.Remove(order);
            string nNumber = textBox5.Text;
            string nName = textBox6.Text;
            string nClient = textBox7.Text;
            double nPrice = Double.Parse(textBox8.Text);
            f.list.Add(order);

            for (int i = 0; i < f.list.Count; i++)
            {

                textBox9.Text += f.list[i].Number + " " + f.list[i].Name + " " + f.list[i].Client + " " + f.list[i].Price + "\r\n";
            }
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
