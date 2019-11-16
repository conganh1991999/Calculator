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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public String Doc3so(String so)
        {
            String num = "0123456789";
            String[] num_name = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            String text = "";
            for (int i = 0; i < 10; i++)
            {
                if (so[0] == num[i])
                {
                    text += num_name[i] + " trăm ";
                    break;
                }
            }

            if (so[1] == '0')
            {
                if (so[2] == '0')
                    text += "";
                else
                {
                    text += "lẻ ";
                    for (int i = 1; i < 10; i++)
                    {
                        if (so[2] == num[i])
                        {
                            text = text + num_name[i] + " ";
                            break;
                        }
                    }
                }
            }
            else if (so[1] == '1')
            {
                text += "mười ";
                for (int i = 1; i < 10; i++)
                {
                    if (so[2] == num[i])
                    {
                        text = text + num_name[i] + " ";
                        break;
                    }
                }
            }
            else
            {
                for (int i = 2; i < 10; i++)
                {
                    if (so[1] == num[i])
                    {
                        text += num_name[i] + " mươi ";
                        break;
                    }
                }
                if (so[2] == '1')
                    text += "mốt ";
                else
                {
                    for (int i = 2; i < 10; i++)
                    {
                        if (so[2] == num[i])
                        {
                            text += num_name[i] + " ";
                            break;
                        }
                    }
                }
            }
            return text;
        }

        public String Xuly(String inp)
        {
            String[] num_name = { "", "nghìn ", "triệu ", "tỉ " };
            while ((inp.Length % 3) != 0)
            {
                inp = '0' + inp;
            }
            int count = inp.Length / 3;
            String[] triple = new String[count];
            for (int i = 0; i < count; i++)
            {
                triple[i] = triple[i] + inp[3 * i] + inp[3 * i + 1] + inp[3 * i + 2];
            }
            inp = "";
            for (int i = 0; i < count; i++)
            {
                inp = inp + Doc3so(triple[i]) + num_name[count - i - 1];
            }
            return inp;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = textinput.Text;
            textread.Text = Xuly(text);
        }
    }
}
