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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          
            Order order1 = new Order("1", "1", "1", 1);
            Order order2 = new Order("2", "2", "2", 2);
            Order order3 = new Order("3", "3", "3", 3);
            list.Add(order1);
            list.Add(order2);          
            bindingSource1.DataSource = list;
        }
        public List<Order> list = new List<Order>();              
        public void init()
        {   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();                  
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {          
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {                
                Order order1 = new Order("1", "1", "1", 1);
                Order order2 = new Order("2", "2", "2", 2);
                Order order3 = new Order("3", "3", "3", 3);
                list.Add(order1);
                list.Add(order2);
                string information = textBox2.Text;
                textBox1.Text = null;
                //orderService.Inquiry(1, information);
                var m = from order in list where order.Number == information select order;
                foreach (var order in m)
                {
                    textBox1.Text += order.Number + " " + order.Name + " " + order.Client + " " + order.Price + "\r\n";
                }
            }
            if (radioButton2.Checked)
            {
                Order order1 = new Order("1", "1", "1", 1);
                Order order2 = new Order("2", "2", "2", 2);
                Order order3 = new Order("3", "3", "3", 3);
                list.Add(order1);
                list.Add(order2);
                string information = textBox3.Text;
                textBox1.Text = null;
                var m = from order in list where order.Name == information select order;
                foreach (var order in m)
                {
                    textBox1.Text += order.Number + " " + order.Name + " " + order.Client + " " + order.Price + "\r\n";
                }
            }
            if (radioButton3.Checked)
            {
                Order order1 = new Order("1", "1", "1", 1);
                Order order2 = new Order("2", "2", "2", 2);
                Order order3 = new Order("3", "3", "3", 3);
                list.Add(order1);
                list.Add(order2);
                string information = textBox3.Text;
                textBox1.Text = null;
                var m = from order in list where order.Client == information select order;
                foreach (var order in m)
                {
                    textBox1.Text += order.Number + " " + order.Name + " " + order.Client + " " + order.Price + "\r\n";
                }
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
