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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String number = "0123456789";
            String text = textinp.Text;
            String[] Num = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
            if (String.IsNullOrEmpty(text) == true) { }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    if (text[0] == number[i])
                    {
                        textout.Text = Num[i];
                        break;
                    }
                }
            }
        }
    }
}
