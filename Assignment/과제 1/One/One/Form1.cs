using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cannot_BackgroundColor_Click(object sender, EventArgs e)
        {
            //if try to Click, to change start variable.
            can_BackgroundColor.Enabled = true;
            cannot_BackgroundColor.Enabled = false;
            change_BackgroundColor.Visible = false;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Init variable
            Graphics graphics = e.Graphics;
            Random random = new Random();

            //Color
            Color color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            //Fill
            graphics.FillRectangle(new SolidBrush(color), e.ClipRectangle);
        }

        private void change_BackgroundColor_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void can_BackgroundColor_Click(object sender, EventArgs e)
        {
            //if try to Click, to change start variable.
            can_BackgroundColor.Enabled = false;
            cannot_BackgroundColor.Enabled = true;
            change_BackgroundColor.Visible = true;
        }
    }
}
