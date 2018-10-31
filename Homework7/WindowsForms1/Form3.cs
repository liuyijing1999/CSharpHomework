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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button1 = new Button();
            button1.Click += new EventHandler(this.button1_Click);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            //Order order1 = new Order("1", "1", "1", 1);
            //Order order2 = new Order("2", "2", "2", 2);
            //f.list.Add(order1);
            //f.list.Add(order2);
            string Number = textBox1.Text;
            string Name = textBox2.Text;
            string Client = textBox3.Text;
            double Price = Double.Parse(textBox4.Text);
            Order order4 = new Order(Number, Name, Client, Price);         
            f.list.Remove(order4);
            for (int i = 0; i < f.list.Count; i++)
            {               
                textBox5.Text += f.list[i].Number + " " + f.list[i].Name + " " + f.list[i].Client + " " + f.list[i].Price + "\r\n";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
