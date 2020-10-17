using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 열기
            OpenFileDialog OFD = openFileDialog1;
            try
            {
                OFD.InitialDirectory = @"c:\";
                OFD.Filter = "텍스트파일 *.txt |*.txt";
                OFD.RestoreDirectory = true;
                OFD.ShowDialog();
                String Path = OFD.FileName;

                StringBuilder SB = new StringBuilder();
                SB.Append(File.ReadAllText(Path));

                textBox1.Text = SB.ToString();
            } catch (FileNotFoundException exception)
            {
                Console.WriteLine("해당 파일을 못 찾았습니다. : " + exception.Message);
            } catch (Exception exception)
            {
                Console.WriteLine("알 수 없는 에러가 발생했습니다. : " + exception.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 저장

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 글꼴
            FontDialog FD = fontDialog1;
            FD.ShowDialog();
            textBox1.Font = FD.Font;
            textBox1.ForeColor = FD.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 배경 색
            ColorDialog C = colorDialog1;
            C.ShowDialog();
            textBox1.BackColor = C.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 찾기


        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 인쇄
            PrintDialog PDialog = printDialog1;
            PrinterSettings PS = new PrinterSettings();
            PrintDocument PDocument = new PrintDocument();

            PDialog.PrinterSettings = PS;
            PDialog.Document = PDocument;

            PDialog.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 종료
            Close();
        }
    }
}
