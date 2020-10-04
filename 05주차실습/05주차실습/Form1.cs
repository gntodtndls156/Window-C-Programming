using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05주차실습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        { // 왼쪽 버튼
            label3.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        { // 가운데 버튼
            label3.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        { // 오른쪽 버튼
            label3.TextAlign = ContentAlignment.MiddleRight;
        }

        // ---------------------

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { // 굵게 버튼
            if(checkBox1.Checked)
            {
                label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Bold);
            } else
            {
                label3.Font = new Font(label3.Font, label3.Font.Style & ~FontStyle.Bold);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        { // 밑줄 버튼
            if (checkBox2.Checked)
            {
                label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Underline);
            } else
            {
                label3.Font = new Font(label3.Font, label3.Font.Style & ~FontStyle.Underline);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        { // 이탤릭 버튼
            if (checkBox3.Checked)
            {
                label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Italic);
            } else
            {
                label3.Font = new Font(label3.Font, label3.Font.Style & ~FontStyle.Italic);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        { // 취소선
            if (checkBox4.Checked)
            {
                label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Strikeout);
            } else
            {
                label3.Font = new Font(label3.Font, label3.Font.Style & ~FontStyle.Strikeout);
            }
        }
    }
}
