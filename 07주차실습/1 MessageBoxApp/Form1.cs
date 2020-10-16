using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_MessageBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Count = 0;
        private void Form1_Click(object sender, EventArgs e)
        {
            switch(Count)
            {
                case 0:
                    MessageBox.Show("MessageBox", "Title Bar");
                    break;
                case 1:
                    MessageBox.Show("MessageBox", "Title Bar", MessageBoxButtons.OKCancel);
                    break;
                case 2:
                    MessageBox.Show("MessageBox", "Title Bar", MessageBoxButtons.AbortRetryIgnore, 0, MessageBoxDefaultButton.Button1);
                    break;
                case 3:
                    MessageBox.Show("MessageBox", "Title Bar", MessageBoxButtons.YesNoCancel);
                    break;
                case 4:
                    MessageBox.Show("MessageBox", "Title Bar", MessageBoxButtons.YesNo);
                    break;
                case 5:
                    MessageBox.Show("MessageBox", "2019101009함승우", MessageBoxButtons.RetryCancel);
                    break;
            }
            Count++;
        }
    }
}
