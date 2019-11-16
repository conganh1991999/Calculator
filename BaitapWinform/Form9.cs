using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaitapWinform
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        //hàm kiểm tra số nhập vào
        public bool check(String text1, String text2)
        {
            if ((String.IsNullOrEmpty(text1) == false) & (String.IsNullOrEmpty(text2) == false))
                return true;
            else
                return false;
        }
        int pheptinh;
        double result;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pheptinh = 1;  
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pheptinh = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pheptinh = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pheptinh = 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check(textfirst.Text, textsecond.Text) == true)
            {
                switch (pheptinh)
                {
                    case 1: result = Convert.ToDouble(textfirst.Text) + Convert.ToDouble(textsecond.Text); break;
                    case 2: result = Convert.ToDouble(textfirst.Text) - Convert.ToDouble(textsecond.Text); break;
                    case 3: result = Convert.ToDouble(textfirst.Text) * Convert.ToDouble(textsecond.Text); break;
                    case 4: result = Convert.ToDouble(textfirst.Text) / Convert.ToDouble(textsecond.Text); break;
                }
            }
            textresult.Text = Convert.ToString(result);
        }
    }
}
