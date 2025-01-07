using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNhap.ResetText();
            txtKQ.ResetText();
            txtKQ.ReadOnly = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            err1.Clear();
            int so = 0;
            if(int.TryParse(txtNhap.Text, out so) == false)
            {
                err1.SetError(txtNhap, "Nhập 1 số từ 1 đến 999");
            }
            else
            {
                if(so >= 0 && so <= 9)
                {
                    txtKQ.Text = donVi(so);
                }
                else if(so >= 10 && so <= 99)
                {
                    int dv = so % 10;
                    int c = so / 10;
                    if (dv == 0 && c != 0)
                    {
                        txtKQ.Text = hoaChuCaiDau(chuc(c));
                    }
                    else if(dv == 5 && c != 0)
                    {
                        txtKQ.Text = hoaChuCaiDau(chuc(c)) + " " + "lăm";
                    }
                    else
                    {
                        txtKQ.Text = hoaChuCaiDau(chuc(c))+ " " + donVi(dv);
                    }
                }
                else if(so >= 100 && so <= 999)
                {
                    int dv = so % 10;
                    int c = so / 10 % 10;
                    int t = so / 100;
                    if (dv == 0 && c == 0 && t != 0)
                    {
                        txtKQ.Text = hoaChuCaiDau(tram(t));
                    }
                    else if (dv != 0 && c == 0 && t != 0)
                    {
                        txtKQ.Text = hoaChuCaiDau(tram(t)) + " " + "linh" + " " + donVi(dv);
                    }
                    else if (dv == 5 && (c > 0 && c <= 9) && t != 0)
                    {
                        txtKQ.Text = hoaChuCaiDau(tram(t)) + " " + chuc(c) + " " + "lăm";
                    }
                    else
                    {
                        txtKQ.Text = hoaChuCaiDau(chuc(c)) + " " + tram(t) + " " + donVi(dv);
                    }
                }
                txtKQ.ReadOnly = true;
            }
        }
        public string hoaChuCaiDau(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }
        public string donVi(int n)
        {
            switch(n)
            {
                case 0:
                    return "không";
                    break;
                case 1:
                    return "một";
                    break;
                case 2:
                    return "hai";
                    break;
                case 3:
                    return "ba";
                    break;
                case 4:
                    return "bốn";
                    break;
                case 5:
                    return "năm";
                    break;
                case 6:
                    return "sáu";
                    break;
                case 7:
                    return "bảy";
                    break;
                case 8:
                    return "tám";
                    break;
                case 9:
                    return "chín";
                    break;
                default:
                    return "";
                    break;
            }
        }
        public string chuc(int n)
        {
            switch (n)
            {
                case 0:
                    return "linh";
                    break;
                case 1:
                    return "mười";
                    break;
                case 2:
                    return "hai mươi";
                    break;
                case 3:
                    return "ba mươi";
                    break;
                case 4:
                    return "bốn mươi";
                    break;
                case 5:
                    return "năm mươi";
                    break;
                case 6:
                    return "sáu mươi";
                    break;
                case 7:
                    return "bảy mươi";
                    break;
                case 8:
                    return "tám mươi";
                    break;
                case 9:
                    return "chín mươi";
                    break;
                default:
                    return "";
                    break;
            }
        }
        public string tram(int n)
        {
            switch (n)
            {
                case 1:
                    return "một trăm";
                    break;
                case 2:
                    return "hai trăm";
                    break;
                case 3:
                    return "ba trăm";
                    break;
                case 4:
                    return "bốn trăm";
                    break;
                case 5:
                    return "năm trăm";
                    break;
                case 6:
                    return "sáu trăm";
                    break;
                case 7:
                    return "bảy trăm";
                    break;
                case 8:
                    return "tám trăm";
                    break;
                case 9:
                    return "chín trăm";
                    break;
                default:
                    return "";
                    break;
            }
        }
    }
}
