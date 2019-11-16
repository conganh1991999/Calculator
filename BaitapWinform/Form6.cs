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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textN.Text);
            int S = 0; String text = "";
            for (int i = 1; i <= a; i++)
            {
                S = S + i;
                text += Convert.ToString(i);
                if (i < a)
                    text += " + ";
            }
            textS1.Text = text;
            textS2.Text = Convert.ToString(S);
        }
    }
}
