using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_미니계사니
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { // +
            int number1 = Int32.Parse(textBox1.Text);
            int number2 = Int32.Parse(textBox2.Text);
            textBox3.Text = (number1 + number2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        { // -
            int number1 = Int32.Parse(textBox1.Text);
            int number2 = Int32.Parse(textBox2.Text);
            textBox3.Text = (number1 - number2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        { // *
            int number1 = Int32.Parse(textBox1.Text);
            int number2 = Int32.Parse(textBox2.Text);
            textBox3.Text = (number1 * number2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        { // /
            int number1 = Int32.Parse(textBox1.Text);
            int number2 = Int32.Parse(textBox2.Text);
            textBox3.Text = (number1 / number2).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        { // %
            int number1 = Int32.Parse(textBox1.Text);
            int number2 = Int32.Parse(textBox2.Text);
            textBox3.Text = (number1 % number2).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }
    }
}
