using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_진수변환
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int inputNumber;

        private int SetNumber(int number) // inputNumber
        {
            return this.inputNumber = number;
        }
        private int GetNumber() //inputNumber
        {
            return this.inputNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        { // 변환 버튼
            
            SetNumber(int.Parse(textBox1.Text));
            TextboxUpdate();
        }

        private void TextboxUpdate()
        {
            int number = GetNumber();
            int MOK, NMG, count = 0;
            int[] arrnum = new int[50];
            do 
            {
                MOK = number / 2;
                NMG = number - MOK * 2;
                number = MOK;
                arrnum[count++] = NMG;
                //textBox2.Text += NMG.ToString();
            } while (MOK != 0);
            textBox2.Clear();
            for(int i = count - 1; i >= 0; i--)
            {
                textBox2.Text += arrnum[i].ToString();
                
            }
        }
    }
}
