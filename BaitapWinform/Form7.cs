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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        int i = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Bạn đã click " + Convert.ToString(i) + " lần";
            i++;
        }
    }
}
