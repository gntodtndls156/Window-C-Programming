using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_라디오버튼과_리스트상자
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] str1 = new string[3] { "버튼", "체크 상자", "라디오 버튼" };
        String[] str2 = new string[3] { "리스트 상자", "콤보 상자", "체크 리스트 상자" };

        private void AddButtonList()
        {
            for (int i = 0; i < 3; i++)
                listBox1.Items.Add(str1[i]);
        }
        private void AddListList()
        {
            for (int i = 0; i < 3; i++)
                listBox1.Items.Add(str2[i]);
        }
        private void ClearList()
        {
            listBox1.Items.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                ClearList();
                AddButtonList();
            }
            else
            {
                ClearList();
                AddListList();
            }
        }
    }
}
