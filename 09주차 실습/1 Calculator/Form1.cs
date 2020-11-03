using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool[] boolarr = new bool[4] { false, false, false, false };
        readonly int[] intarr = new int[4] { 28, 88, 16, 19 };

        int MIN, MAX;

        void init(bool state)
        {
            if(state)
            this.MIN = 99;
            else
            this.MAX = 0;
        }

        void StateChecked()
        {
            if (radioButton1.Checked)
            {
                label1.Text = "Min :";
                if (MIN == 99) MIN = 0;
                label2.Text = MIN + "";
            }
            else if (radioButton2.Checked)
            {
                label1.Text = "Max :";
                label2.Text = MAX + "";
            }
        }
        void FunMin ()
        {
            init(true);
            for(int i = 0; i <= 3; i++)
            {
                if(boolarr[i] && MIN > intarr[i])
                {
                    MIN = intarr[i];
                }
            }
            StateChecked();
        }
        void FunMax()
        {
            init(false);
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("완료");
                if (boolarr[i] && MAX < intarr[i])
                {
                    
                    MAX = intarr[i];
                }
            }
            StateChecked();
        }


        private bool ChangeBool(int number)
        {
            return boolarr[number] = !boolarr[number];
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { // 28
            if (checkBox1.Checked)
                ChangeBool(0);
            else ChangeBool(0);

            FunMax();
            FunMin();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        { // 16
            if (checkBox3.Checked)
                ChangeBool(2);
            else ChangeBool(2);

            FunMax();
            FunMin();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        { // 88
            if (checkBox2.Checked)
                ChangeBool(1);
            else ChangeBool(1);

            FunMax();
            FunMin();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        { // 19
            if (checkBox4.Checked)
                ChangeBool(3);
            else ChangeBool(3);

            FunMax();
            FunMin();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            StateChecked();
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {

        }
    }
}
