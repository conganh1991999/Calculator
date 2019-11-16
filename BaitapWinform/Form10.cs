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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
        String chuoitam = "";  //Dùng để lưu giữ tạm giá trị của số nhập vào 
        char toantu; //Dùng lưu kí hiệu toán tử của phép toán, vd: +, -, *, / 
        double[] toanhang = new double[2]; //Lưu 2 toán hạng (số hạng) của phép toán
        double ketqua; //Dùng lưu kết quả của phép toán 
        int buoc = 1; //Dùng lưu giữ số bước thực hiện phép toán 

        private void NumberButtons(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if ((b == null) || (b.Text == "0" && chuoitam.Length == 0)) return;
            chuoitam += b.Text;
            txtManHinh.Text = chuoitam;
        }
        private void btnCongTru_Click(object sender, EventArgs e)
        {
            if (chuoitam.Contains('-'))
                chuoitam = chuoitam.Replace("-", "");
            else
                chuoitam = "-" + chuoitam;
            txtManHinh.Text = chuoitam;
        }
        private void btnCham_Click(object sender, EventArgs e)
        {
            if (!chuoitam.Contains('.'))
            {
                chuoitam = chuoitam + ".";
                txtManHinh.Text = chuoitam;
            }
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            if (chuoitam.Length == 0)
            {
                buoc = 1;
                toanhang[0] = toanhang[1] = 0.0;
                toantu = ' ';
                ketqua = 0.0;
            }
            else
                chuoitam = "0";
            txtManHinh.Text = chuoitam;
        }
        private void btnBang_Click(object sender, EventArgs e)
        {
            if (chuoitam.Length != 0)
                toanhang[1] = Double.Parse(chuoitam);
            switch (toantu)
            {
                case '+': ketqua = toanhang[0] + toanhang[1]; break;
                case '-': ketqua = toanhang[0] - toanhang[1]; break;
                case '*': ketqua = toanhang[0] * toanhang[1]; break;
                case '/': ketqua = toanhang[0] / toanhang[1]; break;
            }
            txtManHinh.Text = ketqua.ToString();
            //Gán lại giá trị ban đầu 
            buoc = 1;             
            chuoitam = "";
        }
        private void Operations(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (buoc == 1)
                toantu = b.Text[0]; //Lấy kí hiệu toán tử              
            if (chuoitam.Length == 0)
                toanhang[buoc - 1] = ketqua;
            else
                toanhang[buoc - 1] = Double.Parse(chuoitam);
            if (buoc == 2)
            {
                btnBang_Click(null, null);
                toantu = b.Text[0];
                toanhang[0] = ketqua;
                buoc = 2;
            }
            else
            {
                txtManHinh.Text = toanhang[0].ToString();
                buoc++;
            }
            chuoitam = "";
        } 
    }
}
