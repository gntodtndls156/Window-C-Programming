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
        Boolean switchColor = true;
        Color color;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e) // Panel
        {
            //Init variable
            Graphics graphics = e.Graphics;
            Random random = new Random();
            //Color
            if (switchColor)
            {
                color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            }
            //Fill
            graphics.FillRectangle(new SolidBrush(color), e.ClipRectangle);
            // -- Color Code End --
            // --- align center ---
            panel1.Left = (this.Width - panel1.Width) / 2 - 15;
            panel1.Top = (this.Height - panel1.Height) / 2 - 60;

        }

        private void Cannot_BackgroundColor_Click(object sender, EventArgs e) // 배경색 변경 불가
        {
            //if try to Click, to start a change of the variable
            Can_BackgroundColor.Enabled = true;
            Cannot_BackgroundColor.Enabled = false;
            Change_BackgroundColor.Visible = false;
        }

        private void Can_BackgroundColor_Click(object sender, EventArgs e) // 배경색 변경 가능
        {
            //if try to Click, to start a change of the variable
            Can_BackgroundColor.Enabled = false;
            Cannot_BackgroundColor.Enabled = true;
            Change_BackgroundColor.Visible = true;
        }

        private void Change_BackgroundColor_Click(object sender, EventArgs e) // 배경색 컬러 변경
        {
            switchColor = true;
            panel1.Invalidate();
            
        }

        private void AreaPlus_Click(object sender, EventArgs e) // 영역 확대
        {
            switchColor = false;
            int X = panel1.Width, Y = panel1.Height;
            if (X >= 300)
            {
                MessageBox.Show("최대크기입니다.");
                return;
            }
            panel1.Width = (int)(X * 1.1);
            panel1.Height = (int)(Y * 1.1);
            
        }

        private void AreaMinus_Click(object sender, EventArgs e) // 영역 축소
        {
            switchColor = false;
            int X = panel1.Width, Y = panel1.Height;
            if (X <= 50)
            {
                MessageBox.Show("최소크기입니다.");
                return;
            }
            panel1.Width = (int)(X / 1.1);
            panel1.Height = (int)(Y / 1.1);
            panel1.Width++;
            panel1.Width--;
        }
    }
}
