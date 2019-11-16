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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textN.Text); 
            float X = Convert.ToSingle(textX.Text);
            double S = 0;
            for(int i = 1; i <= N; i++)
            {
                if (i == 1)
                {
                    textS1.Text += 'X';
                    textS2.Text += Convert.ToString(X);
                    textS3.Text += Convert.ToString(X);
                }
                else
                {
                    textS1.Text += "+X^" + Convert.ToString(i);
                    textS2.Text += "+" + Convert.ToString(X) + "^" + Convert.ToString(i);
                    textS3.Text += "+" + Convert.ToString(Math.Pow(X, i));
                }
                S += Math.Pow(X, i);
            }
            textS4.Text = Convert.ToString(S);
        }
    }
}
