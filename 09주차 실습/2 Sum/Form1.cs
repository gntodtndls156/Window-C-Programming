using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                checkBox1.Text = "2";
                checkBox3.Text = "24";
            } else
            {
                checkBox1.Text = "24";
                checkBox3.Text = "2";
            }
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            sum = 0;
            Show();
        }

        // -------------------------------
        int sum = 0;

        private new void Show()
        {
            label2.Text = sum + "";
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                sum += int.Parse(checkBox1.Text);
            else
                sum -= int.Parse(checkBox1.Text);

            Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                sum += int.Parse(checkBox2.Text);
            else
                sum -= int.Parse(checkBox2.Text);

            Show();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                sum += int.Parse(checkBox3.Text);
            else
                sum -= int.Parse(checkBox3.Text);

            Show();
        }
    }
}
