using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_MouseMoveApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePoint = PointToClient(MousePosition);
            int x = mousePoint.X;
            int y = mousePoint.Y;

            this.Text = "MouseMoveApp - (" + x + ", " + y + ")";
        }
    }

}
