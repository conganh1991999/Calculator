using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BaitapWinform
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        String manhinh = "";
        String memory = "";
        String[] temp1 = new String[2];
        String[] temp2 = new String[2];
        String Opera;
        double mem_1, mem_2;

        void Check_String(String MH)
        {
            if ((MH[0] == '+') | (MH[0] == '-'))
            {
                for (int i = 0; i < 2; i++)
                {
                    var match_1 = Regex.Match(MH, @"([+-]*)");
                    if (match_1.Success)
                    {
                        temp1[i] = Convert.ToString(match_1.Value);
                        MH = MH.Remove(MH.IndexOf(Convert.ToString(match_1)), Convert.ToString(match_1).Length);
                    }
                    else
                        temp1[i] = "";
                    var match_2 = Regex.Match(MH, @"([0-9]*\.?[0-9]+)");
                    if (match_2.Success)
                    {
                        temp2[i] = Convert.ToString(match_2.Value);
                        MH = MH.Remove(MH.IndexOf(Convert.ToString(match_2)), Convert.ToString(match_2).Length);
                    }
                    else
                        temp2[i] = "";
                }
                Opera = MH;
            }
            else
            {
                temp1[0] = "";
                var match_2 = Regex.Match(MH, @"([0-9]*\.?[0-9]+)");
                if (match_2.Success)
                {
                    temp2[0] = Convert.ToString(match_2.Value);
                    MH = MH.Remove(MH.IndexOf(Convert.ToString(match_2)), Convert.ToString(match_2).Length);
                }
                else
                    temp2[0] = "";
                var match_1 = Regex.Match(MH, @"([+-]*)");
                if (match_1.Success)
                {
                    temp1[1] = Convert.ToString(match_1.Value);
                    MH = MH.Remove(MH.IndexOf(Convert.ToString(match_1)), Convert.ToString(match_1).Length);
                }
                else
                    temp1[1] = "";
                var match_3 = Regex.Match(MH, @"([0-9]*\.?[0-9]+)");
                if (match_3.Success)
                {
                    temp2[1] = Convert.ToString(match_3.Value);
                    MH = MH.Remove(MH.IndexOf(Convert.ToString(match_3)), Convert.ToString(match_3).Length);
                }
                else
                    temp2[1] = "";
                Opera = MH;
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Manhinh.Text += '7';
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Manhinh.Text += '8';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Manhinh.Text += '9';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Manhinh.Text += '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Manhinh.Text += '5';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Manhinh.Text += '6';
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Manhinh.Text += '1';
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Manhinh.Text += '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Manhinh.Text += '3';
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Manhinh.Text += '0';
        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            Manhinh.Text += '.';
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            manhinh = Manhinh.Text;
            Manhinh.Text = manhinh + '+';
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            manhinh = Manhinh.Text;
            Manhinh.Text = manhinh + '-';
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            manhinh = Manhinh.Text;
            Manhinh.Text = manhinh + '*';
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            manhinh = Manhinh.Text;
            Manhinh.Text = manhinh + '/';
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (Manhinh.Text.Length != 0)
                Manhinh.Text = Manhinh.Text.Remove(Manhinh.Text.Length - 1, 1);
            else
                Manhinh.Text = Manhinh.Text;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Manhinh.Text = "";
        }

        private void btnSp_Click(object sender, EventArgs e)
        {
            Manhinh.Text = "Invalid Function Menu...";
        }

        private void btnCongTru_Click(object sender, EventArgs e)
        {
            Manhinh.Text = "Invalid Function Menu...";
        }

        private void btnSQ_Click(object sender, EventArgs e)
        {
            var match_n = Regex.Match(Manhinh.Text, @"([+-]*[0-9]*\.?[0-9]+)");
            if (match_n.Success)
            {
                Manhinh.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(match_n.Value)));
            }
            else
                Manhinh.Text = "Syntax Error";
        }

        private void btnPhanTram_Click(object sender, EventArgs e)
        {
            var match_n = Regex.Match(Manhinh.Text, @"([+-]*[0-9]*\.?[0-9]+)");
            if (match_n.Success)
            {
                Manhinh.Text = Convert.ToString(Convert.ToDouble(match_n.Value) / 100.0);
            }
            else
                Manhinh.Text = "Syntax Error";
        }

        private void btnChiaX_Click(object sender, EventArgs e)
        {
            var match_n = Regex.Match(Manhinh.Text, @"([+-]*[0-9]*\.?[0-9]+)");
            if (match_n.Success)
            {
                Manhinh.Text = Convert.ToString(1.0 / Convert.ToDouble(match_n.Value));
            }
            else
                Manhinh.Text = "Syntax Error";
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            Manhinh.Text = "Invalid Function Menu...";
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            Manhinh.Text = "Invalid Function Menu...";
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            Manhinh.Text = "Invalid Function Menu...";
        }

        private void btnMP_Click(object sender, EventArgs e)
        {
            Manhinh.Text = "Invalid Function Menu...";
        }

        private void btnMN_Click(object sender, EventArgs e)
        {
            Manhinh.Text = "Invalid Function Menu...";
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            if (Manhinh.Text.Length == 0)
                Manhinh.Text = Manhinh.Text;
            else
            {
                Check_String(Manhinh.Text);

                if (temp2[0].Length == 0)
                    Manhinh.Text = "Syntax Error";
                else if ((temp2[1].Length == 0) & temp1[1].Length != 0)
                    Manhinh.Text = "Syntax Error";
                else if ((temp2[0].Length != 0) & (temp2[1].Length == 0) & (temp1[1].Length == 0))
                {
                    if (temp1[0].Length == 0)
                        temp2[0] = '+' + temp2[0];
                    else
                    {
                        String ASS = temp1[0];
                        int A = 0;
                        for (int i = 0; i < ASS.Length; i++)
                        {
                            if (ASS[i] == '-')
                                A += 1;
                        }
                        if ((A % 2) == 0)
                            temp2[0] = '+' + temp2[0];
                        else
                            temp2[0] = '-' + temp2[0];
                    }
                    Manhinh.Text = temp2[0];
                }
                else
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (temp1[i].Length == 0)
                            temp2[i] = '+' + temp2[i];
                        else
                        {
                            String SS = temp1[i];
                            int count = 0;
                            for (int j = 0; j < SS.Length; j++)
                            {
                                if (SS[j] == '-')
                                    count += 1;
                            }
                            if ((count % 2) == 0)
                                temp2[i] = '+' + temp2[i];
                            else
                                temp2[i] = '-' + temp2[i];
                        }
                    }
                    mem_1 = Convert.ToDouble(temp2[0]);
                    mem_2 = Convert.ToDouble(temp2[1]);
                    if (Opera == "")
                    {
                        memory = Convert.ToString(mem_1 + mem_2);
                        Manhinh.Text = memory;
                    }

                    else if (Opera == "*")
                    {
                        memory = Convert.ToString(mem_1 * mem_2);
                        Manhinh.Text = memory;
                    }
                    else if (Opera == "/")
                    {
                        memory = Convert.ToString(mem_1 / mem_2);
                        Manhinh.Text = memory;
                    }
                    else
                        Manhinh.Text = "Syntax Error...";
                }
            }
        }
    }
}