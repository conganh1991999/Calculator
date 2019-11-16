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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(textA.Text);
            float b = Convert.ToSingle(textB.Text);
            if (a > b)
            {
                textmax.Text = textA.Text;
                textmin.Text = textB.Text;
            }
            else
            {
                textmin.Text = textA.Text;
                textmax.Text = textB.Text;
            }
        }
    }
}
