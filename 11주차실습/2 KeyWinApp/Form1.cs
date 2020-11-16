using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_KeyWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.F1 <= e.KeyCode || Keys.A <= e.KeyCode || Keys.D0 <= e.KeyCode || Keys.Escape <= e.KeyCode)
            {
                if(e.Control)
                {
                    MessageBox.Show(e.KeyCode.ToString() + "+ Ctrl", "누른 키");
                } else if (e.Alt)
                {
                    MessageBox.Show(e.KeyCode.ToString() + "+ Alt", "누른 키");
                } else if (e.Shift)
                {
                    MessageBox.Show(e.KeyCode.ToString() + "+ Shift", "누른 키");
                } else
                {
                    MessageBox.Show(e.KeyCode.ToString(), "누른 키");
                }
            }
        }
    }
}
