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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, c;
            a = Convert.ToSingle(textA.Text);
            b = Convert.ToSingle(textB.Text);
            c = Convert.ToSingle(textC.Text);
            if ((a >= b) & (a >= c))
            {
                textmax.Text = textA.Text;
                if (b >= c)
                    textmin.Text = textC.Text;
                else
                    textmin.Text = textB.Text;
            }
            else if ((b >= a) & (b >= c))
            {
                textmax.Text = textB.Text;
                if (a >= c)
                    textmin.Text = textC.Text;
                else
                    textmin.Text = textA.Text;
            }
            else
            {
                textmax.Text = textC.Text;
                if (b >= a)
                    textmin.Text = textA.Text;
                else
                    textmin.Text = textB.Text;
            }
        }
    }
}
