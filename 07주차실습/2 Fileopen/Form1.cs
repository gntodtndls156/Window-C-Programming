using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Fileopen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\"; // 선택 디렉터리 오픈할 때 경로.
            openFileDialog1.Filter = "텍스트 파일(*.txt) | *.txt";
            openFileDialog1.FilterIndex = 1; // 첫번째 필터
            openFileDialog1.RestoreDirectory = true;

            textBox1.Text = "";

            openFileDialog1.ShowDialog(); // 선택 디렉터리 오픈
            String filePath = openFileDialog1.FileName; // 파일 절대 경로

            StringBuilder sb = new StringBuilder();

            sb.Append(File.ReadAllText(filePath));
            textBox1.Text = sb.ToString();
            
        }
    }
}
